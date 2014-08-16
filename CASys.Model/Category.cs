using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.Model
{
    /// <summary>
    /// 分类信息model类
    /// </summary>
    public class Category
    {
        #region 属性
        /// <summary>
        /// 分类编号
        /// </summary>
        public Guid id { set; get; }

        /// <summary>
        /// 分类上层编号
        /// </summary>
        public Guid categoryId { set; get; }

        /// <summary>
        /// 分类方式
        /// </summary>
        public string categoryWay { set; get; }
        #endregion
    }
}
