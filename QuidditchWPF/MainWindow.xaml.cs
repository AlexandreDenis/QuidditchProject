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

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         private PreferenceUtilisateur _preferenceUtilisateur;

         public MainWindow()
        {
            InitializeComponent();

            _preferenceUtilisateur = new PreferenceUtilisateur();

            _preferenceUtilisateur.Login = "Toto";
            _preferenceUtilisateur.Load();
            this.Height = _preferenceUtilisateur.HeightWindow;
            this.Width = _preferenceUtilisateur.WidthWindow;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (_preferenceUtilisateur != null)
            {
                _preferenceUtilisateur.Login = "Toto";
                _preferenceUtilisateur.WidthWindow = this.ActualWidth;
                _preferenceUtilisateur.HeightWindow = this.ActualHeight;
                _preferenceUtilisateur.Save();
            }

            base.OnClosing(e);
        }
    }
}
