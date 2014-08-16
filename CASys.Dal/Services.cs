using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.DAL
{
    /// <summary>
    /// 访问层服务类
    /// </summary>
    public class Services
    {
        /// <summary>
        /// 将要插入数据库的空值转化为数据库中的空值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object ToDBValue(object value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// 将要数据库的空值转化为读出的空值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object FromDBValue(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// 捕捉数据异常情况
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool ForTableCount(int count)
        {
            if (count > 1)
            {
                throw new Exception("数据重复！");
            }
            else if (count <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
