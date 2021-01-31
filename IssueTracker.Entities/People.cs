using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssueTracker.Entities
{
    public class People : IEntity
    {
        public Guid PersonId { get; set; }

        [Required]
        public string PersonName { get; set; }

        [Required]
        public string PersonEmail { get; set; }

        [Required]
        public int PersonRole { get; set; }

        [Required]
        public string PersonUserName { get; set; }

        public Guid AssignedProject { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public int PersonStatus { get; set; }


    }
}