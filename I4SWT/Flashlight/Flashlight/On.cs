namespace Flashlight
{
    public class On : FlashLightState
    {
        public override void onEnter(FlashLight context)
        {
            context.SetState(new Low());
        }
        

        public override void ModePressed(FlashLight flashLight)
        {

        }
        public override void PWRPressed(FlashLight context)
        {
            context.LightOff();
            context.SetState(new Off());
        }
    }
}