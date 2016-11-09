namespace Flashlight
{
    public class ColorState
    {
        public virtual void onEnter(FlashLight flashLight)
        {
            flashLight.SetState(new Green());
        }

        public virtual void CbPressed(FlashLight flashLight)
        {
            
        }
    }
}