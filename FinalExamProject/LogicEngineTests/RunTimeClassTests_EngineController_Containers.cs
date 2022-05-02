using NUnit.Framework;
using LogicEngine.RunTimeClass;
using LogicEngine;
using LogicEngine.Factories;
using LogicEngine.AbstractBaseClass;
using LogicEngine.RunTimeClass.FoodItems;
using System.Linq;
using System.Collections;

namespace LogicEngineTests
{
    public class RunTimeClassTests_EngineController_Containers
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_CreateNewItem()
        {
            var appInstance = new EngineController();

            appInstance.CreateFoodItem("Veggie");

            Assert.That(appInstance.ItemContainer[0], Is.InstanceOf<Item>());
        }

        [Test]
        public void Test_CreateNewBasket_1()
        {
            var appInstance = new EngineController();

            appInstance.CreateBasket("Veggie");

            Assert.That(appInstance.BasketContainer[0], Is.InstanceOf<Basket<Veggie>>());
        }

        [Test]
        public void Test_CreateNewBasket_2()
        {
            var appInstance = new EngineController();

            appInstance.CreateBasket("Fruit");

            Assert.That(appInstance.BasketContainer[0], Is.InstanceOf<Basket<Fruit>>());
        }

        [Test]
        public void Test_AddNewBasket_1()
        {
            var appInstance = new EngineController();

            appInstance.CreateBasket("Veggie");

            Assert.AreEqual(appInstance.BasketContainer.Count, 1);
        }

        [Test]
        public void Test_AddNewBasket_2()
        {
            var appInstance = new EngineController();

            appInstance.CreateBasket("Veggie");
            appInstance.CreateBasket("Fruit");

            Assert.AreEqual(appInstance.BasketContainer.Count, 2);
        }

        [Test]
        public void Test_RemoveItemFromBasket_1()
        {
            var appInstance = new EngineController();

            appInstance.CreateBasket("Veggie");
            appInstance.CreateBasket("Fruit");

            Basket<Veggie> veggieBasket = (Basket<Veggie>)appInstance.BasketContainer[0];

            veggieBasket.Add(new Veggie());
            veggieBasket.Add(new Veggie());
            veggieBasket.Add(new Veggie());
            veggieBasket.Add(new Veggie());

            veggieBasket.RemoveAt(2);

            Assert.AreEqual(veggieBasket.Count, 3);
        }
    }
}
