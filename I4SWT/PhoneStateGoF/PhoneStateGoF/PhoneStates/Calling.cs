using System;

namespace PhoneStateGoF.PhoneStates
{
    public class Calling : PhoneState
    {
        public override void ConnectionEstablished(Phone phone)
        {
            phone.TurnOnMic();
            phone.SetState(new Connected());
            phone.OnEnter();
        }

        public override void ConnectionNotEstablished(Phone phone)
        {
           phone.ConnectionFailed();
           phone.SetState(new Idle());
           phone.OnEnter();
        }
    }
}