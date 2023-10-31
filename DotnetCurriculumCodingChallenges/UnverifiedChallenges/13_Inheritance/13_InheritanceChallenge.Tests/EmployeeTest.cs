using System;
using System.IO;
using Xunit;
namespace _13_InheritanceChallenge.Tests
{
    [Collection("Challenge13Tests")]
    public class EmployeeTest
    {
        public static readonly Employee testEmp = new Employee();
        public static StringWriter output = new StringWriter();
        [Fact]
        public void EmployeeShouldHaveDefaultValues()
        {
            Assert.Equal("Mark", testEmp.FirstName, true);
            Assert.Equal("Moore", testEmp.LastName, true);
            Assert.Equal(25000, testEmp.Salary);
        }
        [Fact]
        public void EmployeeShouldSetValues()
        {
            Employee testEmp = new Employee("Nolasco", "Marielle", 75000);
            Assert.Equal("Marielle", testEmp.FirstName);
            Assert.Equal("Nolasco", testEmp.LastName);
            Assert.Equal(75000, testEmp.Salary);
        }
        [Fact]
        public void WorkShouldSayWorking()
        {
            Console.SetOut(output);
            testEmp.Work();
            Assert.Contains("working", output.ToString());

            //clear console output
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
        }
        [Fact]
        public void BreakShouldBreak()
        {
            Console.SetOut(output);
            testEmp.Break();
            Assert.Contains("break", output.ToString());
            
            //clear console output
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
        }
    }
}
