using CASys.DAL;
using CASys.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.Dal
{
    /// <summary>
    /// 院系专业年级对应访问层
    /// </summary>
    public class GradeDal
    {
        /// <summary>
        /// 添加年级/专业信息
        /// </summary>
        /// <param name="grade">年级/专业信息</param>
        /// <returns>返回是否添加成功信息</returns>
        public bool Add(Grade grade)
        {
            int i=SqlHelper.ExecuteNonQuery("insert into Grade(UpperId,Name) values(@upperId,@name)",
                new SqlParameter("@upperId",grade.upperId),new SqlParameter("@name",grade.name));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("添加年级信息失败！");
            }
        }

        /// <summary>
        /// 添加学院信息
        /// </summary>
        /// <param name="name">学院信息</param>
        /// <returns>返回是否添加成功信息</returns>
        public bool Add(string name)
        {
            Guid upperId = Guid.Parse("d210401f-2b91-446d-97d0-4a18521ca5e6");
            int i = SqlHelper.ExecuteNonQuery("insert into Grade(UpperId,Name) values(@upperId,@name)",
                new SqlParameter("@upperId", upperId), new SqlParameter("@name", name));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("添加年级信息失败！");
            }
        }

        /// <summary>
        /// 更新信息
        /// </summary>
        /// <param name="grade">年级信息</param>
        /// <returns>返回是否更新成功</returns>
        public bool Update(Grade grade)
        {
            int i = SqlHelper.ExecuteNonQuery("update Grade set UpperId=@upperId,Name=@name where Id=@id",
                new SqlParameter("@upperId", grade.upperId), new SqlParameter("@name", grade.name),
                new SqlParameter("@Id", grade.id));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("添加年级信息失败！");
            }
        }

        /// <summary>
        /// 得到所有学院
        /// </summary>
        /// <returns>返回所有学院</returns>
        public List<Grade> GetAll()
        {
            Guid upperId = Guid.Parse("d210401f-2b91-446d-97d0-4a18521ca5e6");
            DataTable table = SqlHelper.ExecuteDataTable("select * from Grade where UpperId=@upperId", new SqlParameter("@upperId", upperId));
            List<Grade> gradeList = new List<Grade>();
            foreach (DataRow row in table.Rows)
            {
                gradeList.Add(ToModel(row));
            }
            return gradeList;
        }

        /// <summary>
        /// 得到所有上一层的下一层信息
        /// </summary>
        /// <param name="upperId">编号</param>
        /// <returns>下一层信息</returns>
        public List<Grade> GetAll(Guid upperId)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from Grade where UpperId=@upperId", new SqlParameter("@upperId", upperId));
            List<Grade> gradeList = new List<Grade>();
            foreach (DataRow row in table.Rows)
            {
                gradeList.Add(ToModel(row));
            }
            return gradeList;
        }

        /// <summary>
        /// 建立年级model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Grade ToModel(DataRow row)
        {
            Grade grade = new Grade();
            grade.id = (Guid)row["Id"];
            grade.upperId = (Guid)row["UpperId"];
            grade.name = Convert.ToString(row["Name"]).Trim();
            return grade;
        }
    }
}
