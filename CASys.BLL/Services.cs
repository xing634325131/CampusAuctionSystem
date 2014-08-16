using CASys.DAL;
using CASys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.BLL
{
    public class Services
    {
        /// <summary>
        /// 通过用户名得到用户编号
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public int GetUserNum(string userName)
        {
            Role role = new RoleDal().GetRole(new UserInfoDal().GerUser(userName).userId);
            return role.userNum;
        }
    }
}
