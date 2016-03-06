using System.Windows;
using AIS.Model;
using System.Collections.Generic;

namespace AIS.View
{
    /// <summary>
    /// Interaction logic for FilingListAdminView.xaml
    /// </summary>
    public partial class FilingListAdminView : Window
    {
        public FilingListAdminView()
        {
            InitializeComponent();

            FilingDataGrid.ItemsSource = Program.filings;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginView = new MainWindow();
            loginView.Show();
            this.Close();
        }

        private void SeeArchiveBtn_Click(object sender, RoutedEventArgs e)
        {
            ArchiveListAdminView archiveAdminView = new ArchiveListAdminView();
            archiveAdminView.Show();
            this.Close();
        }

        private void AddFilingBtn_Click(object sender, RoutedEventArgs e)
        {
            AddFilingView addFilingView = new AddFilingView();
            addFilingView.Show();
            this.Close();
        }

        private void DelArchiveBtn_Click(object sender, RoutedEventArgs e)
        {
            Program.DeleteFiling(FilingDataGrid.SelectedItem as FilingModel);
        }

        private void UpdateArchiveBtn_Click(object sender, RoutedEventArgs e)
        {
            AddFilingView addFilingView = new AddFilingView(FilingDataGrid.SelectedItem as FilingModel);
            addFilingView.Show();
            this.Close();
        }
    }
}
