using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using Blog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Repositories
{
    internal class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Catogries.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return c.Catogries.ToList();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
