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
using System.Windows.Shapes;
using AIS.Model;

namespace AIS.View
{
    /// <summary>
    /// Interaction logic for ArchiveListUserView.xaml
    /// </summary>
    public partial class ArchiveListUserView : Window
    {
        public ArchiveListUserView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ArchiveDataGrid.ItemsSource = Program.archives;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginView = new MainWindow();
            loginView.Show();
            this.Close();
        }

        private void filterBtn_Click(object sender, RoutedEventArgs e)
        {
            string keyword = applicantTB.Text;

            List<ArchiveModel> filteredArchives = Program.archives.Where(a => a.Applicant.ToLower().Contains(keyword.ToLower())).ToList();
            ArchiveDataGrid.ItemsSource = filteredArchives;
        }

        private void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            applicantTB.Clear();
            ArchiveDataGrid.ItemsSource = Program.archives;
        }

        private void SeeFilingBtn_Click(object sender, RoutedEventArgs e)
        {
            FilingListUserView filingUserView = new FilingListUserView();
            filingUserView.Show();
            this.Close();
        }
    }
}
