using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.Model
{
    /// <summary>
    /// 角色model类
    /// </summary>
    public class Role
    {
        #region 属性
        /// <summary>
        /// 行编号
        /// </summary>
        public Guid id { set; get; }

        /// <summary>
        /// 角色编号
        /// </summary>
        public int userNum { set; get; }

        /// <summary>
        /// 角色密码
        /// </summary>
        public string password { set; get; }

        /// <summary>
        /// 是否被删除
        /// </summary>
        public bool isDeleted { set; get; }

        /// <summary>
        /// 是否被锁住
        /// </summary>
        public bool isLocked { set; get; }

        /// <summary>
        /// 被锁时间
        /// </summary>
        public DateTime? lockTime { set; get; }

        /// <summary>
        /// 是否是管理员
        /// </summary>
        public bool isAdmin { set; get; }

        /// <summary>
        /// 登录错误次数
        /// </summary>
        public int errorCount { set; get; }
        #endregion
    }
}
