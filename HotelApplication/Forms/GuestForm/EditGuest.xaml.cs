using DataModel.Directories;
using Storage;
using System.Windows;

namespace HotelApplication.Forms.GuestForm
{
    public partial class EditGuest : Window
    {
        public EditGuest()
        {
            InitializeComponent();
            LoadReferenceData();
        }

        private void LoadReferenceData()
        {
            using (var db = new MyDbContext())
            {
                // Получаем список гендеров из базы
                var genders = db.Genders.ToList();
                GenderComboBox.ItemsSource = genders;
                GenderComboBox.DisplayMemberPath = "Name"; // Отображаем название
                GenderComboBox.SelectedValuePath = "Id";    // Id будет храниться как SelectedValue

                // Получаем список типов документов
                var docTypes = db.DocumentTypes.ToList();
                DocumentTypeComboBox.ItemsSource = docTypes;
                DocumentTypeComboBox.DisplayMemberPath = "DocumentName"; // Название документа
                DocumentTypeComboBox.SelectedValuePath = "Id";           // Id документа
                // Комнаты
                var rooms = db.Rooms.ToList();
                RoomComboBox.ItemsSource = rooms;
                RoomComboBox.DisplayMemberPath = "Number";
                RoomComboBox.SelectedValuePath = "Id";
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new MyDbContext())
            {
                var guest = new DataModel.Directories.Guest
                {
                    Name = NameTextBox.Text,
                    MiddleName = MiddleNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Adress = AddressTextBox.Text,
                    DateOfBirth = DateOnly.FromDateTime(BirthDatePicker.SelectedDate ?? DateTime.Now),
                    DocumentNumber = DocumentNumberTextBox.Text,
                    GenderId = (int)GenderComboBox.SelectedValue,
                    DocumentTypeId = (int)DocumentTypeComboBox.SelectedValue
                };

                db.Guests.Add(guest);
                db.SaveChanges();

                var checkIn = new CheckIn
                {
                    GuestId = guest.Id,
                    RoomId = (int)RoomComboBox.SelectedValue,
                    Enter = DateOnly.FromDateTime(DateTime.Now),
                    Exit = DateOnly.FromDateTime(DateTime.Now.AddDays(1)) // или выбрать дату
                };

                db.CheckIns.Add(checkIn);
                db.SaveChanges();

                MessageBox.Show($"Гость {guest.Name} успешно сохранён и заселён в комнату {checkIn.RoomId}!");
                Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}