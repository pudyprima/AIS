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
        private bool _isUpdate = false;

        public AddFilingView()
        {
            InitializeComponent();

            ArchiveDataGrid.ItemsSource = Program.archives;
            comboBoxFilingType.ItemsSource = Program.filingTypes;
        }

        public AddFilingView(FilingModel filing)
        {
            InitializeComponent();

            ArchiveDataGrid.ItemsSource = Program.archives;
            foreach (ArchiveModel archive in filing.Archives)
            {
                ArchiveDataGrid.SelectedItems.Add(archive);
            }

            comboBoxFilingType.ItemsSource = Program.filingTypes;
            comboBoxFilingType.SelectedItem = filing.Type;
            textBoxCode.Text = filing.Code;
            textBoxCode.IsEnabled = false;
            textBoxPIC.Text = filing.PIC;

            _isUpdate = true;
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

            if (_isUpdate)
            {
                Program.UpdateFiling(filing);
            }
            else
            {
                Program.AddFiling(filing);
            }

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
