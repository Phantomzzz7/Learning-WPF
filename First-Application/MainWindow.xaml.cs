using System.Windows;


namespace First_Application
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Hello", "First application ", MessageBoxButton.YesNoCancel, MessageBoxImage.Error);
            if (result == MessageBoxResult.Yes)

            {
                MessageBox.Show("You clicked Yes");
            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("You clicked No");
            }
        }
    }
}