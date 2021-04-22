using System;
using System.Windows;

namespace Task3_WPF
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Variables for text boxes
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string age = DatePicker.Text;
            

            // Create error boxes for empty inputs
            if (string.IsNullOrEmpty(FirstName.Text))
            {
                MessageBox.Show("Error: You must insert a First Name >>>");
                FirstName.Text = "";
            }
            if (string.IsNullOrEmpty(LastName.Text))
            {
                MessageBox.Show("Error: You must insert a Last Name >>>");
                LastName.Text = "";
            }
            if (int.TryParse(PhoneNumber.Text, out int phone))
            {
                MessageBox.Show("Error: Please insert a valid phone number >>>");
                PhoneNumber.Text = "";
            }

            // Find users age
            int userAge = (DateTime.Now.Year - DateTime.Parse(age).Year);  

            // String to add to listbox.
            string a = ($"{LastName.Text}, {FirstName.Text} ({userAge}): {phone}");
            ListBox.Items.Add(a);

            FirstName.Clear();
            LastName.Clear();
            PhoneNumber.Clear();
            // DatePicker.ClearValue(); Can't Reset.
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
