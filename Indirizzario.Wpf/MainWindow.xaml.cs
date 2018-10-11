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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Indirizzario.Wpf
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
            ServiceReference.ComClient cc= new ServiceReference.ComClient();

            ServiceReference.Person person = new ServiceReference.Person
            {
                FirstName = tbFirstName.Text,
                LastName = tblastName.Text,
                Gender = "Maschio"
            };

            cc.AddPerson(person);
            
        }
    }
}
