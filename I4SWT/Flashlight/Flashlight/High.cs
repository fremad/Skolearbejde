namespace Flashlight
{
    public class High : On
    {
        public override void onEnter(FlashLight context)
        {

        }

        public override void ModePressed(FlashLight context)
        {
            context.SetLowBeam();
            context.SetState(new Low());
        }
    }
}