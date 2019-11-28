using Library_Student.Data;
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
    /// Window1.xaml etkileşim mantığı
    /// </summary>
    public partial class PasswordUpdate : Window
    {
        private CetUser loginUser;

        private LibraryDb db = new LibraryDb();
 



        public PasswordUpdate(CetUser cetUser)
        {
            loginUser = cetUser;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            CetUserService cetUserService = new CetUserService();
           

            string temp1 = cetUserService.hashPassword(txtOldPassword.Text);

            if (temp1 == loginUser.Password)
            {
                string temp2 = cetUserService.hashPassword(txtNewPassword.Password);
                string temp3 = cetUserService.hashPassword(txtNewPassword1.Password);

                if (temp2 == temp3)
                {
                    loginUser.Password = temp2;
                    db.CetUsers.Update(loginUser);
                    db.SaveChangesAsync();
                    MessageBox.Show("Şifreniz güncellendi!");
                }
                else MessageBox.Show("Hatalı giriş yaptınız.");
                

            }
            else MessageBox.Show("Eski şifrenizi hatalı girdiniz.");
        
        }
    }
}
