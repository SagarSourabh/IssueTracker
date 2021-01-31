using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IssueTracker.Entities;

namespace IssueTracker.Respository
{
    public class UserRepository : IRepository<People>
    {
        public IEnumerable<People> List => throw new NotImplementedException();

        public void Add(People entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(People entity)
        {
            throw new NotImplementedException();
        }

        public People FindById(string Id)
        {
            throw new NotImplementedException();
        }

        public void Update(People entity)
        {
            throw new NotImplementedException();
        }
    }
}