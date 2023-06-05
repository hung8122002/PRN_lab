﻿using System;
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

namespace SalesWpfApp.Component
{
    /// <summary>
    /// Interaction logic for BindablePasswordBoxxaml.xaml
    /// </summary>
    public partial class BindablePasswordBoxxaml : UserControl
    {
        public static readonly DependencyProperty PasswordProperty = DependencyProperty.Register("Password", typeof(string), typeof(BindablePasswordBoxxaml), new PropertyMetadata(string.Empty));
        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public BindablePasswordBoxxaml()
        {
            InitializeComponent();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = passwordBox.Password;
        }
    }
}
