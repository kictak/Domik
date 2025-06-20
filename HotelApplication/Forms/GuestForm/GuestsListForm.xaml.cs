using System.Windows;
using ViewModel.GuestViewModel;

namespace HotelApplication.Forms.GuestForm
{
    /// <summary>
    /// Логика взаимодействия для GuestForm.xaml
    /// </summary>
    public partial class GuestsListForm : Window
    {
        public GuestsListForm()
        {
            InitializeComponent();
            DataContext = new CurrentGuestListViewModel();
        }

        private void EditGuest_Click(object sender, RoutedEventArgs e)
        {
            EditGuest editGuest = new EditGuest();
            editGuest.Show();
        }
    }
}