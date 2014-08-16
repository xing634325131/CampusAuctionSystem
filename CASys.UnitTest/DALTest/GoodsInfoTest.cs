using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CASys.Model;
using CASys.DAL;
using System.IO;
using System.Collections.Generic;

namespace CASys.UnitTest.DALTest
{
    [TestClass]
    public class GoodsInfoTest
    {
        public static GoodsInfo goodsInfo = new GoodsInfo();
        static GoodsInfoDal goodsInfoDal = new GoodsInfoDal();
        static RoleDal roleDal = new RoleDal();
        static CategoryDal categoryDal = new CategoryDal();
        Role role = roleDal.GetRole(1004);
        public static List<Category> categoryIdList = categoryDal.GetAll();
        List<Category> categoryList = categoryDal.GetAll(categoryIdList[0].id);

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    goodsInfo.name = "手机";
        //    goodsInfo.ownerId = role.id;
        //    goodsInfo.picture = File.ReadAllBytes("1.jpg");
        //    goodsInfo.categoryId = categoryList[0].id;
        //    goodsInfo.description = "so hard!!!";
        //    bool result = goodsInfoDal.Add(goodsInfo); ;
        //    Assert.AreEqual(true, result);
        //}

        [TestMethod]
        public void TestMethod2()
        {
            List<GoodsInfo> goodsInfoList = goodsInfoDal.GetAll();
            goodsInfo = goodsInfoList[0];
            goodsInfo.description = "so hard!!!How can we go?";
            bool result = goodsInfoDal.Update(goodsInfo);
            Assert.AreEqual(true, result);
        }
    }
}
