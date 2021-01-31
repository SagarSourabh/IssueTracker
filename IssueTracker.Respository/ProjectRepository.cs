using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IssueTracker.Entities;
using IssueTracker.Data;

namespace IssueTracker.Respository
{
    public class ProjectRepository : IRepository<Project>
    {
        IssueTrackerDBEntities dbContext = new IssueTrackerDBEntities();

        IEnumerable<Project> IRepository<Project>.List => AutoMapProperty.MapPropertyForList<Project, ProjectDetail>(dbContext.ProjectDetails.ToList());


        public void Add(Project entity)
        {
            //dbContext.ChangeTracker.Entries().Where(e => e.State == System.Data.Entity.EntityState.Modified)
          
            var projEntity = AutoMapProperty.MapProperty<ProjectDetail, Project>(entity);
            dbContext.ProjectDetails.Add(projEntity);
            dbContext.SaveChanges();
        }

        public void Delete(Project entity)
        {
            var dbEntity = AutoMapProperty.MapProperty<ProjectDetail, Project>(entity);
            dbContext.ProjectDetails.Remove(dbEntity);
            dbContext.SaveChanges();
        }

        public Project FindById(string Id)
        {
            return null;
        }

        public void Update(Project entity)
        {

        }
    }
}