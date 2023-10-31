using System;
using System.IO;
using Xunit;

namespace _13_InheritanceChallenge.Tests
{
    [Collection("Challenge13Tests")]
    public class TraineeTest
    {
        public static readonly Trainee testTrainee = new Trainee(10, 40, "Nolasco", "Marielle", 25000);
        public static StringWriter output = new StringWriter();
        [Fact]
        public void TraineeShouldSetValues()
        {
            Assert.Equal("Marielle", testTrainee.FirstName);
            Assert.Equal("Nolasco", testTrainee.LastName);
            Assert.Equal(25000, testTrainee.Salary);
            Assert.Equal(10, testTrainee.WorkingHours);
            Assert.Equal(40, testTrainee.SchoolHours);
        } 

        [Fact]
        public void TraineeShouldWork()
        {
            Console.SetOut(output);
            testTrainee.Work();
            Assert.Contains($"{testTrainee.WorkingHours}", output.ToString());

            //clear console
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
        }
        [Fact]
        public void TraineeShouldStudy()
        {
            Console.SetOut(output);
            testTrainee.Study();
            Assert.Contains($"{testTrainee.SchoolHours}", output.ToString());

            //clear console
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
        }
    }
}