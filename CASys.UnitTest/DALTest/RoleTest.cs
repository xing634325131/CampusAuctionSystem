using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CASys.Model;
using CASys.DAL;
using System.Collections.Generic;

namespace CASys.UnitTest.DALTest
{
    [TestClass]
    public class RoleTest
    {
        static RoleDal roleDal = new RoleDal();
        //Role role = roleDal.GetRole(1004);
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Role role1 = new Role();
        //    role1.password = "GuGuTian";
        //    bool result = roleDal.Add(ref role1);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    bool result = roleDal.Delete(role.id);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    role.isLocked = true;
        //    role.lockTime = DateTime.Now;
        //    bool result = roleDal.Update(role);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod4()
        //{
        //    role.isAdmin = false;
        //    role.userNum = 1001;
        //    role.password = "123";
        //    bool result = roleDal.IsExist(role);
        //    Assert.AreEqual(true, result);
        //}

        [TestMethod]
        public void TestMethod5()
        {
            List<Role> roleList = roleDal.GetAll();
            Assert.AreEqual(8, roleList.Count);
        }
    }
}
