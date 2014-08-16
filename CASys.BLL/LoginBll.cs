using CASys.DAL;
using CASys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.BLL
{
    /// <summary>
    /// 业务层实现登录
    /// </summary>
    public class LoginBll
    {
        /// <summary>
        /// 验证登录信息
        /// </summary>
        /// <param name="role">用户信息</param>
        /// <returns>是否登录成功</returns>
        public bool Login(Role role,UserInfo user)
        {
            UserInfoDal userInfoDal=new UserInfoDal();
            List<UserInfo> userList = userInfoDal.GetAll();
            if (userInfoDal.IsExist(user.nickName))//登录前检测是否存在该用户名
            {
                return false;
            }
            foreach (UserInfo userInfo in userList)
            {
                if (userInfo.nickName == user.nickName)
                {
                    user = userInfo;
                    break;
                }
            }
            role.id = user.userId;
            role.isAdmin = false;
            return new RoleDal().IsExist(role);
        }
    }
}
