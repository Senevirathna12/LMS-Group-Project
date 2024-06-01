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
using System.Windows.Shapes;
using static Azure.Core.HttpHeader;

namespace GrpProject
{
    /// <summary>
    /// Interaction logic for StudentLoginWindow.xaml
    /// </summary>
    public partial class StudentLoginWindow : Window
    {
        public string[] names { get; set; }
        public StudentLoginWindow()
        {
            DataContext = new LoginWindowVM();
            InitializeComponent();

            names = new string[] { "Admin", "Student" };
            DataContext = this;

        }
        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            string password = "useriscom";

            string userInput = txtpassword.Password.ToString();
            string userInput3 = userInput.ToLower();

            string usertype = "Student";
            string userInput1 = cbox2.Text.ToLower();


            if ((userInput3 == password) && (userInput1 == "student"))
            {
                
                StudentMainWindow mainWindow = new StudentMainWindow();
                mainWindow.Show();
                this.Close();


            }
            else if ((userInput1 != "student"))
            {
                MessageBox.Show("This is Student Loging Side...");
                txtpassword.Clear();
            }

            else
            {
                MessageBox.Show("Check Your  Password");
                txtpassword.Clear();

            }




            

        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow window = new FirstWindow();
            window.Show();
            this.Close();
        }
    }
}
