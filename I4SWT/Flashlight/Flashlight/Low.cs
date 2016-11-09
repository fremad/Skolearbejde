namespace Flashlight
{
    public class Low : On
    {
        public override void onEnter(FlashLight context)
        {
            
        }

        public override void ModePressed(FlashLight context)
        {
            context.SetHighBeam();
            context.SetState(new High());
        }

    }
}