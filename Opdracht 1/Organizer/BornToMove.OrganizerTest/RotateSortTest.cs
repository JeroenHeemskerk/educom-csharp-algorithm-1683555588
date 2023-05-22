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
        public void testSortOneElement()
        {
            // Arrange
            var rotate = new RotateSort<int>();
            List<int> list = new List<int>{ 17 } ;
            List<int> expectedList = new List<int>{ 17 };

            // Act
            rotate.Rotate(list, 0, list.Count - 1, Comparer<int>.Default);

            // Assert
            Assert.AreEqual(expectedList, list);
        }

        [Test]
        public void testSortTwoElements()
        {
            // Arrange
            var rotate = new RotateSort<int>();
            List<int> list = new List<int> { 17, -17 };
            List<int> expectedList = new List<int> { -17, 17 };

            // Act
            rotate.Rotate(list, 0, list.Count - 1, Comparer<int>.Default);

            // Assert
            Assert.AreEqual(expectedList, list);
        }

        [Test]
        public void testSortThreeElements()
        {
            //Arrange
            var rotate = new RotateSort<int>();
            List<int> list = new List<int> { 99, 99, 99 };
            List<int> expectedList = new List<int> { 99, 99, 99 };

            //act
            rotate.Rotate(list, 0, list.Count - 1, Comparer<int>.Default);

            //Assert
            Assert.AreEqual(expectedList, list);
        }

        [Test]
        public void testSortUnsortedArray()
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

        [Test]
        public void testSortSevenElements()
        {
            // Arrange
            var rotate = new RotateSort<int>();
            List<int> list = new List<int> { 5, 2, 5, 1, 5, 2 };
            List<int> expectedList = new List<int> { 1, 2, 2, 5, 5, 5 };

            // Act
            rotate.Rotate(list, 0, list.Count - 1, Comparer<int>.Default);

            // Assert
            Assert.AreEqual(expectedList, list);

        }
    }
}


