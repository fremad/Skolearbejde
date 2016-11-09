using System;

namespace Flashlight
{
    public class FlashLight : IUser
    {
        //States

        #region MyRegion

        private FlashLightState _state;
        private ColorState _colorState;

        public FlashLight()
        {
            SetState(new FlashLightState());
            SetState(new ColorState());
        }

        public void SetState(ColorState state)
        {
            _colorState = state;
            _colorState.onEnter(this);
        }
        public void SetState(FlashLightState state)
        {
            _state = state;
            _state.onEnter(this);
        }

        public void Power()
        {
            _state.PWRPressed(this);
        }

        public void CbPressed()
        {
            _colorState.CbPressed(this);
        }
        
        public void Mode()
        {
            _state.ModePressed(this);
        }

        public void CbPressed()
        {
            
        }

        #endregion

        //Actions

        #region MyRegion
        public void LightOn()
        {
            Console.WriteLine("Light is on! \n");
        }

        public void LightOff()
        {
            Console.WriteLine("Light is off! \n");
        }

        public void SetLowBeam()
        {
            Console.WriteLine("Low Light! \n");
        }

        public void SetHighBeam()
        {
            Console.WriteLine("High Light! \n");
        }
        #endregion

        public void GreenLight()
        {
            Console.WriteLine("Green color!");
        }

        public void RedLight()
        {
            Console.WriteLine("Red color!");
        }
    }
}