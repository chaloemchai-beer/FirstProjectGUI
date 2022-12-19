using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace FirstProejct
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultBox.IsEnabled = false;
        }

        private void calculateBtn_Click(object sender, RoutedEventArgs e)
        {
           if (checkError(incomeBox.Text, expensesBox.Text, goalBox.Text) == false)
            {
                Console.WriteLine("Not Pass");
            }
           else
            {
                try
                {
                    double day = Math.Ceiling(double.Parse(goalBox.Text) / (double.Parse(incomeBox.Text) - double.Parse(expensesBox.Text)));
                    resultBox.Text = day.ToString();
                }
                catch
                {
                    MessageBox.Show("พบข้อผิดพลาด โปรแกรมจะทำการปิดตัวเอง");
                    Close();
                }

            }
            
        }

        private bool checkError(String income, String expenses, String goal)
        {
            if (income == "")
            {
                MessageBox.Show("โปรดกรอกข้อมุล (รายได้)");
                return false;
            }
            else if (expenses == "")
            {
                MessageBox.Show("โปรดกรอกข้อมุล (ค่าใช้จ่าย)");
                return false;
            }
            else if(goal == "")
            {
                MessageBox.Show("โปรดกรอกข้อมุล (ราคาของที่อยากได้)");
                return false;
            }
            else if(Regex.IsMatch(income, "^[a-zA-Z0-9ก-ฮ ]*$"))
            {
                MessageBox.Show("โปรดกรอกข้อมูลเป็นตัวเลข (รายได้)");
                return false;
            }else if(Regex.IsMatch(expenses, "^[a-zA-Z0-9ก-ฮ ]*$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("โปรดกรอกข้อมูลเป็นตัวเลข (ค่าใช้จ่าย)");
                return false;
            }else if(Regex.IsMatch(goal, "^[a-zA-Z0-9ก-ฮ ]*$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("โปรดกรอกข้อมูลเป็นตัวเลข (ราคาของที่อยากได้)");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void CleareBtn_Click(object sender, RoutedEventArgs e)
        {
            goalBox.Text = "";
            incomeBox.Text = "";
            expensesBox.Text = "";
            resultBox.Text = "";
        }
    }
}
