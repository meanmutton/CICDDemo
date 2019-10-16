using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CICDDemo.Business.Providers
{

    public interface ICourseProvider
    {
        List<Course> GetAll();
    }

    public class CourseProvider
    {

        public List<Course> GetAll()
        {
            return new List<Course>()
            {
                new Course() {Credits = 1, Id = 1, Name = "Course - 1", Instructor = "A"},
                new Course() {Credits = 1, Id = 2, Name = "Course - 2", Instructor = "A"},
                new Course() {Credits = 1, Id = 3, Name = "Course - 3", Instructor = "A"},
                new Course() {Credits = 1, Id = 4, Name = "Course - 4", Instructor = "A"},
                new Course() {Credits = 1, Id = 5, Name = "Course - 5", Instructor = "A"}
            };
        }
    }
}
