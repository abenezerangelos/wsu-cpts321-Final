using NUnit.Framework;
using LogicEngine.RunTimeClass;
using LogicEngine.RunTimeClass.FoodItem;
using LogicEngine.ItemAttributes;

namespace LogicEngineTests
{
    public class RunTimeClassTests_FoodItems
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

        [Test]
        public void Test_VeggieAttributes()
        {
            var veggie = new Veggie();

            veggie.Color = ItemColor.GREEN.ToString();

            Assert.That(veggie.Color, Is.EqualTo(ItemColor.GREEN.ToString()));
        }
    }
}