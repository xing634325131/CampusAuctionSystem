using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CASys.DAL;
using System.Collections.Generic;
using CASys.Model;
using System.IO;

namespace CASys.UnitTest.DALTest
{
    [TestClass]
    public class UserInfoTest
    {
        UserInfoDal userInfoDal = new UserInfoDal();
        UserInfo userInfo = new UserInfo();
        static RoleDal roleDal = new RoleDal();
        static List<Role> roleList = new List<Role>();
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    roleList = roleDal.GetAll();
        //    userInfo.userId = roleList[0].id;
        //    userInfo.tel = "1213141516";
        //    userInfo.realName = "YQY";
        //    userInfo.QQ = "12121212";
        //    userInfo.nickName = "hehe";
        //    userInfo.gender = "female";
        //    userInfo.email = "123131@163.com";
        //    userInfo.address = "china";
        //    userInfo.photo = File.ReadAllBytes("2.jpg");
        //    bool result = userInfoDal.Add(userInfo);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    List<UserInfo> userList = userInfoDal.GetAll();
        //    userInfo = userList[0];
        //    userInfo.gender = "男";
        //    userInfo.tel = "18073441516";
        //    userInfo.realName = "xp";
        //    userInfo.nickName = "ggt";
        //    userInfo.QQ = "392130377";
        //    userInfo.nickName = "hehe";
        //    bool result = userInfoDal.Update(userInfo);
        //    Assert.AreEqual(true, result);
        //}

        [TestMethod]
        public void TestMethod3()
        {
            List<UserInfo> userList = userInfoDal.GetAll();
            int result = userList.Count;
            Assert.AreEqual(3, result);
        }
    }
}
