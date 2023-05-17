using NUnit.Framework;
using Organizer;
using System.Collections.Generic;

namespace BornToMove.OrganizerTest
{
    public class RotateSortTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestRotateSortEmpty()
        {
            // Arrange
            var rotate = new RotateSort<int>();
            List<int> list = new List<int>();
            List<int> expectedList = new List<int>();


            // Act
            rotate.Rotate(list, 0, list.Count - 1, Comparer<int>.Default);

            // Assert
            Assert.AreEqual(expectedList, list);
        }
        [Test]
        public void TestSortUnsortedArray()
        {
            //Arrange
            var rotate = new RotateSort<int>();
            List<int> list = new List<int> {76, -9, 22 };
            List<int> expectedList = new List<int> { -9, 22, 76 };

            //Act
            rotate.Rotate(list, 0, list.Count - 1, Comparer<int>.Default);

            //Assert
            Assert.AreEqual(expectedList, list);
        }
    }
}


