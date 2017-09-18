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

namespace hours
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int stha = 1440; //24hrs

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            string a = textBox.Text;
            int b = Convert.ToInt32(a);//converts the user's value to an interger

            //string difference =Convert.ToString(sne +" " + "hours"+ " "+masa +" " +"minutes");
            stha = stha - b;// subracts waisted time 
            int sne = stha / 60;//gives you hours
            int masa = stha % 60;//gives you minutes
            string difference = Convert.ToString(sne + " " + "hours" + " " + masa + " " + "minutes");//appears in the textbox
            string item = comboBox.SelectionBoxItem.ToString();//checks the selscted item in the combobox

            int sn = b / 60;//hours for the selscted activity
            int mas = b % 60;//minutes for the selected activity


            if (item == "eating")
            {
              //display number of hours and minutes in the each textbox 
                textBox1.Text = sn + " " + "hours" + " " + mas + " " + "minutes";
                textBox2.Text = "0 hours 0 minutes";

            }
            else 
            {
                textBox2.Text = sn + " " + "hours" + " " + mas + " " + "minutes";
                textBox1.Text ="0 hours 0 minutes";

            }

            textBox3.Text = difference;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Add("eating");
            comboBox.Items.Add("sleeping");
        }
    }
}
