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

namespace Zadatak08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string trenutniNaziv = "greenBrush";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.trenutniNaziv == "greenBrush")
            {
                this.trenutniNaziv = "redBrush";
            }
            else
            {
                this.trenutniNaziv = "greenBrush";
            }

            RadialGradientBrush brush = (RadialGradientBrush)this.FindResource(this.trenutniNaziv);

            this.btn1.Background = brush;
            this.btn2.Background = brush;
            this.btn3.Background = brush;
        }
    }
}