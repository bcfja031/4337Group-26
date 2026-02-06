using System.Windows;

namespace Group4337
{
    public partial class MainWindow : Window
    {
        public MainWindow()
            => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow second = new SecondWindow();
            second.Show();
            this.Close();
        }
    }
}