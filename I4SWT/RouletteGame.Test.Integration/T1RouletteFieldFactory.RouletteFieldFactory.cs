using NUnit.Framework;
using NUnit.Framework.Internal;
using RouletteGame.Fields;
using RouletteGame.Randomizing;

namespace RouletteGame.Test.Integration
{
    [TestFixture]

    public class T1RouletteFieldFactory
    {
        private RouletteGame.Roulette.IRoulette _uut;
        private RouletteGame.Randomizing.IRandomizer _rand;
        private RouletteGame.Fields.IFieldFactory _fact;

        [SetUp]
        void Setup()
        {
			_fact = new StandardFieldFactory();
			_rand = new RouletteRandomizer();
          _uut = new  RouletteGame.Roulette.Roulette(_fact, _rand);
        }

   //     [Test]
   //     public void Spin_Is_Legal()
   //     {
            
			//Assert.That(()=> uut.Spin(), Throws.Nothing);
   //     }	


    }
}