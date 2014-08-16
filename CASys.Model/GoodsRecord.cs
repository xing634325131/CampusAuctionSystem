using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.Model
{
    /// <summary>
    /// 物品交易记录model类
    /// </summary>
    public class GoodsRecord
    {
        #region 属性
        /// <summary>
        /// 交易编号
        /// </summary>
        public Guid id { set; get; }

        /// <summary>
        /// 物品ID
        /// </summary>
        public Guid goodsId { set; get; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime startTime { set; get; }

        /// <summary>
        /// 拍卖持续时间
        /// </summary>
        public int auctionTime { set; get; }

        /// <summary>
        /// 是否交易成功
        /// </summary>
        public bool isTrade { set; get; }

        /// <summary>
        /// 起拍价
        /// </summary>
        public decimal startPrice { set; get; }

        /// <summary>
        /// 加价幅度
        /// </summary>
        public decimal rangePrice { set; get; }

        /// <summary>
        /// 成交价
        /// </summary>
        public decimal? endprice { set; get; }

        /// <summary>
        /// 是否上线
        /// </summary>
        public bool isOnline { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { set; get; }

        /// <summary>
        /// 最后所有者ID
        /// </summary>
        public Guid? getNameId { set; get; }

        /// <summary>
        /// 是否处理
        /// </summary>
        public bool isHandle { set; get; }
        #endregion
    }
}
