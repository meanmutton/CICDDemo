using CICDDemo.Business.Providers;
using FluentAssertions;
using Xunit;

namespace CICDDemoTests.Business.UnitTests
{
    public class CourseUnitTest 
    {
        [Fact]
        public void GetAll_Should_Return5Rows()
        {
            var courses = new CourseProvider().GetAll();
            courses.Should()
                .NotBeNull()
                .And
                .NotBeEmpty()
                .And
                .HaveCount(5);
        }
    }
}
