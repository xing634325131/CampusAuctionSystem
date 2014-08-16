using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CASys.DAL;
using CASys.Model;

namespace CASys.UnitTest.DALTest
{
    [TestClass]
    public class ProcessRecordTest
    {
        GoodsInfoDal goodInfoDal = new GoodsInfoDal();
        RoleDal roleDal = new RoleDal();
        ProcessRecordDal processRecordDal = new ProcessRecordDal();
        ProcessRecord processRecord = new ProcessRecord();
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    processRecord.goodsId = goodInfoDal.GetAll()[0].id;
        //    processRecord.tradeNameId = roleDal.GetAll()[3].id;
        //    processRecord.tradeTime = DateTime.Now;
        //    processRecord.tradePrice = 2.2M;
        //    bool result = processRecordDal.Add(processRecord);
        //    Assert.AreEqual(true, result);
        //}

        [TestMethod]
        public void TestMethod1()
        {
            int result = processRecordDal.GetAll().Count;
            Assert.AreEqual(1, result);
        }
    }
}
