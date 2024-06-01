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

namespace GrpProject
{
    /// <summary>
    /// Interaction logic for AdminLoginWindow.xaml
    /// </summary>
    public partial class AdminLoginWindow : Window
    {
       

        public string[] names { get; set; }
        public AdminLoginWindow()
        {

            DataContext = new LoginWindowVM();
            InitializeComponent();

            names = new string[] { "Admin", "Student" };
            DataContext = this;

        }


        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            string password = "123456";

            string userInput = txtpassword.Password.ToString();


            string usertype = "Admin";
            string userInput1 = cbox1.Text.ToLower();


            if ((userInput == password) && (userInput1 == "admin"))
            {
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();


            }
            else if((userInput1 != "admin"))
            {
                MessageBox.Show("If you are Student You can't log Here...");
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

