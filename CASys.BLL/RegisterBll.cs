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
    /// 业务层实现注册
    /// </summary>
    public class RegisterBll
    {
        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>是否存在该用户名</returns>
        public bool CheckUser(string userName)
        {
            return new UserInfoDal().IsExist(userName);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="role">角色信息</param>
        /// <param name="user">用户信息</param>
        /// <returns>是否注册成功</returns>
        public bool Register(Role role,UserInfo user)
        {
            RoleDal roleDal=new RoleDal();
            if (roleDal.Add(ref role))
            {
                role = roleDal.GetRole(role.userNum);
                user.userId = role.id;
                return new UserInfoDal().Add(user);
            }
            else
            {
                throw new Exception("注册失败！");
            }
        }
    }
}
