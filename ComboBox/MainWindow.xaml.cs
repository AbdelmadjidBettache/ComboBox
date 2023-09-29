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

namespace ComboBox
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Client> clients;
        public MainWindow()
        {
            InitializeComponent();
            clients = new List<Client>();
            clients.Add(new Client("123","Bob","Max"));
            clients.Add(new Client("456", "Alain", "Depuis"));
            clients.Add(new Client("789", "Abed", "Ali"));
            cbo.DataContext = clients;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            label.Content = ((Client)cbo.SelectedItem).Prenom;
        }
    }
}
