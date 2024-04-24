using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Rejestracja_JK
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _nazwaUzytkownika;
        private string _adresEmail;
        private string _haslo;
        private string _informacjeRejestracji;
        private string _wynikRejestracji;

        public string NazwaUzytkownika
        {
            get { return _nazwaUzytkownika; }
            set { _nazwaUzytkownika = value; OnPropertyChanged(); }
        }

        public string AdresEmail
        {
            get { return _adresEmail; }
            set { _adresEmail = value; OnPropertyChanged(); }
        }

        public string Haslo
        {
            get { return _haslo; }
            set { _haslo = value; OnPropertyChanged(); }
        }

        public string InformacjeRejestracji
        {
            get { return _informacjeRejestracji; }
            set { _informacjeRejestracji = value; OnPropertyChanged(); }
        }

        public string WynikRejestracji
        {
            get { return _wynikRejestracji; }
            set { _wynikRejestracji = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void PrzyciskZarejestruj_Click(object sender, RoutedEventArgs e)
        {
            WynikRejestracji = $"Dane użytkownika: \nNazwa użytkownika: {NazwaUzytkownika} \nAdres e-mail: {AdresEmail}";
        }


        private void ZmienioneHaslo(object sender, RoutedEventArgs e)
        {
            Haslo = (sender as PasswordBox).Password;
        }
    }
}
