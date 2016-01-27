using PeopleViewer.MyService;
using PersonRepository.Interface;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            var proxy = new PersonServiceClient();
            List<Person> people = proxy.GetPeople();
            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }

        private void AbstractFetchButton_Click(object sender, RoutedEventArgs e)
        {
            var proxy = new PersonServiceClient();
            IEnumerable<Person> people = proxy.GetPeople();
            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
        }
    }
}
