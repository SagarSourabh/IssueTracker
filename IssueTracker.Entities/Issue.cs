using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssueTracker.Entities
{
    public class Issue : IEntity
    {
        public Guid IssueId { get; set; }

        [Required]
        public string IssueTitle { get; set; }

        [Required]
        public string IssueDesc { get; set; }

        [Required]
        public int IssuePriority { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public string IssueRaisedBy { get; set; }

        public DateTime IssueRaisedOn { get; set; }

        public DateTime TargetResolutionDate { get; set; }

        public DateTime ActualResolutionDate { get; set; }

        public string ResolutionSummary { get; set; }


    }
}