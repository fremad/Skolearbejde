namespace Flashlight
{
    public class Off : FlashLightState
    {
        public override void onEnter(FlashLight context)
        {
            
        }

        public override void PWRPressed(FlashLight context)
        {
            context.LightOn();
            context.SetState(new On());
        }
    }
}