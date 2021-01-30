using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IssueTracker.Respository;
using IssueTracker.Entities;

namespace IssueTracker.API.Controllers
{
    public class IssueController : ApiController
    {
        IRepository<Project> _repo = new ProjectRepository();

        public IEnumerable<Project> GetAll()
        {
            var projectList = _repo.List;
            return projectList.ToList();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}