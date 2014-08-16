using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CASys.Model;
using CASys.DAL;

namespace CASys.UnitTest.DALTest
{
    [TestClass]
    public class GoodsRecordTest
    {
        static GoodsInfoDal goodsInfoDal = new GoodsInfoDal();
        List<GoodsInfo> goodsList = goodsInfoDal.GetAll();
        List<Role> roleList = new RoleDal().GetAll();
        GoodsRecordDal goodsRecordDal = new GoodsRecordDal();
        GoodsRecord goodsRecord = new GoodsRecord();

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    goodsRecord.goodsId = goodsList[0].id;
        //    goodsRecord.auctionTime = 3;
        //    goodsRecord.getNameId = roleList[3].id;
        //    goodsRecord.isHandle = false;
        //    goodsRecord.isOnline = false;
        //    goodsRecord.isTrade = false;
        //    goodsRecord.rangePrice = 5.0M;
        //    goodsRecord.startPrice = 24M;
        //    goodsRecord.startTime = DateTime.Now;
        //    bool result = goodsRecordDal.Add(goodsRecord);
        //    Assert.AreEqual(true, result);
        //}

        [TestMethod]
        public void TestMethod2()
        {
            List<GoodsRecord> goodsRecordList = goodsRecordDal.GetAll();
            goodsRecord = goodsRecordList[0];
            goodsRecord.remark = "价格太高";
            bool result = goodsRecordDal.Update(goodsRecord);
            Assert.AreEqual(true, result);
        }
    }
}
