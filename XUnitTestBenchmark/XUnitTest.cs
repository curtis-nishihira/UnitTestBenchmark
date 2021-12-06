using System;
using System.Collections.Generic;
using TestLibrary;
using Xunit;

namespace XUnitTestBenchmark
{
    public class XUnitTest
    {
        [Fact]
        public void Test1()
        {
            Test test = new Test();
            var actualOutput = test.GenerateList();
            var expectedOutput = true;

            //comparision
            Assert.True(actualOutput == expectedOutput);
        }
        [Fact]
        public void Test10()
        {
            List<bool> results = new List<bool>();
            for (int i = 0; i < 10; i++)
            {
                Test test = new Test();
                var actualOutput = test.GenerateList();
                var expectedOutput = true;

                if (actualOutput == expectedOutput)
                {
                    results.Add(true);
                }
                else
                {
                    results.Add(false);
                }
            }


            //comparision
            Assert.True(!results.Contains(false));
        }

        [Fact]
        public void Test100()
        {
            List<bool> results = new List<bool>();
            for (int i = 0; i < 100; i++)
            {
                Test test = new Test();
                var actualOutput = test.GenerateList();
                var expectedOutput = true;

                if (actualOutput == expectedOutput)
                {
                    results.Add(true);
                }
                else
                {
                    results.Add(false);
                }
            }


            //comparision
            Assert.True(!results.Contains(false));
        }

        [Fact]
        public void Test1000()
        {
            List<bool> results = new List<bool>();
            for (int i = 0; i < 1000; i++)
            {
                Test test = new Test();
                var actualOutput = test.GenerateList();
                var expectedOutput = true;

                if (actualOutput == expectedOutput)
                {
                    results.Add(true);
                }
                else
                {
                    results.Add(false);
                }
            }


            //comparision
            Assert.True(!results.Contains(false));
        }
    }
}
