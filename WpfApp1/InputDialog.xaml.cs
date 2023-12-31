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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для InputDialog.xaml
    /// </summary>
    public partial class InputDialog : Window
    {
        public static string newName;
        public static string newSecondName;
        public static string newLastName;
        public static string newNumber;
        public static string newPasport;
        public InputDialog()
        {
            InitializeComponent();
            
            if(MainWindow.levelAccept == 0)
            {
                Name.Text = MainWindow.name;
                Name.IsReadOnly = true;
                SecondName.Text = MainWindow.secondName;
                SecondName.IsReadOnly = true;
                LastName.Text = MainWindow.lastName;
                LastName.IsReadOnly = true;
                Number.Text = MainWindow.number;
                Pasport.Text = MainWindow.pasport;
                Pasport.IsReadOnly = true;
            }
            else if(MainWindow.levelAccept == 1)
            {
                Name.Text = MainWindow.name;
                SecondName.Text = MainWindow.secondName;
                LastName.Text = MainWindow.lastName;
                Number.Text = MainWindow.number;
                Pasport.Text = MainWindow.pasport;
               
            }

            

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            GetWindow(this).Close();
        }

        private void Save_Parametrs_Click(object sender, RoutedEventArgs e)
        {
            newName = Name.Text;
            newSecondName = SecondName.Text;
            newLastName = LastName.Text;
            newPasport = Pasport.Text;
            newNumber = Number.Text;
            if(newNumber == "")
            {
                lebelError.Content = "Заполните поле Номер";
            }
            else if(newNumber != null)
            {
                
                DialogResult = true;
                GetWindow(this).Close();
            }
            
        }

        
    }
}
