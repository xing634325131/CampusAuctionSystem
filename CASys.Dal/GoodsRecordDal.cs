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
    /// 物品交易记录访问层
    /// </summary>
    public class GoodsRecordDal
    {
        /// <summary>
        /// 添加物品交易记录
        /// </summary>
        /// <param name="goodsRecord">物品记录</param>
        /// <returns>返回是否添加成功</returns>
        public bool Add(GoodsRecord goodsRecord)
        {
            int i = SqlHelper.ExecuteNonQuery(@"insert into 
                GoodsRecord(GoodsId,StartTime,AuctionTime,IsTrade,StartPrice,RangePrice,Endprice,IsOnline,Remark,GetNameId,IsHandle)
                values(@goodsId,@startTime,@auctionTime,@isTrade,@startPrice,@rangePrice,@endprice,@isOnline,@remark,@getNameId,@isHandle)",
                new SqlParameter("@goodsId", goodsRecord.goodsId), new SqlParameter("@startTime", goodsRecord.startTime),
                new SqlParameter("@auctionTime", goodsRecord.auctionTime), new SqlParameter("@isTrade", (goodsRecord.isTrade == true ? 1 : 0)),
                new SqlParameter("@startPrice", goodsRecord.startPrice), new SqlParameter("@rangePrice", goodsRecord.rangePrice),
                new SqlParameter("@endprice", Services.ToDBValue(goodsRecord.endprice)), new SqlParameter("@isOnline", (goodsRecord.isOnline == true ? 1 : 0)),
                new SqlParameter("@remark", Services.ToDBValue(goodsRecord.remark)), new SqlParameter("@getNameId", Services.ToDBValue(goodsRecord.getNameId)),
                new SqlParameter("@isHandle", (goodsRecord.isHandle == true ? 1 : 0)));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("添加物品交易记录失败！");
            }
        }

        /// <summary>
        /// 更新物品交易记录
        /// </summary>
        /// <param name="goodsRecord">交易记录</param>
        /// <returns>返回是否更新成功</returns>
        public bool Update(GoodsRecord goodsRecord)
        {
            int i = SqlHelper.ExecuteNonQuery(@"update GoodsRecord set StartTime=@startTime,AuctionTime=@auctionTime,IsTrade=@isTrade,
                StartPrice=@startPrice,RangePrice=@rangePrice,Endprice=@endprice,IsOnline=@isOnline,Remark=@remark,GetNameId=@getNameId,IsHandle=@isHandle
                where Id=@id",new SqlParameter("@Id", goodsRecord.id), new SqlParameter("@startTime", goodsRecord.startTime),
                new SqlParameter("@auctionTime", goodsRecord.auctionTime), new SqlParameter("@isTrade", (goodsRecord.isTrade == true ? 1 : 0)),
                new SqlParameter("@startPrice", goodsRecord.startPrice), new SqlParameter("@rangePrice", goodsRecord.rangePrice),
                new SqlParameter("@endprice", Services.ToDBValue(goodsRecord.endprice)), new SqlParameter("@isOnline", (goodsRecord.isOnline == true ? 1 : 0)),
                new SqlParameter("@remark", Services.ToDBValue(goodsRecord.remark)), new SqlParameter("@getNameId", Services.ToDBValue(goodsRecord.getNameId)),
                new SqlParameter("@isHandle", (goodsRecord.isHandle == true ? 1 : 0)));
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
        /// 获取单件物品交易记录
        /// </summary>
        /// <param name="id">物品交易ID</param>
        /// <returns>交易记录</returns>
        public GoodsRecord GetGoodsRecord(Guid id)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsRecord where Id=@id", new SqlParameter("@id", id));
            if (Services.ForTableCount(table.Rows.Count))
            {
                throw new Exception("获取物品交易记录失败");
            }
            return ToModel(table.Rows[0]);
        }

        /// <summary>
        /// 获取所有物品交易记录
        /// </summary>
        /// <returns>所有物品交易记录</returns>
        public List<GoodsRecord> GetAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsRecord");
            return ToList(table);
        }

        /// <summary>
        /// 获取所有交易成功物品
        /// </summary>
        /// <returns>物品记录列表</returns>
        public List<GoodsRecord> GetTrade()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsRecord where IsTrade=@isTrade", new SqlParameter("@isTrade", 1));
            return ToList(table);
        }

        /// <summary>
        /// 获取所有交易未成功物品
        /// </summary>
        /// <returns>物品记录列表</returns>
        public List<GoodsRecord> GetNotTrade()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsRecord where IsTrade=@isTrade", new SqlParameter("@isTrade", 0));
            return ToList(table);
        }

        /// <summary>
        /// 获取所有通过审核物品
        /// </summary>
        /// <returns>物品记录列表</returns>
        public List<GoodsRecord> GetOnline()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsRecord where IsOnline=@isOnline", new SqlParameter("@isOnline", 1));
            return ToList(table);
        }

        /// <summary>
        /// 获取所有未通过审核物品
        /// </summary>
        /// <returns>物品记录列表</returns>
        public List<GoodsRecord> GetNotOnline()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsRecord where IsOnline=@isOnline", new SqlParameter("@isOnline", 0));
            return ToList(table);
        }

        /// <summary>
        /// 获取所有已处理申请物品
        /// </summary>
        /// <returns>物品记录列表</returns>
        public List<GoodsRecord> GetHandle()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsRecord where IsHandle=@isHandle", new SqlParameter("@isHandle", 1));
            return ToList(table);
        }

        /// <summary>
        /// 获取所有未处理申请物品
        /// </summary>
        /// <returns>物品记录列表</returns>
        public List<GoodsRecord> GetNotHandle()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsRecord where IsHandle=@isHandle", new SqlParameter("@isHandle", 0));
            return ToList(table);
        }

        /// <summary>
        /// 获取某一用户所有交易获得的物品
        /// </summary>
        /// <param name="getNameId">用户ID</param>
        /// <returns>物品记录列表</returns>
        public List<GoodsRecord> GetByGetNameId(Guid getNameId)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsRecord where GetNameId=@getNameId", new SqlParameter("@getNameId", getNameId));
            return ToList(table);
        }

        /// <summary>
        /// 建立物品交易距离model
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private GoodsRecord ToModel(DataRow dataRow)
        {
            GoodsRecord goodRecord=new GoodsRecord();
            goodRecord.auctionTime=(int)dataRow["AuctionTime"];
            goodRecord.id=(Guid)dataRow["Id"];
            goodRecord.goodsId=(Guid)dataRow["GoodsId"];
            goodRecord.startTime=(DateTime)dataRow["StartTime"];
            goodRecord.isTrade=(bool)dataRow["IsTrade"];
            goodRecord.startPrice = (decimal)dataRow["StartPrice"];
            goodRecord.rangePrice = (decimal)dataRow["RangePrice"];
            goodRecord.endprice = (decimal?)Services.FromDBValue(dataRow["Endprice"]);
            goodRecord.isOnline=(bool)dataRow["IsOnline"];
            goodRecord.remark=Convert.ToString(Services.FromDBValue(dataRow["Remark"]));
            goodRecord.getNameId = (Guid?)Services.FromDBValue(dataRow["GetNameId"]);
            goodRecord.isHandle = (bool)dataRow["IsHandle"];
            return goodRecord;
        }

        /// <summary>
        /// 由table得到列表
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        private List<GoodsRecord> ToList(DataTable table)
        {
            if (Services.ForTableCount(table.Rows.Count))
            {
                throw new Exception("获取物品交易记录失败");
            }
            List<GoodsRecord> goodsRecordList = new List<GoodsRecord>();
            foreach (DataRow row in table.Rows)
            {
                goodsRecordList.Add(ToModel(row));
            }
            return goodsRecordList;
        }
    }
}
