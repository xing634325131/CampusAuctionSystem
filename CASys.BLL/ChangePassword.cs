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
    /// 业务层实现修改密码
    /// </summary>
    public class ChangePassword
    {
        /// <summary>
        /// 检查原密码是否正确
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool CheckPassword(Role role)
        {
            return new RoleDal().IsExist(role);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool ChangePwd(Role role)
        {
            return new RoleDal().Update(role);
        }
    }
}
