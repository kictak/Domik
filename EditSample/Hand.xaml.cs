using EditSample.Model;
using System.Windows;

namespace EditSample
{
    public partial class Hand : Window
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

        public Hand()
        {
            InitializeComponent();

            tbAge.Text = student.Age.ToString();
            tbFirstName.Text = student.FirstName;
            tbLastName.Text = student.LastName;

            cbGroups.ItemsSource = Groups;
        }

        private void ShowInfoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Поля студента: {student.LastName} {student.FirstName}, возраст: {student.Age}, группа: {student.Group.Name}");
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //нужно дописать проверки
            student.Age = int.Parse(tbAge.Text);
            student.FirstName = tbFirstName.Text;
            student.LastName = tbLastName.Text;

            student.Group = (Group)cbGroups.SelectedItem;
        }
    }
}