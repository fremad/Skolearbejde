namespace PhoneStateGoF.PhoneStates
{
    public interface ItopInteface
    {
        void CBPressed();
        void ConnectionEstablished();
        void ConnectionNotEstablished();
        void ConnectionLost();
        void ToggleLoudSpeaker();

        string Number { get; set; }
    }
}