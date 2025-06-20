using DataModel.Object;
using Storage;
using System.Windows;

namespace HotelApplication.Forms.RoomForm
{
    public partial class AddRoom : Window
    {
        public AddRoom()
        {
            InitializeComponent();
            using (var db = new MyDbContext())
            {
                cbRoomTypes.ItemsSource = db.RoomTypes.ToList();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbNumber.Text, out int number) &&
                int.TryParse(tbDayPrice.Text, out int dayPrice) &&
                cbRoomTypes.SelectedItem != null)
            {
                using (var db = new MyDbContext())
                {
                    var selectedRoomType = (DataModel.Directories.RoomType)cbRoomTypes.SelectedItem;

                    // Получаем RoomType из базы
                    var roomTypeFromDb = db.RoomTypes.Find(selectedRoomType.Id);

                    var room = new Room
                    {
                        Number = number,
                        DayPrice = dayPrice,
                        RoomType = roomTypeFromDb
                    };

                    db.Rooms.Add(room);
                    db.SaveChanges();
                }

                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные");
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}