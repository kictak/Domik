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

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    using (var context = new MyDbContext())
        //    {
        //        var guest = context.Guests
        //            .Include(r => r.Guests)
        //            .ToArray();

        //        dgGuests.ItemsSource = guest;
        //    }
        //}
    }
}

  
