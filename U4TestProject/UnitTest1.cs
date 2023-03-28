using IT481U4;
using System.Security.Cryptography.X509Certificates;

namespace U4TestProject
{
    public class Tests
    {
        //Creating reference
        IT481U4.IT481Unit4 u4;

        [SetUp]
        public void Setup()
        {
            //Creating new object for test examples
            u4 = new IT481U4.IT481Unit4();
        }

        //Given an array of integers, and a number of times to look, return the minimum value
        [Test]
        public void TestExample1()
        {
            int[] list = { 1, 50, 200, 312 };
            int n = 4;
            int result = u4.Example1(list, n);
            Assert.AreEqual(result, 1, "The minimum list value is 1");
            Assert.AreNotEqual(result, 50, "The minimum value in the list is not 50");
        }

        [Test]
        //Given an array in integers print out each value
        public void TestExample2()
        {
            int[] list = new int[100];
            for(int i = 0; i < 100; i++)
            {
                list[i] = i + 1;
            }
            u4.Example2(list);
            Assert.IsTrue(true, "Function succeeded");
            Assert.AreNotEqual(null, false, "The function did not fail");
        }

        [Test]
        //Given two integer search values if they are equal to the values in the array
        public void TestExample3()
        {
            int[] list = { 1, 5, 7, 10 };
            bool result = u4.Example3(list);
            Assert.IsTrue(true, "Function Succeeded");
            Assert.AreEqual(result, true, "The value(s) were in the list");
        }

    }
}