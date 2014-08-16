using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.Model
{
    /// <summary>
    /// 用户信息model类
    /// </summary>
    public class UserInfo
    {
        #region 属性
        /// <summary>
        /// 行编号
        /// </summary>
        public Guid id { set; get; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid userId { set; get; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string nickName { set; get; }

        /// <summary>
        /// 真实名字
        /// </summary>
        public string realName { set; get; }

        /// <summary>
        /// 性别
        /// </summary>
        public string gender { set; get; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string email { set; get; }

        /// <summary>
        /// QQ
        /// </summary>
        public string QQ { set; get; }

        /// <summary>
        /// 手机/电话
        /// </summary>
        public string tel { set; get; }

        /// <summary>
        /// 联系地址
        /// </summary>
        public string address { set; get; }

        /// <summary>
        /// 头像
        /// </summary>
        public byte[] photo { set; get; }

        /// <summary>
        /// 年级ID
        /// </summary>
        public Guid? gradeId { set; get; }

        /// <summary>
        /// 个人简介
        /// </summary>
        public string profile { set; get; }

        /// <summary>
        /// 个性签名
        /// </summary>
        public string signature { set; get; }

        /// <summary>
        /// 影视
        /// </summary>
        public string films { set; get; }

        /// <summary>
        /// 书籍
        /// </summary>
        public string books { set; get; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? birthday { set; get; }
        #endregion
    }
    
}
