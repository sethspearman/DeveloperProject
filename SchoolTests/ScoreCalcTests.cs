using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Libraries;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace SchoolTests
{
    [TestFixture]
    public class ScoreCalcTests
    {
        [Test]
        public void ExcludeStudentCount_ExcludesZeroStudents()
        {
            //arrange
            var service = new SchoolService(new FakeSchoolRepository());
            var firstClass = service.School.Classes.FirstOrDefault(c => c.ClassName == "ClassA");

            //act
            var excludedstudentsCount = firstClass?.ExcludedStudents.Count ?? -1;

            //assert
            Assert.IsTrue(excludedstudentsCount==1);
        }
        [Test]
        public void Zeros_ignored_for_AverageCalculation()
        {
            //arrange
            var service = new SchoolService(new FakeSchoolRepository());
            var firstClass = service.School.Classes.FirstOrDefault(c => c.ClassName == "ClassA");

            //act
            var classAverage = firstClass?.ClassAverage ?? -1.0;

            //assert
            Assert.IsTrue(Math.Abs(classAverage - 79.4444) < 1);
        }

        [Test]
        public void school_to_string_overriddent()
        {
            //arrange
            var service = new SchoolService(new FakeSchoolRepository());

            //act
            var ts = service.School.ToString();
            Debug.Print(ts);

            //assert
            Assert.IsTrue(ts.Length>25);

        }
    }
}