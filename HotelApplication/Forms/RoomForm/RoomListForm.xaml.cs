using DataModel.Directories;
using Microsoft.EntityFrameworkCore;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
        }

        private  void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var rooms = context.Rooms
                    .Include(r => r.RoomType)
                    .ToArray();

                dgRooms.ItemsSource = rooms;
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShowRoomEdit_Click(object sender, RoutedEventArgs e)
        {
            EditRoom editroom = new EditRoom();
            editroom.ShowDialog();
        }

        private void AddRoom_Click(object sender, RoutedEventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.ShowDialog();
        }


        //RoomListForm roomListForm = new RoomListForm();
        //roomListForm.ShowDialog();
    }
}
