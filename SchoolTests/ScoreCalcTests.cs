using System.Linq;
using Libraries;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace SchoolTests
{
    [TestFixture]
    public class ScoreCalcTests
    {
        [Test]
        public void Zeros_ignored_for_Calculation()
        {
            //arrange
            var service = new SchoolService(new FakeSchoolRepository());
            var firstClass = service.School.Classes.Where(c => c.ClassName == "ClassA");

            //act


            //assert

        }
    }
}