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

namespace kalkulacka
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

        

        private double total1 = 0;
        private double total2 = 0;
        



        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "3";
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "4";
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "5";
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "6";
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "7";
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "8";
        }
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "9";
        }
       
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "0";
        }
        private void btnce_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text = "";
        }
        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text = "";
        }
       
        private void btnsq_Click(object sender, RoutedEventArgs e)
        {
            total1 = double.Parse(resultTxtBox.Text) * double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = total1.ToString();

           
        }
        private void btnZapor_Click(object sender, RoutedEventArgs e)
        {
            double cislo = double.Parse(resultTxtBox.Text);
            total1 =  cislo * (-1);
            resultTxtBox.Text = total1.ToString();
        }
        private void btnmazani_Click(object sender, RoutedEventArgs e)
        {
                    
        
        }







    }

}
