using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace docas_api_demo.Models
{
    public class DocasMeetingDay
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        
        public string InstructorName { get; set; }
        public string InstructorId { get; set; }

        public string LocationName { get; set; }
        public string LocationId { get; set; }

    }
}