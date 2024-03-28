using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using TestApp;

namespace TestApp.UnitTests
{
    public class PersonTests
    {
        private Person _person;

        [SetUp]
        public void Setup()
        {
            _person = new Person();
        }

        [Test]
        public void Test_AddPeople_ReturnsListWithUniquePeople()
        {
            // Arrange
            string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
            List<Person> expectedPeopleList = new List<Person>
            {
                new Person { Name = "Alice", Id = "A001", Age = 35 },
                new Person { Name = "Bob", Id = "B002", Age = 30 }
            };

            // Act
            List<Person> resultPeopleList = _person.AddPeople(peopleData);

            // Assert
            Assert.That(resultPeopleList, Has.Count.EqualTo(2));
            for (int i = 0; i < resultPeopleList.Count; i++)
            {
                Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
                Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
                Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
            }
        }

        [Test]
        public void Test_GetByAgeAscending_SortsPeopleByAge()
        {
            // Arrange
            List<Person> peopleList = new List<Person>
    {
        new Person { Name = "Alice", Id = "A001", Age = 25 },
        new Person { Name = "Bob", Id = "B002", Age = 30 },
        new Person { Name = "Charlie", Id = "C003", Age = 20 }
    };
            string expectedSortedOutput = "Charlie with ID: C003 is 20 years old.\nAlice with ID: A001 is 25 years old.\nBob with ID: B002 is 30 years old.";

            // Act
            string sortedOutput = _person.GetByAgeAscending(peopleList);

            // Assert
            Assert.That(sortedOutput.Replace("\r\n", "\n"), Is.EqualTo(expectedSortedOutput));
        }
    }
}
