namespace ExampleStatemachine
{
    public interface IFlashLightCtrl
    {
        void PwrPressed();
        void LowBattery();
        void BatteryOk();
    }
}