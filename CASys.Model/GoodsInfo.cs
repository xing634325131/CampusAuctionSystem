using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.Model
{
    /// <summary>
    /// 物品信息model类
    /// </summary>
    public class GoodsInfo
    {
        #region 属性
        /// <summary>
        /// 物品编号
        /// </summary>
        public Guid id { set; get; }

        /// <summary>
        /// 所有者ID
        /// </summary>
        public Guid ownerId { set; get; }

        /// <summary>
        /// 物品名称
        /// </summary>
        public string name { set; get; }

        /// <summary>
        /// 物品图片
        /// </summary>
        public byte[] picture { set; get; }

        /// <summary>
        /// 物品描述
        /// </summary>
        public string description { set; get; }

        /// <summary>
        /// 物品分类ID
        /// </summary>
        public Guid categoryId { set; get; }
        #endregion
    }
}
