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
    /// Логика взаимодействия для GuestForm.xaml
    /// </summary>
    public partial class GuestForm : Window
    {
        public GuestForm()
        {
            InitializeComponent();
        }
    }

    private void ShowRoomEdit_Click(object sender, RoutedEventArgs e)
    {
        EditRoom editroom = new EditRoom();
        editroom.ShowDialog();
    }
