using CASys.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASys.DAL
{
    /// <summary>
    /// 分类访问层
    /// </summary>
    public class CategoryDal
    {
        /// <summary>
        /// 添加类别
        /// </summary>
        /// <param name="categoryName">类别名称</param>
        /// <returns>返回是否添加成功</returns>
        public bool Add(Category category)
        {
            int i = SqlHelper.ExecuteNonQuery("insert into Category(CategoryId,CategoryWay) values(@categoryId,@categoryWay)",
                new SqlParameter("@categoryId", category.categoryId), new SqlParameter("@categoryWay", category.categoryWay));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("添加物品类别错误！");
            }
        }

        /// <summary>
        /// 添加物品上层分类
        /// </summary>
        /// <param name="name">分类名称</param>
        /// <returns>返回是否添加成功</returns>
        public bool Add(string name)
        {
            Guid categoryId = Guid.Parse("a41d0fcc-0fb9-4cec-a22f-f4e9f195b55b");
            int i = SqlHelper.ExecuteNonQuery("insert into Category(CategoryId,CategoryWay) values(@categoryId,@categoryWay)",
                new SqlParameter("@categoryId", categoryId), new SqlParameter("@categoryWay", name));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("添加物品上层类别错误！");
            }
        }

        /// <summary>
        /// 删除类别
        /// </summary>
        /// <param name="category">类别</param>
        /// <returns>返回是否删除成功</returns>
        public bool Delete(Category category)
        {
            int i = SqlHelper.ExecuteNonQuery("delete from Category where Id=@id",new SqlParameter("@id", category.id));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("删除类别错误！");
            }
        }

        /// <summary>
        /// 更新类别
        /// </summary>
        /// <param name="category">类别</param>
        /// <returns>返回是否更新成功</returns>
        public bool Update(Category category)
        {
            int i = SqlHelper.ExecuteNonQuery("update Category set CategoryId=@categoryId,CategoryWay=@categoryWay where Id=@id",
                new SqlParameter("@id", category.id), new SqlParameter("@name", category.categoryId), new SqlParameter("@categoryWay", category.categoryWay));
            if (i == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("更新类别错误！");
            }
        }

        /// <summary>
        /// 得到所有某基类别全部分类
        /// </summary>
        /// <param name="categoryId">类别上层编号</param>
        /// <returns>分类信息</returns>
        public List<Category> GetAll(Guid categoryId)
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from Category where CategoryId=@categoryId", new SqlParameter("@categoryId", categoryId));
            List<Category> categoryList=new List<Category>();
            foreach (DataRow row in table.Rows)
            {
                categoryList.Add(ToModel(row));
            }
            return categoryList;
        }

        /// <summary>
        /// 得到所有基类型
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAll()
        {
            Guid categoryId = Guid.Parse("a41d0fcc-0fb9-4cec-a22f-f4e9f195b55b");
            DataTable table = SqlHelper.ExecuteDataTable("select * from Category where CategoryId=@categoryId", new SqlParameter("@categoryId", categoryId));
            List<Category> categoryList = new List<Category>();
            foreach (DataRow row in table.Rows)
            {
                categoryList.Add(ToModel(row));
            }
            return categoryList;
        }

        /// <summary>
        /// 建立类别model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Category ToModel(DataRow row)
        {
            Category category = new Category();
            category.id = (Guid)row["Id"];
            category.categoryId = (Guid)row["CategoryId"];
            category.categoryWay = Convert.ToString(row["CategoryWay"]).Trim();
            return category;
        }
    }
}