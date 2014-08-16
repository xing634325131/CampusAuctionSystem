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
    /// 用户访问层
    /// </summary>
    public class UserInfoDal
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户</param>
        /// <returns>返回是否添加成功</returns>
        public bool Add(UserInfo user)
        {
            int i = SqlHelper.ExecuteNonQuery("insert into UserInfo(UserId,NickName,RealName,Gender,Email,QQ,Tel,Address) values(@userId,@nickName,@realName,@gender,@email,@QQ,@tel,@address)",
                new SqlParameter("@userId", user.userId), new SqlParameter("@nickName", user.nickName),
                new SqlParameter("@realName", Services.ToDBValue(user.realName)), new SqlParameter("@gender", Services.ToDBValue(user.gender)),
                new SqlParameter("@email", user.email), new SqlParameter("@QQ", Services.ToDBValue(user.QQ)),
                new SqlParameter("@tel", user.tel), new SqlParameter("@address", Services.ToDBValue(user.address)));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("添加用户信息错误！");
            }
        }

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="user">用户</param>
        /// <returns>返回是否更新成功</returns>
        public bool Update(UserInfo user)
        {
            int i = SqlHelper.ExecuteNonQuery(@"update UserInfo set NickName=@nickName,RealName=@realName,Gender=@gender,Email=@email,QQ=@QQ,
                Tel=@tel,Address=@address,Photo=@photo,GradeId=@gradeId,Profile=@profile,Signature=@signature,Films=@films,Books=@books,Birthday=@birthday where Id=@id",
                new SqlParameter("@id", user.id), new SqlParameter("@nickName", user.nickName),
                new SqlParameter("@realName", Services.ToDBValue(user.realName)), new SqlParameter("@gender", Services.ToDBValue(user.gender)),
                new SqlParameter("@email", user.email), new SqlParameter("@QQ", Services.ToDBValue(user.QQ)),
                new SqlParameter("@tel", user.tel), new SqlParameter("@address", Services.ToDBValue(user.address)),
                new SqlParameter("@photo", Services.ToDBValue(user.photo)), new SqlParameter("@gradeId", Services.ToDBValue(user.gradeId)),
                new SqlParameter("@profile", Services.ToDBValue(user.profile)), new SqlParameter("@signature", Services.ToDBValue(user.signature)),
                new SqlParameter("@films", Services.ToDBValue(user.films)), new SqlParameter("@books", Services.ToDBValue(user.books)),
                new SqlParameter("@birthday", Services.ToDBValue(user.birthday)));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("更新用户信息错误！");
            }
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>用户信息</returns>
        public UserInfo GerUser(Guid userId)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from UserInfo where UserId=@userId", new SqlParameter("@userId", userId));
            if (Services.ForTableCount(table.Rows.Count))
            {
                throw new Exception("获取用户信息错误！");
            }
            return ToModel(table.Rows[0]);
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="userId">用户名称</param>
        /// <returns>用户信息</returns>
        public UserInfo GerUser(string userName)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from UserInfo where UserName=@userName", new SqlParameter("@userName", userName));
            if (Services.ForTableCount(table.Rows.Count))
            {
                throw new Exception("获取用户信息错误！");
            }
            return ToModel(table.Rows[0]);
        }

        /// <summary>
        /// 检测用户名重复
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>是否存在该用户名</returns>
        public bool IsExist(string userName)
        {
            List<UserInfo> userList = GetAll();
            foreach (UserInfo user in userList)
            {
                if (user.nickName == userName)//存在该昵称（用户名）则返回
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 获得所有用户信息
        /// </summary>
        /// <returns>所有用户</returns>
        public List<UserInfo> GetAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from UserInfo");
            List<UserInfo> userList = new List<UserInfo>();
            foreach (DataRow row in table.Rows)
            {
                userList.Add(ToModel(row));
            }
            return userList;
        }

        /// <summary>
        /// 建立用户model
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private UserInfo ToModel(DataRow dataRow)
        {
            UserInfo user = new UserInfo();
            user.id = (Guid)dataRow["ID"];
            user.nickName = Convert.ToString(dataRow["NickName"]).Trim();
            user.photo = (byte[])Services.FromDBValue(dataRow["Photo"]);
            user.address = Convert.ToString(Services.FromDBValue(dataRow["Address"])).Trim();
            user.email = Convert.ToString(dataRow["Email"]).Trim();
            user.gender = Convert.ToString(Services.FromDBValue(dataRow["Gender"])).Trim();
            user.QQ = Convert.ToString(Services.FromDBValue(dataRow["QQ"])).Trim();
            user.realName = Convert.ToString(Services.FromDBValue(dataRow["RealName"])).Trim();
            user.tel = Convert.ToString(dataRow["Tel"]).Trim();
            user.userId = (Guid)dataRow["UserId"];
            user.gradeId = (Guid?)Services.FromDBValue(dataRow["GradeId"]);
            user.profile = Convert.ToString(Services.FromDBValue(dataRow["Profile"])).Trim(); ;
            user.signature = Convert.ToString(Services.FromDBValue(dataRow["Signature"])).Trim();
            user.books = Convert.ToString(Services.FromDBValue(dataRow["Books"])).Trim(); ;
            user.films = Convert.ToString(Services.FromDBValue(dataRow["Films"])).Trim();
            user.birthday = (DateTime?)Services.FromDBValue(dataRow["Birthday"]);
            return user;
        }
    }
}
