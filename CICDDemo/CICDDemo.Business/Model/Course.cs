using System.Collections.Generic;

namespace CICDDemo.Business
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public string Instructor { get; set; }
        public int Credits { get; set; }
    }
}