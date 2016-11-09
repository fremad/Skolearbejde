namespace PhoneStateGoF.PhoneStates
{
    public class Disconnecting : PhoneState
    {
        public override void OnEnter(Phone phone)
        {
            phone.Disconnect();
            phone.SetState(new Idle());
        }
    }
}