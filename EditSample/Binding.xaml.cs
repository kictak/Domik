using EditSample.Model;
using System.Windows;

namespace EditSample
{
    /// <summary>
    /// Логика взаимодействия для Binding.xaml
    /// </summary>
    public partial class Binding : Window
    {
        private Student student = new Student()
        {
            Age = 20,
            FirstName = "Петя",
            LastName = "Иванов",
            Id = 1,
        };

        private Group[] Groups =
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