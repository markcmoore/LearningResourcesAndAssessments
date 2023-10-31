using System;
using System.IO;
using Xunit;
namespace _13_InheritanceChallenge.Tests
{
    [Collection("Challenge13Tests")]
    public class BossTest
    {
        public readonly Boss testBoss = new Boss("Tesla", "Nolasco", "Marielle", 200000);
        [Fact]
        public void BossShouldHaveSetProperties()
        {
            Assert.Equal("Tesla", testBoss.CompanyCar);
            Assert.Equal("Marielle", testBoss.FirstName);
            Assert.Equal("Nolasco", testBoss.LastName);
            Assert.Equal(200000, testBoss.Salary);
        }
        [Fact]
        public void BossShouldLead()
        {
            StringWriter output = new StringWriter();
            Console.SetOut(output);

            testBoss.Lead();

            Assert.Contains($"{testBoss.FirstName}", output.ToString());
            Assert.Contains($"{testBoss.LastName}", output.ToString());

             //clear console output
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
             
        }
    }

}