using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Library_Student.Service;


namespace Library_Student
{
    /// <summary>
    /// LoginWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            CetUserService cetUserService = new CetUserService();
            var loginUser = cetUserService.Login(txtUserName.Text, txtPassword.Password);
            if (loginUser == null)
            {
                MessageBox.Show("Hatalı giris");
            }
            else
            {
                //doğru giriş
                MainWindow mainWindow = new MainWindow(loginUser);
                mainWindow.Show();
                this.Close();
            }
        }

        /*private void btnNewPassword_Click(object sender, RoutedEventArgs e)
        {
            
            PasswordUpdate passwordUpdate = new PasswordUpdate(loginUser);
            passwordUpdate.Show();
            this.Close();

        }*/
    }
}
