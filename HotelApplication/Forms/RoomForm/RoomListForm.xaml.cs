using System.Windows;
using System.Windows.Controls;
using ViewModel.RoomViewModel;

namespace HotelApplication.Forms.RoomForm
{
    /// <summary>
    /// Логика взаимодействия для RoomListForm.xaml
    /// </summary>
    public partial class RoomListForm : Window
    {
        public RoomListForm()
        {
            InitializeComponent();
            DataContext = new RoomListViewModel();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void AddRoom_Click(object sender, RoutedEventArgs e)
        {
            var addRoom = new AddRoom();
            if (addRoom.ShowDialog() == true)
            {
                DataContext = new RoomListViewModel();
            }
        }

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (((DataGrid)sender).SelectedItem is ViewModel.RoomViewModel.RoomView selectedRoom)
            {
                var editRoom = new EditRoom(selectedRoom.Id);
                editRoom.ShowDialog();

                DataContext = new RoomListViewModel();
            }
        }

        private void ShowRoomEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem is ViewModel.RoomViewModel.RoomView selectedRoom)
            {
                var editRoom = new EditRoom(selectedRoom.Id);
                editRoom.ShowDialog();

                DataContext = new RoomListViewModel();
            }
        }
    }
}