﻿#pragma checksum "..\..\ListeDesJoueurs.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D56DF4FDC7BD3D03514B83303753F4FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34003
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace QuidditchWPF {
    
    
    /// <summary>
    /// ListeDesJoueurs
    /// </summary>
    public partial class ListeDesJoueurs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxEquipes;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listviewEquipe;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputNom;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputPrenom;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputScore;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox inputPoste;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputSelections;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ajouter;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Modifier;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\ListeDesJoueurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Supprimer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuidditchWPF;component/listedesjoueurs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListeDesJoueurs.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.comboBoxEquipes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 8 "..\..\ListeDesJoueurs.xaml"
            this.comboBoxEquipes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.onComboBoxSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listviewEquipe = ((System.Windows.Controls.ListView)(target));
            
            #line 10 "..\..\ListeDesJoueurs.xaml"
            this.listviewEquipe.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.onListViewSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.inputNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.inputPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.inputScore = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.inputPoste = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.inputSelections = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Ajouter = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.Modifier = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.Supprimer = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

