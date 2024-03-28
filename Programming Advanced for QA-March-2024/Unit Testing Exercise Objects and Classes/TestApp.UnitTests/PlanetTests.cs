using NUnit.Framework;

using System;

namespace TestApp.UnitTests
{
    public class PlanetTests
    {
        [Test]
        public void Test_CalculateGravity_ReturnsCorrectCalculation()
        {
            // Arrange
            Planet earth = new Planet("Earth", 12742, 149600000, 1);
            double mass = 1000;
            double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

            // Act
            double actualGravity = earth.CalculateGravity(mass);

            // Assert
            Assert.AreEqual(expectedGravity, actualGravity);
        }

        [Test]
        public void Test_GetPlanetInfo_ReturnsCorrectInfo()
        {
            // Arrange
            string name = "Mars";
            double diameter = 6779;
            double distanceFromSun = 227900000;
            int numberOfMoons = 2;

            Planet mars = new Planet(name, diameter, distanceFromSun, numberOfMoons);

            // Act
            string planetInfo = mars.GetPlanetInfo();

            // Assert
            Assert.That(planetInfo, Does.Contain($"Planet: {name}"));
            Assert.That(planetInfo, Does.Contain($"Diameter: {diameter} km"));
            Assert.That(planetInfo, Does.Contain($"Distance from the Sun: {distanceFromSun} km"));
            Assert.That(planetInfo, Does.Contain($"Number of Moons: {numberOfMoons}"));
        }
    }
}