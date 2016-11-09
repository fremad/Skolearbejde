using NUnit.Framework;
using RouletteGame.Fields;
using RouletteGame.Randomizing;

namespace RouletteGame.Tests.Integration
{
    [TestFixture]
    class IT5_RouletteRandomizer
    {
        private IRandomizer _randomizer;
        private Roulette.Roulette _roulette;
        private IFieldFactory _fieldFactory;

        [SetUp]
        public void SetUp()
        {
            _randomizer = new RouletteRandomizer();
            _fieldFactory = new StandardFieldFactory();
            _roulette = new Roulette.Roulette(_fieldFactory, _randomizer);
        }

    }
}
