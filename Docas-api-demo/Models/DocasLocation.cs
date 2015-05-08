using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace docas_api_demo.Models
{
    public class DocasLocation
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string WWW { get; set; }

        public string Description { get; set; }
    }
}