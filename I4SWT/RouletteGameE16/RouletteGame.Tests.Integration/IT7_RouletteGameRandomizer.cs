using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using RouletteGame.Bets;
using RouletteGame.Output;
using RouletteGame.Randomizing;
using RouletteGame.Fields;

namespace RouletteGame.Tests.Integration
{
    [TestFixture]
    class IT7_RouletteGameRandomizer
    {
        private Game.Game _game;
        private IOutput _output;

        [SetUp]
        public void SetUp()
        {
            _output = Substitute.For<IOutput>();

            var roulette = new Roulette.Roulette(new StandardFieldFactory(), new RouletteRandomizer());
            _game = new Game.Game(roulette, _output);
        }



    }
}
