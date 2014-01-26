﻿using System;
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
using System.Windows.Shapes;

using BusinessLayer;
using EntitiesLayer;
using System.Collections.ObjectModel;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour GestionReservation.xaml
    /// </summary>
    public partial class GestionReservation : Window
    {
        protected PreferenceUtilisateur _preferenceUtilisateur;
        protected GestionReservationViewModel _reservations;
        protected CoupeManager cp;
        protected List<Coupe> _listCoupes;

        public GestionReservation(PreferenceUtilisateur prefUser)
        {
            InitializeComponent();

            _preferenceUtilisateur = prefUser;
            cp = new CoupeManager();

            _listCoupes = cp.GetCoupes();

            _reservations = new GestionReservationViewModel(new ObservableCollection<Reservation>(cp.GetReservations()));
            userCtrl.comboCoupes.ItemsSource = _listCoupes;

            listViewReservations.DataContext = _reservations.Reservations;

            if (_reservations.Reservations.Count > 0)
            {
                userCtrl.DataContext = _reservations.Reservations[0];
            }

            if(_listCoupes.Count > 0)
                userCtrl.comboMatchs.ItemsSource = cp.GetListeMatchsCoupe(_listCoupes[0].Id);
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            if (File.Exists(_preferenceUtilisateur.Login + ".xml"))
            {
                _preferenceUtilisateur.Load();

                if (_preferenceUtilisateur.HeightWindowReservations != 0 && _preferenceUtilisateur.WidthWindowReservations != 0)
                {
                    this.Height = _preferenceUtilisateur.HeightWindowReservations;
                    this.Width = _preferenceUtilisateur.WidthWindowReservations;
                    this.Top = _preferenceUtilisateur.TopWindowReservations;
                    this.Left = _preferenceUtilisateur.LeftWindowReservations;
                }
                else
                {
                    this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                }
            }

            base.OnSourceInitialized(e);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            _preferenceUtilisateur.WidthWindowReservations = this.ActualWidth;
            _preferenceUtilisateur.HeightWindowReservations = this.ActualHeight;
            _preferenceUtilisateur.TopWindowReservations = this.Top;
            _preferenceUtilisateur.LeftWindowReservations = this.Left;
            _preferenceUtilisateur.Save();

            base.OnClosing(e);
        }

        private void onClickListview(object sender, SelectionChangedEventArgs e)
        {
            userCtrl.DataContext = listViewReservations.SelectedItem;
        }
    }
}