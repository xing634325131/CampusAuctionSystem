using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.DAL
{
    /// <summary>
	/// SqlHelper 的摘要说明
	/// </summary>
    public class SqlHelper
    {
        //数据库连接字符串
        //private static string conStr = ConfigurationManager.ConnectionStrings["SqlConnString"].ConnectionString;
        private static string conStr = "Data Source=.; Initial Catalog=CampusAuctionSystem;User ID=sa;Password=123";

        #region 执行查询sql
        /// <summary>
        /// 执行查询sql
        /// </summary>
        /// <param name="procname">存储过程名称</param>
        /// <param name="pars">参数数组</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteDataTable(string sqlHandle, params SqlParameter[] parameter)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sqlHandle;
                    cmd.Parameters.AddRange(parameter);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }
        #endregion

        #region 执行执行添加、修改、删除sql
        /// <summary>
        /// 执行执行添加、修改、删除sql
        /// </summary>
        /// <param name="procname">存储过程名称</param>
        /// <param name="pars">参数数组</param>
        /// <returns>返回受影响行数</returns>
        public static int ExecuteNonQuery(string sqlHandle, params SqlParameter[] parameter)
        {
            string temp = conStr;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sqlHandle;
                    cmd.Parameters.AddRange(parameter);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
