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
    /// Logique d'interaction pour ListeDesCoupes.xaml
    /// </summary>
    public partial class ListeDesCoupes : Window
    {
        protected List<Coupe> _listCoupes;

        public ListeDesCoupes()
        {
            InitializeComponent();

            /*charge la liste des coupes*/
            CoupeManager cp = new CoupeManager();
            _listCoupes = cp.GetCoupes();

            /*on remplit la listbox des coupes*/
            ListBoxCoupes.ItemsSource = _listCoupes;
            this.DataContext = _listCoupes.First();
        }

        protected void onClickListBox(object sender, SelectionChangedEventArgs e)
        {
            this.DataContext = ListBoxCoupes.SelectedItem;
        }
    }
}
