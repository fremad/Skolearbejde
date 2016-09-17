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

namespace GuiBabyNames
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            DecadeListBox.SelectionChanged  += new SelectionChangedEventHandler(DecadeListBox_SelectionChanged);
        }

        private void DecadeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] topbabies = new string[amountofbabies];
            ListBoxItem item;
            List<BabyName> topBabyNames = new List<BabyName>();

            item = DecadeListBox.SelectedItem as ListBoxItem;

            if (item != null)
            {
                int decade = Convert.ToInt32(item.Content);
                Babynamelistbox.Items.Clear();

                foreach (var Baby in babiesList)
                {
                    if (Baby.Rank(decade) <= amountofbabies && 0 < Baby.Rank(decade))
                    {

                        if (topbabies[Baby.Rank(decade) - 1] == null)
                        {
                            topbabies[Baby.Rank(decade) - 1] = Baby.Rank(decade) +"\t" + Baby.Name;
                        }

                            else
                        {
                            topbabies[Baby.Rank(decade) - 1] += " and " + Baby.Name;
                        }
                        
                    }
                }
                foreach (var variable in topbabies)
                {
                    Babynamelistbox.Items.Add(variable);
                }
            }
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            

                

            string entry = System.IO.File.ReadAllText(@"C:\Users\Lars\Desktop\Skole\gitmappe\Skolearbejde\I4GUI\GuiBabyNames\GuiBabyNames\05-babynames.txt");

            string[] tokens;
            char[] separators = {'\n'};

            tokens = entry.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            foreach (var item in tokens)
            {
                babiesList.Add(new BabyName(item));
            }

            //Babynamelistbox.ItemsSource = babiesList;          

            
        }

        private const int amountofbabies = 10;
        private List<BabyName> babiesList = new List<BabyName>();
    }
}
