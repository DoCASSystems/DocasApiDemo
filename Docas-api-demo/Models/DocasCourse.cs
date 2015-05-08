using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace docas_api_demo.Models
{
    public class DocasCourse
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public DateTime? EnrollmentDeadline { get; set; }
        public DateTime? UsubscribeDeadline { get; set; }

        public string InstructorName { get; set; }
        public string InstructorEmail { get; set; }
        public string InstructorId { get; set; }

        public string LocationName { get; set; }
        public string LocationId { get; set; }

        public string LocationAddress { get; set; }
        public string LocationZipCode { get; set; }
        public string LocationCity { get; set; }
        public string LocationEmail { get; set; }

        public string LocationRoom { get; set; }
        public decimal? Price { get; set; }

        public bool Active { get; set; }

        public int? MaxParticipants { get; set; }

        public DocasMeetingDay[] MeetingDays { get; set; }
    }
}