using System;

namespace ExampleStatemachine
{
    public class FlashLightCtrl : IFlashLightCtrl
    {
        enum FlState
        {
            Off, Low, High, PowerSave
        }

        private FlState _curState;
        private readonly ILamp _lamp;

        public FlashLightCtrl(ILamp lamp)
        {
            _lamp = lamp;
            _curState = FlState.Off;
        }

        public void PwrPressed()
        {
            switch (_curState)
            {
                case FlState.Off:
                    _lamp.Low();
                    _curState = FlState.Low;
                    break;

                case FlState.Low:
                    _lamp.High();
                    _curState = FlState.High;
                    break;
                    
                case FlState.High:
                    _lamp.Off();
                    _curState = FlState.Low;
                    break;

                case FlState.PowerSave:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }            
        }

        public void LowBattery()
        {
            switch(_curState)
            {
                case FlState.Off:
                    _curState = FlState.PowerSave;
                    break;

                case FlState.Low:
                case FlState.High:
                case FlState.PowerSave:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void BatteryOk()
        {
            switch(_curState)
            {
                case FlState.Off:
                case FlState.Low:
                case FlState.High:
                    break;
                case FlState.PowerSave:
                    _curState = FlState.Off;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
