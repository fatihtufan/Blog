using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Repositories;
using Blog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.EntityFreamework
{
    public class EfCategoryRepository:GenericRepository<Category>, ICategoryDal
    {

    }
}
