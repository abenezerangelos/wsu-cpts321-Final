using NUnit.Framework;
using LogicEngine.RunTimeClass;
using LogicEngine.RunTimeClass.FoodItem;
using LogicEngine;

namespace LogicEngineTests
{
    class RunTimeClassTests_Baskets
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_FruitBasketIsEmpty()
        {
            var basket = new Basket<Fruit>();

            basket.Add(new Fruit());

            Assert.That(basket, Is.Not.Null);
        }

        [Test]
        public void Test_FruitBasketIsNotNull()
        {
            var basket = new Basket<Fruit>();

            basket.Add(new Fruit());

            Assert.That(basket.Contents.Count, Is.GreaterThan(0));
        }

        [Test]
        public void Test_FruitBasketContentIsFruit()
        {
            var basket = new Basket<Fruit>();

            basket.Add(new Fruit());

            Assert.That(basket.Contents[0], Is.InstanceOf<Fruit>());
        }
    }
}
