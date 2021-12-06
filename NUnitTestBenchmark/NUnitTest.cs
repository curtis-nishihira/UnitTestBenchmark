using NUnit.Framework;
using System.Collections.Generic;
using TestLibrary;

namespace NUnitTestBenchmark
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Test test = new Test();
            var actualOutput = test.GenerateList();
            var expectedOutput = true;


            //comparision
            Assert.IsTrue(actualOutput == expectedOutput);
        }

        [Test]
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
            Assert.IsTrue(!results.Contains(false));
        }

        [Test]
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
            Assert.IsTrue(!results.Contains(false));
        }

        [Test]
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
            Assert.IsTrue(!results.Contains(false));
        }
    }
}