using Microsoft.AspNetCore.Mvc;
using RestApiExample.Models;
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
 */
namespace RestApiExample.Controllers
{
    [ApiController]
    public class NewsController : ControllerBase
    {

        private INewsRepositories _repository { get; set; }
        public NewsController(INewsRepositories _repository)
        {
            this._repository = _repository;
        }
        //ВОТ И ARGUMENTNULLEXCEPTION при попытке распарсить string в int
        [HttpGet("News")]
        public IEnumerable<News> GetNews([FromRoute]string id)
        {
            return _repository.GetAllNews().Where(x => x.Id == int.Parse(id));
        }
        [HttpPost("News")]
        public void CreateNews(News news)
        {
            _repository.CreateNews(news);
        }
        [HttpDelete]
        public void DeleteNews()
        {

        }
        [HttpPut]
        public void ChangeNews()
        {

        }
        
        [HttpPatch]
        public void ChangeParameterNews()
        {

        }

    }
}
