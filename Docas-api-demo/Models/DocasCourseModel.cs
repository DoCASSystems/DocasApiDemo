using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace docas_api_demo.Models
{
    public class DocasCourseModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DocasCourse[] Courses { get; set; }
    }
}