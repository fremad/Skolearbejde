using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStateGoF.PhoneStates
{
    class Idle : PhoneState
    {
        public Idle()
        {
            Console.WriteLine("In Idle");
        }


        public override void CBPressed(Phone phone)
        {
            if (phone.Number != null)
            {
                phone.Call(phone.Number);
                phone.SetState(new Calling());
            }
            else
            {
                phone.CallNoNumer();
            }
        }

    }
}
