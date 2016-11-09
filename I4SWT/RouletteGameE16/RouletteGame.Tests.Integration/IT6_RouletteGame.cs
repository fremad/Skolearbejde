using NSubstitute;
using NUnit.Framework;
using RouletteGame.Bets;
using RouletteGame.Fields;
using RouletteGame.Game;
using RouletteGame.Output;
using RouletteGame.Randomizing;

namespace RouletteGame.Tests.Integration
{
    [TestFixture]
    class IT6_RouletteGame
    {
        private Game.Game _game;
        private Roulette.Roulette _roulette;
        private IOutput _output;
        private IRandomizer _randomizer;

        [SetUp]
        public void SetUp()
        {
            _randomizer = Substitute.For<IRandomizer>();
            _output = Substitute.For<IOutput>();

            _roulette = new Roulette.Roulette(new StandardFieldFactory(), _randomizer);
            _game = new Game.Game(_roulette, _output);
        }


    }
}
