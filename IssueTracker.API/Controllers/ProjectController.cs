using IssueTracker.Entities;
using IssueTracker.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IssueTracker.API.Controllers
{
    public class ProjectController : ApiController
    {

        IRepository<Project> _repo = new ProjectRepository();


        // GET api/<controller>
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

        // POST api/<controller>
        [HttpPost]
        public void AddProject([FromBody]Project project)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(project);
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}