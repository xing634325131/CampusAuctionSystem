using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CASys.Dal;
using CASys.Model;
using System.Collections.Generic;

namespace CASys.UnitTest.DALTest
{
    [TestClass]
    public class GadeTest
    {
        GradeDal gradeDal = new GradeDal();
        Grade grade = new Grade();
        [TestMethod]
        public void TestMethod1()
        {
            List<Grade> gradeList = gradeDal.GetAll();
            int result = gradeList.Count;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<Grade> gradeList = gradeDal.GetAll();
            List<Grade> gradeUpperList = gradeDal.GetAll(gradeList[0].id);
            int result = gradeUpperList.Count;
            Assert.AreEqual(4, result);
        }
    }
}
