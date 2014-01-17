using System;
using System.Collections.Generic;
using System.IO;
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

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PreferenceUtilisateur _preferenceUtilisateur;

        private string currentUser;

        public MainWindow(string inLogin)
        {
            InitializeComponent();

            currentUser = inLogin;
            _preferenceUtilisateur = new PreferenceUtilisateur();
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            if (File.Exists(currentUser + ".xml"))
            {
                _preferenceUtilisateur.Login = currentUser;
                _preferenceUtilisateur.Load();
                this.Height = _preferenceUtilisateur.HeightWindow;
                this.Width = _preferenceUtilisateur.WidthWindow;
                this.Top = _preferenceUtilisateur.TopWindow;
                this.Left = _preferenceUtilisateur.LeftWindow;
            }

            base.OnSourceInitialized(e);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            _preferenceUtilisateur.Login = currentUser;
            _preferenceUtilisateur.WidthWindow = this.ActualWidth;
            _preferenceUtilisateur.HeightWindow = this.ActualHeight;
            _preferenceUtilisateur.TopWindow = this.Top;
            _preferenceUtilisateur.LeftWindow = this.Left;
            _preferenceUtilisateur.Save();
            
            base.OnClosing(e);
        }

        protected void onClickCoupesButton(object sender, RoutedEventArgs e)
        {
            ListeDesCoupes ldc = new ListeDesCoupes();
            ldc.Show();
        }

        protected void onClickJoueursButton(object sender, RoutedEventArgs e)
        {
            ListeDesJoueurs ldj = new ListeDesJoueurs();
            ldj.Show();
        }
    }
}
