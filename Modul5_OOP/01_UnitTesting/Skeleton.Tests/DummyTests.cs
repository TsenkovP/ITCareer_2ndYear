using System;
using NUnit.Framework;
using Skeleton;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            // Arrange
            Dummy dummy = new Dummy(10, 10);

            // Act
            dummy.TakeAttack(5);

            // Assert
            Assert.That(dummy.Health, Is.EqualTo(5), "Dummy health doesn't decrease after attack.");
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            // Arrange
            Dummy dummy = new Dummy(0, 10);

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(5));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            // Arrange
            Dummy dummy = new Dummy(0, 20);

            // Act
            int experience = dummy.GiveExperience();

            // Assert
            Assert.That(experience, Is.EqualTo(20), "Dead dummy must give experience.");
        }

        [Test]
        public void AliveDummyCantGiveExperience()
        {
            // Arrange
            Dummy dummy = new Dummy(10, 20);

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}