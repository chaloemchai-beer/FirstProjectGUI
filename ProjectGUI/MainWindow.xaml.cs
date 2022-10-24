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

namespace ProjectGUI
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

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            int income = Convert.ToInt32(inputIncome.Text);
            int expenses = Convert.ToInt32(inputExpenses.Text);
            int goal = Convert.ToInt32(inputGoal.Text);

            int amount = income - expenses;
            int result = goal / amount ;
            if(amount * result != result)
            {
                result = goal / amount + 1;
            }
            String strresult = Convert.ToString(result);
            txtresult.Text = strresult;
        }
    }
}
