using System.Windows;

namespace EditSample
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

        private void Hand_Click(object sender, RoutedEventArgs e)
        {
            Hand roomListForm = new Hand();
            roomListForm.ShowDialog();
        }

        private void Binding_Click(object sender, RoutedEventArgs e)
        {
            Binding roomListForm = new Binding();
            roomListForm.ShowDialog();
        }
    }
}