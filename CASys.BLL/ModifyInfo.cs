using CASys.Dal;
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
    /// 业务层修改信息
    /// </summary>
    public class ModifyInfo
    {
        private GradeDal gradeDal = new GradeDal();
        /// <summary>
        /// 修改用户资料
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool ModifyUserInfo(UserInfo user)
        {
            return new UserInfoDal().Update(user);
        }

        /// <summary>
        /// 得到所有学院
        /// </summary>
        /// <returns></returns>
        public List<Grade> GetAllInstitute()
        {
            return gradeDal.GetAll();
        }

        /// <summary>
        /// 得到所有专业和班级
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Grade> GetAllOther()
        {
            List<Grade> instituteList = GetAllInstitute();
            List<Grade> gradeList = new List<Grade>();
            foreach (Grade major in instituteList)//得到所有专业
            {
                List<Grade> majorList = gradeDal.GetAll(major.upperId);
                foreach (Grade grade in majorList)//得到所有该专业的年级
                {
                    gradeList.Add(grade);
                }
            }
            return gradeList;
        }
    }
}
