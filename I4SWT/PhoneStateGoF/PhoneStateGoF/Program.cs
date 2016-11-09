using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStateGoF.PhoneStates;

namespace PhoneStateGoF
{
    class Program
    {
        static void Main(string[] args)
        {
            ItopInteface p1 = new Phone();

            p1.Number = "88888888";

            p1.CBPressed();
         
            p1.ConnectionEstablished();

            p1.ToggleLoudSpeaker();
            p1.ToggleLoudSpeaker();







        }
    }
}
