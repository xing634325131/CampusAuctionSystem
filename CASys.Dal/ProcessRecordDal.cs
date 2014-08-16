using CASys.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.DAL
{
    /// <summary>
    /// 物品交易过程记录model
    /// </summary>
    public class ProcessRecordDal
    {
        /// <summary>
        /// 添加交易过程
        /// </summary>
        /// <param name="processRecord">交易过程记录</param>
        /// <returns>返回是否添加成功</returns>
        public bool Add(ProcessRecord processRecord)
        {
            int i = SqlHelper.ExecuteNonQuery("insert into ProcessRecord(GoodsId,TradeTime,TradeNameId,TradePrice) values(@goodsId,@tradeTime,@tradeNameId,@tradePrice)",
                new SqlParameter("@goodsId", processRecord.goodsId), new SqlParameter("@tradeTime", processRecord.tradeTime),
                new SqlParameter("@tradeNameId", processRecord.tradeNameId), new SqlParameter("@tradePrice", processRecord.tradePrice));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("更新物品交易记录失败！");
            }
        }

        /// <summary>
        /// 由物品ID得到交易过程记录
        /// </summary>
        /// <param name="goodsId">物品ID</param>
        /// <returns>交易过程列表</returns>
        public List<ProcessRecord> GetAllByGoodsId(Guid goodsId)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from ProcessRecord where GoodsId=@goodsId", new SqlParameter("@goodsId", goodsId));
            return ToList(table);
        }

        /// <summary>
        /// 由交易者ID得到交易过程记录
        /// </summary>
        /// <param name="tradeNameId">交易者ID</param>
        /// <returns>交易过程列表</returns>
        public List<ProcessRecord> GetAllByTradeNameId(Guid tradeNameId)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from ProcessRecord where TradeNameId=@tradeNameId", new SqlParameter("@tradeNameId", tradeNameId));
            return ToList(table);
        }

        /// <summary>
        /// 获得所有交易过程记录
        /// </summary>
        /// <returns>交易过程列表</returns>
        public List<ProcessRecord> GetAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from ProcessRecord");
            return ToList(table);
        }

        /// <summary>
        /// 由table得到列表
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        private List<ProcessRecord> ToList(DataTable table)
        {
            List<ProcessRecord> processRecordList = new List<ProcessRecord>();
            foreach (DataRow row in table.Rows)
            {
                processRecordList.Add(ToModel(row));
            }
            return processRecordList;
        }

        /// <summary>
        /// 建立交易过程model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private ProcessRecord ToModel(DataRow row)
        {
            ProcessRecord processRecord = new ProcessRecord();
            processRecord.goodsId = (Guid)row["GoodsId"];
            processRecord.id = (Guid)row["Id"];
            processRecord.tradeNameId = (Guid)row["TradeNameId"];
            processRecord.tradePrice = (decimal)row["TradePrice"];
            processRecord.tradeTime = (DateTime)row["TradeTime"];
            return processRecord;
        }
    }
}
