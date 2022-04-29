using NUnit.Framework;
using LogicEngine.RunTimeClass;

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
    }
}