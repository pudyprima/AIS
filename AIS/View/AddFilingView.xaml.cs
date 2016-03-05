using System;
using System.Collections.Generic;
using System.Windows;
using AIS.Model;

namespace AIS.View
{
    /// <summary>
    /// Interaction logic for AddFilingView.xaml
    /// </summary>
    public partial class AddFilingView : Window
    {
        public AddFilingView()
        {
            InitializeComponent();

            ArchiveDataGrid.ItemsSource = Program.archives;
            comboBoxFilingType.ItemsSource = Program.filingTypes;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginView = new MainWindow();
            loginView.Show();
            this.Close();
        }

        private void CancelAddFilingBtn_Click(object sender, RoutedEventArgs e)
        {
            this.GoToFilingListView();
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            FilingModel filing = new FilingModel()
            {
                Type = comboBoxFilingType.SelectedValue.ToString(),
                Code = textBoxCode.Text,
                PIC = textBoxPIC.Text,
                CreatedDate = DateTime.Now,
                Archives = new List<ArchiveModel>()
            };

            for (int i = 0; i < ArchiveDataGrid.SelectedItems.Count; i++)
            {
                filing.Archives.Add(ArchiveDataGrid.SelectedItems[i] as ArchiveModel);
            }

            Program.AddFiling(filing);

            this.GoToFilingListView();
        }

        private void GoToFilingListView()
        {
            FilingListAdminView filingAdminView = new FilingListAdminView();
            filingAdminView.Show();
            this.Close();
        }
    }
}
