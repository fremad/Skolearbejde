namespace Flashlight
{
    public class Red : ColorState
    {
        public override void onEnter(FlashLight flashLight)
        {
            flashLight.RedLight();
        }

        public override void CbPressed(FlashLight flashLight)
        {
            flashLight.SetState(new Green());
        }
    }
}