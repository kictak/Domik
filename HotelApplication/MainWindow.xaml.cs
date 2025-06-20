using HotelApplication.Forms.GuestForm;
using HotelApplication.Forms.RoomForm;
using System.Windows;

namespace HotelApplication
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
        }

        private void ShowRooms_Click(object sender, RoutedEventArgs e)
        {
            RoomListForm roomListForm = new RoomListForm();
            roomListForm.ShowDialog();
        }

        private void ShowGuest_Click(object sender, RoutedEventArgs e)
        {
            GuestsListForm guestListForm = new GuestsListForm();
            guestListForm.ShowDialog();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("WPF на METANIT.COM");
        //}
    }
}