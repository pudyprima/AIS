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
using Microsoft.Win32;

namespace AIS.View
{
    /// <summary>
    /// Interaction logic for AddArchiveView.xaml
    /// </summary>
    public partial class AddArchiveView : Window
    {
        private bool _isUpdate = false;
        private DateTime _entryDateTime;

        public AddArchiveView()
        {
            InitializeComponent();

            comboBoxArchiveType.ItemsSource = Program.archiveTypes;
            _entryDateTime = DateTime.Now;
        }

        public AddArchiveView(ArchiveModel archive)
        {
            InitializeComponent();

            comboBoxArchiveType.ItemsSource = Program.archiveTypes;
            comboBoxArchiveType.SelectedItem = archive.ArchiveType;
            textBoxRegistrationCode.Text = archive.RegistrationCode;
            textBoxRegistrationCode.IsEnabled = false;
            textBoxPIC.Text = archive.Applicant;
            textBoxScannedDoc.Text = archive.ScannedDocument;

            _entryDateTime = archive.EntryDateTime;
            _isUpdate = true;
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            ArchiveModel archive = new ArchiveModel()
            {
                ArchiveType = comboBoxArchiveType.SelectedValue.ToString(),
                RegistrationCode = textBoxRegistrationCode.Text,
                Applicant = textBoxPIC.Text,
                ScannedDocument = textBoxScannedDoc.Text,
                EntryDateTime = _entryDateTime
            };

            if (_isUpdate)
            {
                Program.UpdateArchive(archive);
            }
            else 
            {
                Program.AddArchive(archive);
            }

            this.GoToAdminView();
        }

        private void CancelAddArchiveBtn_Click(object sender, RoutedEventArgs e)
        {
            this.GoToAdminView();
        }

        private void GoToAdminView()
        {
            ArchiveListAdminView adminView = new ArchiveListAdminView();
            adminView.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginView = new MainWindow();
            loginView.Show();
            this.Close();
        }

        private void browseBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == true)
            {
                textBoxScannedDoc.Text = System.IO.Path.GetFileName(fileDialog.FileName);
            }
        }
    }
}
