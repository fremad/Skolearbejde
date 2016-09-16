using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GUIdatabinding
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        I4GUI.Agents agentGrp = new I4GUI.Agents();

        private void Application_Startup(object s, StartupEventArgs e)
        {
            I4GUI.Agent agent1 = new I4GUI.Agent("007", "James Bond", "Park Avenue", "Assaniation", "Bush");
            agentGrp.Add(agent1);
        }
        
    }
}
