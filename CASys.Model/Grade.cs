using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.Model
{
    /// <summary>
    /// 院系专业年级对应model类
    /// </summary>
    public class Grade
    {
        /// <summary>
        /// 年级编号
        /// </summary>
        public Guid id { set; get; }

        /// <summary>
        /// 上层编号
        /// </summary>
        public Guid upperId { set; get; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { set; get; }
    }
}
