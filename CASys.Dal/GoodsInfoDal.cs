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
    /// 物品信息访问层
    /// </summary>
    public class GoodsInfoDal
    {
        /// <summary>
        /// 添加物品信息
        /// </summary>
        /// <param name="goodsInfo">物品</param>
        /// <returns>返回是否添加成功</returns>
        public bool Add(GoodsInfo goodsInfo)
        {
            int i = SqlHelper.ExecuteNonQuery("insert into GoodsInfo(OwnerId,Name,Picture,Description,CategoryId) values(@ownerId,@name,@picture,@description,@categoryId)",
                new SqlParameter("@ownerId", goodsInfo.ownerId), new SqlParameter("@name", goodsInfo.name),
                new SqlParameter("@picture", goodsInfo.picture), new SqlParameter("@description", goodsInfo.description),
                new SqlParameter("@categoryId", goodsInfo.categoryId));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("添加物品信息失败！");
            }
        }

        /// <summary>
        /// 更新物品信息
        /// </summary>
        /// <param name="goodsInfo"></param>
        /// <returns></returns>
        public bool Update(GoodsInfo goodsInfo)
        {
            int i = SqlHelper.ExecuteNonQuery("update GoodsInfo set Name=@name,Picture=@picture,Description=@description,CategoryId=@categoryId where Id=@id",
                new SqlParameter("@Id", goodsInfo.id), new SqlParameter("@name", goodsInfo.name),
                new SqlParameter("@picture", goodsInfo.picture), new SqlParameter("@description", goodsInfo.description),
                new SqlParameter("@categoryId", goodsInfo.categoryId));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("更新物品信息失败！");
            }
        }

        /// <summary>
        /// 获取物品信息
        /// </summary>
        /// <param name="id">物品ID</param>
        /// <returns>物品信息</returns>
        public GoodsInfo GetGoodsInfo(Guid id)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsInfo where Id=@id", new SqlParameter("@id", id));
            if (Services.ForTableCount(table.Rows.Count))
            {
                throw new Exception("获取物品信息失败！");
            }
            return ToModel(table.Rows[0]);
        }

        /// <summary>
        /// 获取所有物品信息
        /// </summary>
        /// <returns>所有物品信息</returns>
        public List<GoodsInfo> GetAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from GoodsInfo");
            if (Services.ForTableCount(table.Rows.Count))
            {
                throw new Exception("获取物品信息失败！");
            }
            List<GoodsInfo> goodInfoList = new List<GoodsInfo>();
            foreach (DataRow row in table.Rows)
            {
                goodInfoList.Add(ToModel(row));
            }
            return goodInfoList;
        }

        /// <summary>
        /// 建立物品信息model
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private GoodsInfo ToModel(DataRow dataRow)
        {
            GoodsInfo goodsInfo = new GoodsInfo();
            goodsInfo.categoryId = (Guid)dataRow["CategoryId"];
            goodsInfo.description = Convert.ToString(dataRow["Description"]).Trim();
            goodsInfo.id = (Guid)dataRow["Id"];
            goodsInfo.name = Convert.ToString(dataRow["Name"]).Trim();
            goodsInfo.ownerId = (Guid)dataRow["OwnerId"];
            goodsInfo.picture = (byte[])dataRow["Picture"];
            return goodsInfo;
        }
    }
}
