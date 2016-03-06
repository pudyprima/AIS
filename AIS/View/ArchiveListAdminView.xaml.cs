using System.Windows;
using AIS.Model;

namespace AIS.View
{
    /// <summary>
    /// Interaction logic for ArchiveListOperatorView.xaml
    /// </summary>
    public partial class ArchiveListAdminView : Window
    {
        public ArchiveListAdminView()
        {
            InitializeComponent();

            ArchiveDataGrid.ItemsSource = Program.archives;
        }

        private void AddArchiveBtn_Click(object sender, RoutedEventArgs e)
        {
            AddArchiveView addArchiveView = new AddArchiveView();
            addArchiveView.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginView = new MainWindow();
            loginView.Show();
            this.Close();
        }

        private void SeeFilingBtn_Click(object sender, RoutedEventArgs e)
        {
            FilingListAdminView filingAdminView = new FilingListAdminView();
            filingAdminView.Show();
            this.Close();
        }

        private void DelArchiveBtn_Click(object sender, RoutedEventArgs e)
        {
            Program.DeleteArchive(ArchiveDataGrid.SelectedItem as ArchiveModel);
        }

        private void UpdateArchiveBtn_Click(object sender, RoutedEventArgs e)
        {
            AddArchiveView addArchiveView = new AddArchiveView(ArchiveDataGrid.SelectedItem as ArchiveModel);
            addArchiveView.Show();
            this.Close();
        }
    }
}
