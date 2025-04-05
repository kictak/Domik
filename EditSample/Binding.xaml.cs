using EditSample.Model;
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

namespace EditSample
{
    /// <summary>
    /// Логика взаимодействия для Binding.xaml
    /// </summary>
    public partial class Binding : Window
    {
        Student student = new Student()
        {
            Age = 20,
            FirstName = "Петя",
            LastName = "Иванов",
            Id = 1,
        };

        Group[] Groups =
            new Group[]
            {
                new Group {
                    Id = 1,
                    Name = "Пиб-32",
                },
                new Group {
                    Id = 2,
                    Name = "Пиб-31",
                }
            };


        public Binding()
        {
            InitializeComponent();
            DataContext = student;

            cbGroups.ItemsSource = Groups;
        }

        private void ShowInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Поля студента: {student.LastName} {student.FirstName}, возраст: {student.Age}, группа: {student.Group?.Name}");

        }
    }
}
