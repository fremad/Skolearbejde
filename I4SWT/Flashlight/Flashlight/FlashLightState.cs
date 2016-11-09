namespace Flashlight
{
    public class FlashLightState
    {
        public virtual void onEnter(FlashLight context)
        {
            context.SetState(new Off());
        }

        public virtual void PWRPressed(FlashLight context)
        {

        }

        public virtual void CbPressed(FlashLight context)
        {
            
        }

        public virtual void ModePressed(FlashLight flashLight)
        {

        }
    }
}