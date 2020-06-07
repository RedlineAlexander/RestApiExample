using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
 *  * Оговорка: для всех последующих методов должен быть одинаковый URL (за исключением добавления параметров). 
 * Отличаться должны только HTTP verbs. Используя атрибут [HttpDelete] 
 * создайте метод в NewsController, который будет удалять новость.
 * Передавайте id через Route. Создайте метод в репозитории, 
 * с помощью которого можно будет удалять новость из коллекции.
 * 
 * 
 * Используя атрибут [HttpPut] создайте метод в NewsController, 
 * который будет заменять новость другой. 
 * Вам необходимо будет передавать целый обьект News через Body.
 * Создайте соответствующий метод в репозитории.
 * 
 * Используя атрибут [HttpPatch] создайте метод в NewsController, 
 * который будет изменять переданные свойства в уже существующей новости.
 * Вам необходимо будет передавать id новости и целый обьект новости и обновлять те свойства
 * , которые были переданы. (т.е. в передаваемом JSON обьекте вы можете указывать не все свойства). Создайте соответствующий метод в репозитории.
 * 
 * 
 * if(){

}
else
{

}

switch(){

case:
break;

default: 
break;

}
a > b ? 3:4;
 */
namespace RestApiExample.Models
{
    public class SqlNewsRepositories :INewsRepositories
    {
        public  List<News> ListNews = new List<News>
        {
             new News { Id = 0, Title = "Humanity finally colonized the Mercury!!", Text = "", AuthorName = "Jeremy Clarkson", IsFake = true},
            new News { Id = 1, Title = "Increase your lifespan by 10 years, every morning you need...", Text = "", AuthorName = "Svetlana Sokolova", IsFake = true},
            new News { Id = 2, Title = "Scientists estimed the time of the vaccine invension: it is a summer of 2021", Text = "", AuthorName = "John Jones", IsFake = false},
            new News { Id = 3, Title = "Ukraine reduces the cost of its obligations!", Text = "", AuthorName = "Cerol Denvers", IsFake = false},
            new News { Id = 4, Title = "A species were discovered in Africa: it is blue legless cat", Text = "", AuthorName = "Jimmy Felon", IsFake = true}

        };

        public IEnumerable<News> GetAllNews()
        {
            return ListNews;
        }
        public void CreateNews(News news)
        {
            ListNews.Add(news);
          //  ListNews.
        }
        
        public void DeleteNews(News news)
        {

            ListNews.Remove(news);
           // ListNews.Remove(id);
        //   ListNews.RemoveAll();
        //
            ListNews.Remove(news);
            //   ListNews.RemoveAll();
         //   ListNews.RemoveAll(news);
        }
        
        public void ChangeNews()
        {
            ListNews.Remove();
            ListNews.Add();
        }

        
        public void ChangeParameterNews()
        {

        }
        public void GetNews(bool isFake)
        {
          if(isFake == true)
            {

            }
            else
            {

            }
        }

        public void DeleteNews()
        {
            throw new NotImplementedException();
        }
    }
}
