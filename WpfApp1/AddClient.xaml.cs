using KursC_10_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    /// 
    public partial class AddClient : Window
    {

        public static string newName;
        public static string newSecondName;
        public static string newLastName;
        public static string newNumber;
        public static string newPasport;
        public AddClient()
        {
            InitializeComponent();
        }

        private void Save_Parametrs_Click(object sender, RoutedEventArgs e)
        {
            newName = Name.Text;
            newSecondName = SecondName.Text;
            newLastName = LastName.Text;
            newNumber = Number.Text;
            newPasport = Pasport.Text;
            if (newNumber == "" || newName ==""||newLastName==""||newSecondName==""||newPasport=="")
            {
                lebelError.Content = "Заполните все поля";
            }
            else 
            {

                DialogResult = true;
                GetWindow(this).Close();
            }
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            GetWindow(this).Close();
        }

       
    }
}
