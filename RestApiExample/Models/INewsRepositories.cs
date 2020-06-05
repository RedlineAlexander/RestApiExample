using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*

 */
namespace RestApiExample.Models
{
 public   interface INewsRepositories
    {
        public IEnumerable<News> GetAllNews();
        void CreateNews(News news);
        public void DeleteNews();
        public void ChangeNews();
        public void ChangeParameterNews();
       
    }
}
