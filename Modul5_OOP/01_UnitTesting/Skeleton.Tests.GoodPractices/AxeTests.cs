using System;
using NUnit.Framework;
using Skeleton;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttack = 10;
        private const int AxeDurability = 10;
        private const int ExpectedDurabilityAfterOneAttack = 9;
        private const int DummyHealth = 20;
        private const int DummyExperience = 20;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            // Act
            this.axe.Attack(this.dummy);

            // Assert
            Assert.That(
                this.axe.DurabilityPoints,
                Is.EqualTo(ExpectedDurabilityAfterOneAttack),
                "Axe Durability doesn't change after attack");
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            // Arrange
            Axe brokenAxe = new Axe(AxeAttack, 1);
            brokenAxe.Attack(this.dummy);

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(
                () => brokenAxe.Attack(this.dummy),
                "Broken axe was able to attack");

            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }
    }
}