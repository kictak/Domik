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

    public partial class Hand : Window
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

            student.Group = (Group) cbGroups.SelectedItem;
        }
    }
}
