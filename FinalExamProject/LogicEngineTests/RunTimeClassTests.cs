using NUnit.Framework;
using LogicEngine.RunTimeClass;
using LogicEngine.RunTimeClass.FoodItem;

namespace LogicEngineTests
{
    public class RunTimeClassTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_VeggieObjectNotNull()
        {
            Veggie veggie = new Veggie();
            
            Assert.That(veggie, Is.Not.Null);
        }

        [Test]
        public void Test_IsVeggieObject()
        {
            var veggie = new Veggie();

            Assert.That(veggie, Is.InstanceOf<Veggie>());
        }

        [Test]
        public void Test_FruitObjectNotNull()
        {
            Fruit fruit = new Fruit();

            Assert.That(fruit, Is.Not.Null);
        }

        [Test]
        public void Test_IsFruitObject()
        {
            var veggie = new Fruit();

            Assert.That(veggie, Is.InstanceOf<Fruit>());
        }
    }
}