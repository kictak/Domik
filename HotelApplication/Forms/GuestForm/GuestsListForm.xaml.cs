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
using ViewModel;

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

  
