using System;
using GameOfLife.Models;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class ExampleUnitTest
    {
        [Test]
        public void True_Is_Truthy()
        {
            //A common unit testing pattern is AAA - Arrange, Act, Assert

            //Arrange - Let's pick out all of the lego pieces we need for our test
            var example = new ExampleModel();

            //Act - Let's perform the action that we need to test
            var result = example.ReturnTruth();

            //Assert - Let's write what we expect of our result
            Assert.IsTrue(true);

            /* We should write the above test, before creating our ExampleModel and
             * build out our features one at a time, the reason for this becomes apparent
             * with time, you write a failing test first, because seeing the test fail is
             * the only way to know for sure if your production code is what caused it to pass
             */
        }
    }
}
