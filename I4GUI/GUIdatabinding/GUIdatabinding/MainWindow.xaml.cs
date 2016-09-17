using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using I4GUI;

namespace GUIdatabinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        I4GUI.Agents agentGrps = new Agents();

        I4GUI.Agent anAgent = new I4GUI.Agent("007", "James Bond", "Park Avenue", "Assaniation", "Bush");
        I4GUI.Agent secondAgent = new I4GUI.Agent("005", "Me", "Here", "Boom", "myMom");

        public MainWindow()
        {
            InitializeComponent();

            agentGrps.Add(anAgent);
            agentGrps.Add(secondAgent);

            //Binding binding1 = new Binding();
            //binding1.Source = agentGrps;
            listBox.ItemsSource = agentGrps;
            //listBox.SetBinding(ListBox.ItemsSourceProperty, binding1);
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AgentIdlblA.Content = anAgent.ID;
            CodenamelblA.Content = anAgent.CodeName;
            SpecialitylblA.Content = anAgent.Speciality;
            AssignmentlblA.Content = anAgent.Assignment;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
