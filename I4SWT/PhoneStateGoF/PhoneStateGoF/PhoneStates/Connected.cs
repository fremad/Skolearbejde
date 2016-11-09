namespace PhoneStateGoF.PhoneStates
{
    public class Connected : PhoneState
    {
        public override void CBPressed(Phone phone)
        {
            phone.TurnOffMic();
            phone.SetState(new Disconnecting());
            phone.OnEnter();   
        }

        public override void ConnectionLost(Phone phone)
        {
            phone.AlertConnectionLost();
            phone.SetState(new Idle());
        }


        public override void OnEnter(Phone phone)
        {
            phone.SetState(new Regular());
        }

        public override void ToggleLoudSpeaker(Phone phone)
        {
            
        }



    }

    public class LoudSpeaker : Connected
    {
        public override void ToggleLoudSpeaker(Phone phone)
        {
            phone.LoudSpeakerOff();
            phone.SetState(new Regular());
        }
    }

    public class Regular : Connected
    {
        public override void ToggleLoudSpeaker(Phone phone)
        {
            phone.LoudSpeakerOn();
            phone.SetState(new LoudSpeaker());
        }
    }
}