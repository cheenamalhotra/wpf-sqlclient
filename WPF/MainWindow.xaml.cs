using Microsoft.Data.SqlClient;
using System;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestSqlConnection();
        }

        private void TestSqlConnection()
        {
            try
            {
                // Provide your connection string here.
                using (SqlConnection sqlConnection = new SqlConnection("Server=localhost; Integrated Security=true; Trust Server Certificate=true;"))
                {
                    sqlConnection.Open();
                    MessageBox.Show(Convert.ToString("Connected successfully!"), "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
