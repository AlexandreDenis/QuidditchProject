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

using BusinessLayer;
using EntitiesLayer;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour ListeDesJoueurs.xaml
    /// </summary>
    public partial class ListeDesJoueurs : Window
    {
        protected List<Equipe> _listEquipes;

        public ListeDesJoueurs()
        {
            InitializeComponent();

            CoupeManager cp = new CoupeManager();
            _listEquipes = cp.GetEquipes();

            comboBoxEquipes.ItemsSource = _listEquipes;
            inputPoste.ItemsSource = Enum.GetValues(typeof(PosteJoueur));

            if (_listEquipes.Count > 0)
            {
                listviewEquipe.DataContext = _listEquipes[0].Joueurs;
                comboBoxEquipes.SelectedItem = _listEquipes[0];
                this.DataContext = _listEquipes[0];
                Grid.DataContext = _listEquipes[0].Joueurs[0];
            }
        }

        protected void onComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.DataContext = comboBoxEquipes.SelectedItem;
            listviewEquipe.DataContext = _listEquipes[comboBoxEquipes.SelectedIndex].Joueurs;
            Grid.DataContext = _listEquipes[comboBoxEquipes.SelectedIndex].Joueurs[0];
        }

        protected void onListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Grid.DataContext = listviewEquipe.SelectedItem;
        }
    }
}
