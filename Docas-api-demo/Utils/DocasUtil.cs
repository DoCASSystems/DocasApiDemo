using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using docas_api_demo.Models;
using docas_api_demo.Properties;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;

namespace docas_api_demo.Utils
{
    public static class DocasUtil
    {

        private static readonly JsonSerializerSettings DocasJsonSerializeSettings = new JsonSerializerSettings
        {
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
            DateFormatString = "dd-MM-yyyy HH:mm"
        };
        private enum DoCASMethod
        {
            vendor,
            courses,
            course,
            coursemodels,
            coursemodel,
            instructor,
            instructors,
            location,
            locations

        }

        public static DocasVendor GetVendor()
        {
            var json = GetDocasData(DoCASMethod.vendor, "");
            DocasVendor vendor = JsonConvert.DeserializeObject<DocasVendor>(json, DocasJsonSerializeSettings);
            return vendor;
        }

        public static DocasCourseModel GetCourseModel(string id)
        {
            var json = GetDocasData(DoCASMethod.coursemodel, id);
            DocasCourseModel courseModel = JsonConvert.DeserializeObject<DocasCourseModel>(json, DocasJsonSerializeSettings);
            return courseModel;
        }

        public static DocasCourse GetCourse(string id)
        {
            var json = GetDocasData(DoCASMethod.course, id);
            var course = JsonConvert.DeserializeObject<DocasCourse>(json, DocasJsonSerializeSettings);
            return course;
        }

        public static DocasInstructor GetInstructor(string id)
        {
            var json = GetDocasData(DoCASMethod.instructor, id);
            var instructor = JsonConvert.DeserializeObject<DocasInstructor>(json, DocasJsonSerializeSettings);
            return instructor;
        }

        public static DocasInstructor[] GetInstructors()
        {
            var json = GetDocasData(DoCASMethod.instructors,"" );
            var instructors = JsonConvert.DeserializeObject<DocasInstructor[]>(json, DocasJsonSerializeSettings);
            return instructors;
        }
        public static DocasLocation GetLocation(string id)
        {
            var json = GetDocasData(DoCASMethod.location, id);
            var location = JsonConvert.DeserializeObject<DocasLocation>(json, DocasJsonSerializeSettings);
            return location;
        }

        public static List<DocasCourseModel> GetCourseModels()
        {
            var json = GetDocasData(DoCASMethod.coursemodels, "");
            var courseModels = JsonConvert.DeserializeObject<DocasCourseModels>(json, DocasJsonSerializeSettings);
            return courseModels.CourseModels.ToList();
        }
        private static string GetDocasData(DoCASMethod method, string id)
        {
            using (var w = new WebClient() { Encoding = System.Text.Encoding.UTF8 })
            {
                var json = string.Empty;
                var url = Settings.Default.DocasApi + "/" + method + "/" + Settings.Default.ApiKey + "/" + Settings.Default.VendorId + "/" + id + "?format=jsonp";
                // attempt to download JSON data as a string
                try
                {
                    return w.DownloadString(url);
                }
                catch (Exception)
                {
                    return string.Empty;
                }
               
            }
        }

    }
}