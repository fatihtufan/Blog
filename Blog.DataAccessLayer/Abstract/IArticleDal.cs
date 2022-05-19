using Blog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Abstract
{
    public interface IArticleDal
    {
        List<Article> ListAllArticle();
        void AddArticle(Article article);
        void DeleteArticle(Article article);
        void UpdateArticle(Article article);
        Article GetById(int id);
    }
}
