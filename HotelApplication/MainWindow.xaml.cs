using ClosedXML.Excel;
using HotelApplication.Forms.GuestForm;
using HotelApplication.Forms.RoomForm;
using Microsoft.EntityFrameworkCore;
using Storage;
using System.IO;
using System.Windows;

namespace HotelApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ShowRooms_Click(object sender, RoutedEventArgs e)
        {
            RoomListForm roomListForm = new RoomListForm();
            roomListForm.ShowDialog();
        }

        private void ShowGuest_Click(object sender, RoutedEventArgs e)
        {
            GuestsListForm guestListForm = new GuestsListForm();
            guestListForm.ShowDialog();
        }

        private void ExportToExcel_Click(object sender, RoutedEventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            using (var db = new MyDbContext())
            {
                var checkIns = db.CheckIns
                    .Select(c => new
                    {
                        GuestName = c.Guest.Name,
                        c.Enter,
                        c.Exit,
                        RoomNumber = c.Room.Number,
                        RoomPrice = c.Room.DayPrice,
                        Days = EF.Functions.DateDiffDay(c.Enter, c.Exit),
                        Total = c.Room.DayPrice * EF.Functions.DateDiffDay(c.Enter, c.Exit)
                    })
                    .ToList();

                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Отчет");

                worksheet.Cell(1, 1).Value = "ФИО клиента";
                worksheet.Cell(1, 2).Value = "Дата заезда";
                worksheet.Cell(1, 3).Value = "Дата выезда";
                worksheet.Cell(1, 4).Value = "Номер комнаты";
                worksheet.Cell(1, 5).Value = "Цена за день";
                worksheet.Cell(1, 6).Value = "Количество дней";
                worksheet.Cell(1, 7).Value = "Сумма к оплате";

                int row = 2;
                foreach (var c in checkIns)
                {
                    worksheet.Cell(row, 1).Value = c.GuestName;
                    worksheet.Cell(row, 2).Value = c.Enter.ToString();
                    worksheet.Cell(row, 3).Value = c.Exit.ToString();
                    worksheet.Cell(row, 4).Value = c.RoomNumber;
                    worksheet.Cell(row, 5).Value = c.RoomPrice;
                    worksheet.Cell(row, 6).Value = c.Days;
                    worksheet.Cell(row, 7).Value = c.Total;
                    row++;
                }

                worksheet.Columns().AdjustToContents();

                var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Отчет.xlsx");
                workbook.SaveAs(filePath);

                MessageBox.Show($"Файл успешно сохранен: {filePath}");
            }
        }
    }
}