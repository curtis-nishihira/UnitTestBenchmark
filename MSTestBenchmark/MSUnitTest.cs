using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestLibrary;

namespace MSTestBenchmark
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test test = new Test();
            var actualOutput = test.GenerateList();
            var expectedOutput = true;


            //comparision
            Assert.IsTrue(actualOutput == expectedOutput);
        }

        [TestMethod]
        public void TestMethod10()
        {
            List<bool> results = new List<bool>();
            for(int i = 0; i<10; i++)
            {
                Test test = new Test();
                var actualOutput = test.GenerateList();
                var expectedOutput = true;

                if(actualOutput == expectedOutput)
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

        [TestMethod]
        public void TestMethod100()
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

        [TestMethod]
        public void TestMethod1000()
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
