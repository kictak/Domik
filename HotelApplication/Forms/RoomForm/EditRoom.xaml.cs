using DataModel.Directories;
using DataModel.Object;
using Storage;
using System.Windows;

namespace HotelApplication.Forms.RoomForm
{
    /// <summary>
    /// Логика взаимодействия для EditRoom.xaml
    /// </summary>
    public partial class EditRoom : Window
    {
        private Room room = new Room()
        {
            Number = 42,
            DayPrice = 100
        };

        private RoomType[] RoomTypes = new RoomType[]
        {
            new RoomType
            {
                Id = 1,
                Type = "Стандарт",
                Places = 2,
            },
            new RoomType
            {
                Id = 2,
                Type = "Люкс",
                Places = 1,
            }
        };

        public EditRoom(int roomId)
        {
            InitializeComponent();

            using (var db = new MyDbContext())
            {
                room = db.Rooms
                         .Where(r => r.Id == roomId)
                         .FirstOrDefault();

                RoomTypes = db.RoomTypes.ToArray();
            }

            DataContext = room;
            cbRoomTypes.ItemsSource = RoomTypes;
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        }
    }
}