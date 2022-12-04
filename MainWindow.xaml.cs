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

namespace WPF_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private List<string> SelectedToppings()
        {


            List<string> temp = new List<string>();
            temp.Add("Toppings: ");
            if (chkMeat.IsChecked.Value) temp.Add("Meat");
            if (chkCheese.IsChecked.Value) temp.Add("Cheese");
            if (chkTomato.IsChecked.Value) temp.Add("Tomato");
            if (chkLettuce.IsChecked.Value) temp.Add("Lettuce");

            return temp;
        }

        private string SelectedBread()
        {
            string breadOrder = "Bread:\n";
            if (rbWhite.IsChecked.Value)
            {
                breadOrder += "White\n";
            }
            else if (rbWheat.IsChecked.Value)
            {
                breadOrder += "Wheat\n";
            }
            else if (rbRosemary.IsChecked.Value)
            {
                breadOrder += "Rosemary\n";
            }
            else
            {
                breadOrder += "Glutten Free\n";
            }

            return breadOrder;
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            string recipt = "";

            recipt += txtSandwichName.Text + "\n\n";

            // Bread Order
            recipt += SelectedBread();
            recipt += "\n";
            // Toppings
            foreach (string topping in SelectedToppings())
            {
                recipt += topping + "\n";
            }
            recipt += "\n";


            rtbDisplay.Text = recipt;
        }
    }
}
