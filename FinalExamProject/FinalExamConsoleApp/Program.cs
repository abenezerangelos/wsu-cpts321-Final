// See https://aka.ms/new-console-template for more information

using LogicEngine;
using LogicEngine.ItemAttributes;
using LogicEngine.AbstractBaseClass;
using LogicEngine.RunTimeClass.FoodItems;

Console.WriteLine("Hello, Venera!");

var application = new EngineController();

application.CreateFoodItem("Veggie");
Veggie veggie1 = (Veggie)application.ItemContainer[0]!;
veggie1.Name = "Lettuce";
veggie1.EnumColor = ItemColor.GREEN;
veggie1.EnumShape = ItemShape.SQUARE;
veggie1.EnumTaste = ItemTaste.SWEET;
veggie1.EnumTexture = ItemTexture.CRUNCHY;
veggie1.EnumSize = ItemSize.MEDIUM;

application.CreateFoodItem("Fruit");
Fruit fruit1 = (Fruit)application.ItemContainer[1]!;
fruit1.Name = "Banana";
fruit1.EnumColor = ItemColor.YELLOW;
fruit1.EnumShape = ItemShape.SQUARE;
fruit1.EnumTaste = ItemTaste.SWEET;
fruit1.EnumTexture = ItemTexture.SOFT;
fruit1.EnumSize = ItemSize.YUGE;

application.CreateBasket("Veggie");
var veggieBasket1 = application.BasketContainer[0];

application.CreateBasket("Fruit");
var fruitBasket1 = application.BasketContainer[1];

/// <summary>
/// 
/// </summary>
static void PrintItemAttributes(Food item)
{
    Console.WriteLine($"ITEM ATTRIBUTES FOR THE FOOD ITEM {item.Name}");
    Console.WriteLine($"	{item.Color}");
    Console.WriteLine($"	{item.Shape}");
    Console.WriteLine($"	{item.Size}");
    Console.WriteLine($"	{item.Texture}");
    Console.WriteLine($"	{item.Taste}");
}

PrintItemAttributes((Food)veggie1);
PrintItemAttributes((Food)fruit1);

