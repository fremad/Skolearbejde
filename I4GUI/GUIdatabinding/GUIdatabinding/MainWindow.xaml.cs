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
        public I4GUI.Agents _agentGrps = new Agents();

        public MainWindow()
        {
            InitializeComponent();

            listBox.ItemsSource = _agentGrps;

            //listBox.SelectionChanged += new SelectionChangedEventHandler(listBox_SelectionChanged);
            //Binding binding1 = new Binding();
            //binding1.Source = agentGrps;

            I4GUI.Agent anAgent = new I4GUI.Agent("007", "James Bond", "Park Avenue", "Assaniation", "Bush");
            _agentGrps.Add(anAgent);
            I4GUI.Agent snAgent = new I4GUI.Agent("005", "Jerome", "Parks Avenue", "Assaniation", "Bush");
            _agentGrps.Add(snAgent);
            //listBox.SetBinding(ListBox.ItemsSourceProperty, binding1);
            

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //I4GUI.Agent anAgent = new I4GUI.Agent("007", "James Bond", "Park Avenue", "Assaniation", "Bush");
            //_agentGrps.Add(anAgent);
        }

        
    }
}
