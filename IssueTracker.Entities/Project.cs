using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssueTracker.Entities
{
    public class Project : IEntity
    {
        public Guid ProjectId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string ProjectDesc { get; set; }

        [Required]
        public int ProjectStatus { get; set; }
    }
}