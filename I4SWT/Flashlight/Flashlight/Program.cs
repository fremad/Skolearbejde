using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Flashlight
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser flash = new FlashLight();

            flash.Power();
            flash.Mode();
            flash.Mode();

            flash.Power();

            flash.Mode();
            flash.Mode();
        }
    }
   public interface IUser
   {
       void Power();
       void Mode();
       void CbPressed();
   }
}


