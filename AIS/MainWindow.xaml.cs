using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AIS.View;

namespace AIS
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

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if (usernameTB.Text.Equals("admin") && PasswordBoxPB.Password.Equals("admin"))
            {
                ArchiveListAdminView adminView = new ArchiveListAdminView();
                adminView.Show();
                this.Close();
            }
            else if (usernameTB.Text.Equals("user") && PasswordBoxPB.Password.Equals("user"))
            {
                ArchiveListUserView userView = new ArchiveListUserView();
                userView.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah!");
            }
        }
    }
}
