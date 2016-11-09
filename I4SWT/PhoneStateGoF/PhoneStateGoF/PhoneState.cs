namespace PhoneStateGoF
{
    public class PhoneState
    {
        
        public virtual void CBPressed(Phone phone)
        {
            
        }
        public virtual void ConnectionEstablished(Phone phone)
        {

        }
        public virtual void ConnectionNotEstablished(Phone phone)
        {

        }
        
        public virtual void ConnectionLost(Phone phone)
        {
            
        }
        public virtual void ToggleLoudSpeaker(Phone phone)
        {

        }

        public virtual void OnEnter(Phone phone)
        {
            
        }
    }
}