using NSubstitute;
using NUnit.Framework;

namespace ExampleStatemachine.Test.Unit
{
    [TestFixture]
    public class FlashLightUnitTest
    {
        private ILamp _lamp;
        private IFlashLightCtrl _uut;

        [SetUp]
        public void SetUp()
        {
            _lamp = Substitute.For<ILamp>();
            _uut = new FlashLightCtrl(_lamp);
        }

        [Test]
        public void PwrPressedOnce_Initial_LowBeamSet()
        {
            _uut.PwrPressed();
            _lamp.Received().Low();
        }

        [Test]
        public void PwrPressedTwice_Initial_HighBeamSet()
        {
            _uut.PwrPressed();
            _uut.PwrPressed();
            _lamp.Received().High();
        }

        [Test]
        public void PwrPressedThrice_Initial_LampOff()
        {
            _uut.PwrPressed();
            _uut.PwrPressed();
            _uut.PwrPressed();
            _lamp.Received().Off();
        }



        [Test]
        public void LowBattery_LowBatteryInLampOff_LampDidNotReceiveOff()
        {
            _uut.LowBattery();
            _uut.PwrPressed();

            _lamp.DidNotReceive().Off();
        }

        [Test]
        public void LowBattery_LowBatteryInLampOff_LampDidNotReceiveLow()
        {
            _uut.LowBattery();
            _uut.PwrPressed();

            _lamp.DidNotReceive().Low();
        }

        [Test]
        public void LowBattery_LowBatteryInLampOff_LampDidNotReceivehigh()
        {
            _uut.LowBattery();
            _uut.PwrPressed();

            _lamp.DidNotReceive().High();
        }

        [Test]
        public void LowBattery_LowBatteryInLowBeam_NoReaction()
        {
            _uut.PwrPressed();
            _uut.LowBattery();
            _uut.PwrPressed();
            _lamp.Received().High();
        }

        [Test]
        public void LowBattery_LowBatteryInHighBeam_NoReaction()
        {
            _uut.PwrPressed();
            _uut.PwrPressed();
            _uut.LowBattery();
            _uut.PwrPressed();
            _lamp.Received().Off();
        }

        [Test]
        public void BatteryOk_LowBattery_OperationBackToNormal()
        {
            _uut.LowBattery();
            _uut.BatteryOk();
            _uut.PwrPressed();
            _lamp.Received().Low();
        }


    }
}
