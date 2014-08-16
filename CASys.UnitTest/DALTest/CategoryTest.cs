using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CASys.DAL;
using CASys.Model;
using System.Collections.Generic;

namespace CASys.UnitTest.DALTest
{
    [TestClass]
    public class CategoryTest
    {
        static CategoryDal categoryDal = new CategoryDal();
        Category category = new Category();
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    category.name = "衣服";
        //    category.categoryWay = "物品名称";
        //    bool result = categoryDal.Add(category);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    List<Category> categoryList = categoryDal.GetAll();
        //    category = categoryList[2];
        //    category.name = "电脑";
        //    bool result = categoryDal.Update(category);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    List<Category> categoryList = categoryDal.GetAll();
        //    category = categoryList[2];
        //    bool result = categoryDal.Delete(category);
        //    Assert.AreEqual(true, result);
        //}

        [TestMethod]
        public void TestMethod4()
        {
            List<Category> categoryList = categoryDal.GetAll();
            int result = categoryList.Count;
            Assert.AreEqual(7, result);
        }
    }
}
