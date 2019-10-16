using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CICDDemo.Business;
using CICDDemo.Business.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CICDDemo.Pages
{
    public class IndexModel : PageModel
    {

        public Result Data { get; private set; }
        public void OnGet() => Data = GetCourses();

        public class Result
        {
            public List<Course> Courses { get; set; }
        }

        private Result GetCourses()
        {
            var CourseProvider = new CourseProvider();
            var courses = CourseProvider.GetAll();
            return new Result()
            {
                Courses = courses
            };
        } 
    }
}
