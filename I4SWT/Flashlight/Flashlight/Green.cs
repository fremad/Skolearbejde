namespace Flashlight
{
    public class Green : ColorState
    {
        public override void onEnter(FlashLight flashLight)
        {
            flashLight.GreenLight();
        }
    }
}