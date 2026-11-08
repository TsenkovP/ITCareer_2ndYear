using System;
using NUnit.Framework;
using Skeleton;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int InitialHealth = 20;
        private const int Experience = 10;
        private const int AttackPoints = 5;
        private const int ExpectedHealthAfterAttack = 15;
        private const int DeadDummyHealth = 0;

        private Dummy aliveDummy;
        private Dummy deadDummy;

        [SetUp]
        public void SetUp()
        {
            this.aliveDummy = new Dummy(InitialHealth, Experience);
            this.deadDummy = new Dummy(DeadDummyHealth, Experience);
        }

        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            // Act
            this.aliveDummy.TakeAttack(AttackPoints);

            // Assert
            Assert.That(
                this.aliveDummy.Health,
                Is.EqualTo(ExpectedHealthAfterAttack),
                "Dummy health does not decrease correctly after attack");
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(
                () => this.deadDummy.TakeAttack(AttackPoints),
                "Dead dummy did not throw an exception when attacked");

            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            // Act
            int gainedXp = this.deadDummy.GiveExperience();

            // Assert
            Assert.That(
                gainedXp,
                Is.EqualTo(Experience),
                "Dead dummy does not give the expected experience");
        }

        [Test]
        public void AliveDummyCantGiveExperience()
        {
            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(
                () => this.aliveDummy.GiveExperience(),
                "Alive dummy was able to give experience");

            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}