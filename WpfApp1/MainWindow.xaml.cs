using KursC_10_8;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Parametrs.IsEnabled = false;
            Parametrs.Visibility = Visibility.Collapsed;
        }


        List<Client> people = new List<Client>
        {
            new Client ( "Питер",  "Паркеp", "Бе́нджамин", "+375343455", "KN4389534539459","", "", "" ),
            new Client ( "Илья",  "Браузер", "Копилович", "+375573755", "KN4385673453957","", "", "" ),
            new Client ( "Ренат",  "Шамсутдинов", "Рустэмович", "+375567806", "KN438567568564457","", "", "" ),
            new Client ( "Дима",  "Шведко", "Иванович", "+3753631755", "KN438456456543957","", "", "" )
        };

        public static string name = "";
        public static string secondName = "";
        public static string lastName = "";
        public static string number = "";
        public static string pasport = "";
        public static byte levelAccept;

        Manager manager = new Manager();
        Сonsultant consultant = new Сonsultant();
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButtonConsultant.IsChecked == true)
            {

                myListBox.ItemsSource = consultant.WatchList(people);
                RadioButtonConsultant.Visibility = Visibility.Collapsed;
                RadioButtonManager.Visibility = Visibility.Collapsed;
                ButtonExit.Visibility = Visibility.Visible;
                ButtonChose.Visibility = Visibility.Collapsed;
                Parametrs.Visibility = Visibility.Visible;
                levelAccept = 0;

            }

            if (RadioButtonManager.IsChecked == true)
            {

                RadioButtonConsultant.Visibility = Visibility.Collapsed;
                RadioButtonManager.Visibility = Visibility.Collapsed;
                ButtonChose.Visibility = Visibility.Collapsed;
                ButtonExit.Visibility = Visibility.Visible;
                myListBox.ItemsSource = manager.WatchList(people);
                Parametrs.Visibility = Visibility.Visible;
                ButtonAdd.Visibility = Visibility.Visible;
                levelAccept = 1;
            }
        }

        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            RadioButtonConsultant.Visibility = Visibility.Visible;
            RadioButtonManager.Visibility = Visibility.Visible;
            ButtonChose.Visibility = Visibility.Visible;
            ButtonExit.Visibility = Visibility.Collapsed;
            myListBox.ItemsSource = null;
            Parametrs.Visibility = Visibility.Collapsed;
            ButtonAdd.Visibility = Visibility.Collapsed;


        }

        private void Parametrs_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = myListBox.SelectedIndex;
            name = people[selectedIndex].Name;
            secondName = people[selectedIndex].SecondName;
            lastName = people[selectedIndex].LastName;
            number = people[selectedIndex].Number;
            pasport = people[selectedIndex].NumberOfPasport;
            var dialog = new InputDialog();
            bool? result = dialog.ShowDialog();
            if (result.HasValue && result.Value && levelAccept == 0)
            {

               

               people[selectedIndex]= consultant.ChangedNumber(people[selectedIndex], InputDialog.newNumber);
                myListBox.ItemsSource= null;
                myListBox.ItemsSource = consultant.WatchList(people);

            }
            else if (result.HasValue && result.Value && levelAccept == 1)
            {
                people[selectedIndex] = manager.Changed(people[selectedIndex], InputDialog.newName, InputDialog.newSecondName, InputDialog.newLastName, InputDialog.newNumber, InputDialog.newPasport);
                myListBox.ItemsSource = null;
                myListBox.ItemsSource = manager.WatchList(people);
            }

        }





        public void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myListBox.SelectedItem != null)
            {
                Parametrs.IsEnabled = true;
            }
            else
            {
                Parametrs.IsEnabled = false;
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddClient();
            bool? result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                name = AddClient.newName;
                secondName = AddClient.newSecondName;
                lastName = AddClient.newLastName;
                number = AddClient.newNumber;
                pasport = AddClient.newPasport;
                people.Add(manager.CreateClient(name, secondName, lastName, number, pasport));
                myListBox.ItemsSource = null;
                myListBox.ItemsSource = manager.WatchList(people);
            }
        }

       
        
    }
}