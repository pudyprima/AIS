using System.Windows;

namespace AIS.View
{
    /// <summary>
    /// Interaction logic for FilingListUserView.xaml
    /// </summary>
    public partial class FilingListUserView : Window
    {
        public FilingListUserView()
        {
            InitializeComponent();

            FilingDataGrid.ItemsSource = Program.filings;
        }

        private void SeeArchiveBtn_Click(object sender, RoutedEventArgs e)
        {
            ArchiveListUserView archiveUserView = new ArchiveListUserView();
            archiveUserView.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginView = new MainWindow();
            loginView.Show();
            this.Close();
        }
    }
}
