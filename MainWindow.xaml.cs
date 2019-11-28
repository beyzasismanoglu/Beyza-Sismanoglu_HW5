using Library_Student.Data;
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

namespace Library_Student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private CetUser loginUser;
        public MainWindow(CetUser cetUser)
        {
            loginUser = cetUser;
            InitializeComponent();
        }
       

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            txtLoginUser.Text = "Merhaba " + loginUser.Name + " " + loginUser.Surname + " " +loginUser.RoleName;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            PasswordUpdate passwordUpdate = new PasswordUpdate(loginUser);
            passwordUpdate.Show();
            this.Close();
        }
    }
}
