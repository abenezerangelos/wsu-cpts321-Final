using NUnit.Framework;
using LogicEngine.RunTimeClass;
using LogicEngine;
using LogicEngine.Factories;
using LogicEngine.AbstractBaseClass;
using LogicEngine.RunTimeClass.FoodItems;
using System.Linq;
using System.Collections;
using LogicEngine.ItemAttributes;

namespace LogicEngineTests
{
    public class RunTimeClassTests_EngineController_ChangedItems
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_ChangeItemAttributes()
        {
            var appInstance = new EngineController();

            appInstance.CreateBasket("Veggie");
            appInstance.CreateBasket("Fruit");

            Basket<Veggie> veggieBasket = (Basket<Veggie>)appInstance.BasketContainer[0]!;

            veggieBasket.Add(new Veggie());
            veggieBasket.Add(new Veggie());
            veggieBasket.Add(new Veggie());
            veggieBasket.Add(new Veggie());

            veggieBasket.RemoveAt(2);

            Veggie item = (Veggie)veggieBasket[2];

            item.Name = "Lettuce";
            item.EnumColor = ItemColor.GREEN;
            item.EnumTexture = ItemTexture.CRUNCHY;
            item.EnumSize = ItemSize.YUGE;
            item.EnumTaste = ItemTaste.SWEET;
 
            Assert.AreEqual(((Basket<Veggie>)appInstance.BasketContainer[0]!)[2].Name, "Lettuce");
        }
    }
}
