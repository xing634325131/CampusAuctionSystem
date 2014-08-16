using CASys.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.DAL
{
    /// <summary>
    /// 角色访问层
    /// </summary>
    public class RoleDal
    {
        /// <summary>
        /// 添加角色（用户）
        /// </summary>
        /// <param name="role">角色信息，返回系统给的编号</param>
        /// <returns>返回是否添加角色成功</returns>
        public bool Add(ref Role role)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select max(UserNum) maxNum from Role");//得到最大目前编号
            role.userNum = (int)table.Rows[0]["maxNum"] + 1;
            int i = SqlHelper.ExecuteNonQuery("insert into Role(UserNum,Password,IsDeleted,IsLocked,LockTime,IsAdmin,ErrorCount) values(@userNum,@password,@isDeleted,@isLocked,@lockTime,@isAdmin,@errorCount)",
                new SqlParameter("@userNum", role.userNum), new SqlParameter("@password", role.password), new SqlParameter("@isDeleted", false),
                new SqlParameter("@isLocked", false), new SqlParameter("@lockTime", Services.ToDBValue(null)),
                new SqlParameter("@isAdmin", role.isAdmin), new SqlParameter("@errorCount", 1));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("添加角色信息错误！");
            }
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="role">角色</param>
        /// <returns>返回是否存在该角色</returns>
        public bool IsExist(Role role)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from Role where Id=@id and Password=@password and IsAdmin=@isAdmin",
                new SqlParameter("@id", role.id), new SqlParameter("@password", role.password),
                new SqlParameter("@isAdmin", role.isAdmin));
            if (table.Rows.Count <= 0)
            {
                return false;
            }
            else if (table.Rows.Count > 1)
            {
                throw new Exception("用户名重复！！无法登录");
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 获得所有角色
        /// </summary>
        /// <returns>所有角色信息</returns>
        public List<Role> GetAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from Role");
            List<Role> roleList = new List<Role>();
            foreach (DataRow row in table.Rows)
            {
                roleList.Add(ToModel(row));
            }
            return roleList;
        }

        /// <summary>
        /// 根据角色编号得到角色信息
        /// </summary>
        /// <param name="userNum">角色编号</param>
        /// <returns>返回角色信息</returns>
        public Role GetRole(int userNum)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from Role where UserNum=@userNum", new SqlParameter("@userNum", userNum));
            if (Services.ForTableCount(table.Rows.Count))
            {
                throw new Exception("获取角色信息错误！");
            }
            return ToModel(table.Rows[0]);
        }

        /// <summary>
        /// 根据ID得到角色信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>返回角色信息</returns>
        public Role GetRole(Guid id)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from Role where Id=@id", new SqlParameter("@id", id));
            if (Services.ForTableCount(table.Rows.Count))
            {
                throw new Exception("获取角色信息错误！");
            }
            return ToModel(table.Rows[0]);
        }

        /// <summary>
        /// 更新角色信息
        /// </summary>
        /// <param name="role">角色信息</param>
        /// <returns>返回是否更新成功</returns>
        public bool Update(Role role)
        {
            int i = SqlHelper.ExecuteNonQuery("update Role set Password=@password,IsLocked=@isLocked,LockTime=@lockTime,ErrorCount=@errorCount where Id=@id",
                new SqlParameter("@id", role.id), new SqlParameter("@password", role.password), new SqlParameter("@isLocked", (role.isLocked == true ? 1 : 0)),
                new SqlParameter("@lockTime", Services.ToDBValue(role.lockTime)), new SqlParameter("@errorCount", role.errorCount));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("更新角色信息错误！");
            }
        }

        /// <summary>
        /// 软删除用户
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>返回是否删除成功</returns>
        public bool Delete(Guid id)
        {
            int i = SqlHelper.ExecuteNonQuery("update Role set IsDeleted=@isDeleted where Id=@id",new SqlParameter("@id", id), new SqlParameter("@isDeleted", true));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("删除角色信息错误！");
            }
        }

        /// <summary>
        /// 建立角色model
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private Role ToModel(DataRow dataRow)
        {
            Role role = new Role();
            role.id = (Guid)dataRow["Id"];
            role.userNum = Convert.ToInt32(dataRow["UserNum"]);
            role.isDeleted = (bool)dataRow["IsDeleted"];
            role.isLocked = (bool)dataRow["IsLocked"];
            role.lockTime = (DateTime?)Services.FromDBValue(dataRow["LockTime"]);
            role.isAdmin = (bool)dataRow["IsAdmin"];
            role.password = Convert.ToString(dataRow["Password"]).Trim();
            role.errorCount = (int)dataRow["ErrorCount"];
            return role;
        }
    }
}
