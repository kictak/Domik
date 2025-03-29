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

namespace HotelApplication.Forms
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

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShowRooEdit_Click(object sender, RoutedEventArgs e)
        {
            EditRoom editRoom = new EditRoom();
            editRoom.ShowDialog();
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
