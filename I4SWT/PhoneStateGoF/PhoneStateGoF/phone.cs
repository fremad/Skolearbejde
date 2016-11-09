using System;
using System.Reflection;
using PhoneStateGoF.PhoneStates;

namespace PhoneStateGoF
{
    public class Phone : ItopInteface
    {
        PhoneState _state;


        public string Number { get; set; }

        public void OnEnter()
        {
            _state.OnEnter(this);
        }
        

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting phoneline!\n");
        }

        public void AlertConnectionLost()
        {
            Console.WriteLine("Lost Connection");
        }

        public void TurnOffMic()
        {
            Console.WriteLine("Mic turned Off! \n");
        }

        public void ConnectionLost()
        {
            _state.ConnectionLost(this);        
        }

        public void LoudSpeakerOff()
        {
            Console.WriteLine("Loadspeaker Off\n");
        }

        public void ToggleLoudSpeaker()
        {
            _state.ToggleLoudSpeaker(this);
        }

        public void LoudSpeakerOn()
        {
            Console.WriteLine("Loadspeaker On\n");
        }

        public Phone()
        {
            _state = new Idle();
        }

        public void SetState(PhoneState state)
        {
            _state = state;
        }

        public void CBPressed()
        {
            _state.CBPressed(this);
        }

        public void ConnectionEstablished()
        {
            _state.ConnectionEstablished(this);
        }
        public void Call(string number)
        {
            Console.WriteLine("Calling : "+ number + "\n");
        }

        public void CallNoNumer()
        {
            Console.WriteLine("No number entered! \n");
        }


        public void TurnOnMic()
        {
            Console.WriteLine("Mic is now On! \n");
        }

        public void ConnectionNotEstablished()
        {
            _state.ConnectionNotEstablished(this);
        }

        public void ConnectionFailed()
        {
            Console.WriteLine("Connection couldn't be established");
        }
    }
}