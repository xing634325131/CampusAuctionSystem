using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.Model
{
    /// <summary>
    /// 物品交易过程记录model类
    /// </summary>
    public class ProcessRecord
    {
        #region 属性
        /// <summary>
        /// 过程编号
        /// </summary>
        public Guid id { set; get; }

        /// <summary>
        /// 物品ID
        /// </summary>
        public Guid goodsId { set; get; }

        /// <summary>
        /// 拍卖时间
        /// </summary>
        public DateTime tradeTime { set; get; }

        /// <summary>
        /// 拍卖者ID
        /// </summary>
        public Guid tradeNameId { set; get; }

        /// <summary>
        /// 拍卖价格
        /// </summary>
        public decimal tradePrice { set; get; }
        #endregion
    }
}
