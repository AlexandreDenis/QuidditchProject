﻿#pragma checksum "..\..\ListeDesCoupes.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "129EAB98457E9CF160EDE2E04CC57881"
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
    /// ListeDesCoupes
    /// </summary>
    public partial class ListeDesCoupes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\ListeDesCoupes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxCoupes;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ListeDesCoupes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Annee;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ListeDesCoupes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputAnnee;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ListeDesCoupes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Libelle;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ListeDesCoupes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputLibelle;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ListeDesCoupes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Supprimer;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ListeDesCoupes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Modifier;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ListeDesCoupes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ajouter;
        
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
            System.Uri resourceLocater = new System.Uri("/QuidditchWPF;component/listedescoupes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListeDesCoupes.xaml"
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
            this.ListBoxCoupes = ((System.Windows.Controls.ListBox)(target));
            
            #line 8 "..\..\ListeDesCoupes.xaml"
            this.ListBoxCoupes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.onClickListBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Annee = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.inputAnnee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Libelle = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.inputLibelle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Supprimer = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Modifier = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Ajouter = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

