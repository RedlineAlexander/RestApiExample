using Microsoft.AspNetCore.Mvc;
using RestApiExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


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
        public  IEnumerable<News> GetNews([FromRoute]string id)
        {
            return _repository.GetAllNews().Where(x => x.Id == int.Parse(id)); 
        }
        [HttpPost("News")]
        public void CreateNews(News news)
        {
            _repository.CreateNews(news);
        }
    }
}
