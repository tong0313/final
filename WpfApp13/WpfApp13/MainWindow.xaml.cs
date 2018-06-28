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

namespace WpfApp13
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        //設定隊伍顏色
        private void RED_Click(object sender, RoutedEventArgs e)
        {

            TeamA.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA65555"));
            PointA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFCFA3A3"));
            ColorA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA65555"));
            PPontA.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboA.IsDropDownOpen = false;


        }
        //設定隊伍顏色
        private void BlackA_Click(object sender, RoutedEventArgs e)
        {

            TeamA.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            PointA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF222229"));
            ColorA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            PPontA.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFE2E2E2"));
            //關閉Combo清單
            ComboA.IsDropDownOpen = false;

        }
        //設定隊伍顏色
        private void BlueA_Click(object sender, RoutedEventArgs e)
        {

            TeamA.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFC77BAB"));
            PointA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFEECFE2"));
            ColorA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFC77BAB"));
            PPontA.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboA.IsDropDownOpen = false;

        }
        //設定隊伍顏色
        private void GreenA_Click(object sender, RoutedEventArgs e)
        {

            TeamA.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF528857"));
            PointA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFB2D3B6"));
            ColorA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF528857"));
            PPontA.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboA.IsDropDownOpen = false;

        }
        //設定隊伍顏色
        private void OrangeA_Click(object sender, RoutedEventArgs e)
        {

            TeamA.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF3CD68"));
            PointA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFDE9B6"));
            ColorA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF3CD68"));
            PPontA.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboA.IsDropDownOpen = false;


        }
        //設定隊伍顏色
        private void WhiteA_Click(object sender, RoutedEventArgs e)
        {

            TeamA.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF9FBFD"));
            PointA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFE2E2E2"));
            ColorA.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF9FBFD"));
            PPontA.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboA.IsDropDownOpen = false;

        }
        //設定隊伍顏色
        private void RedB_Click(object sender, RoutedEventArgs e)
        {

            TeamB.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA65555"));
            PointB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFCFA3A3"));
            ColorB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFA65555"));
            PPontA.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboB.IsDropDownOpen = false;
        }
        //設定隊伍顏色
        private void BlackB_Click(object sender, RoutedEventArgs e)
        {

            TeamB.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            PointB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF222229"));
            ColorB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            PPontB.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFE2E2E2"));
            //關閉Combo清單
            ComboB.IsDropDownOpen = false;

        }
        //設定隊伍顏色
        private void BlueB_Click(object sender, RoutedEventArgs e)
        {
            TeamB.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFC77BAB"));
            PointB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFEECFE2"));
            ColorB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFC77BAB"));
            PPontB.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboB.IsDropDownOpen = false;
        }
        //設定隊伍顏色
        private void GreenB_Click(object sender, RoutedEventArgs e)
        {
            TeamB.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF528857"));
            PointB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFB2D3B6"));
            ColorB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF528857"));
            PPontA.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboB.IsDropDownOpen = false;
        }
        //設定隊伍顏色
        private void OrangeB_Click(object sender, RoutedEventArgs e)
        {
            TeamB.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF3CD68"));
            PointB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFDE9B6"));
            ColorB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF3CD68"));
            PPontB.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboB.IsDropDownOpen = false;
        }
        //設定隊伍顏色
        private void WhiteB_Click(object sender, RoutedEventArgs e)
        {
            TeamB.Background  = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF9FBFD"));
            PointB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFE2E2E2"));
            ColorB.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFF9FBFD"));
            PPontB.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF32353E"));
            //關閉Combo清單
            ComboB.IsDropDownOpen = false;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            double A = int.Parse(PPontA.Text);
            double B = int.Parse(PPontB.Text);
            double C = int.Parse(WinNumber.Text);
            //增加隊伍A 分數
            A += 1;            
            //設定賽末點條件
            if (A >= 24 && B <= A - 1)
            {
                //賽末點亮起
                Final.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFD4ECF3"));
                Deuce.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF6B878F"));
               //設定勝利條件
               if (A >= 25 && B <= A - 2)
               {
                    Final.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF6B878F"));
                    Deuce.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF6B878F"));
                    
                    Win.Background = ColorA.Background;
                   //增加勝場數
                    C += 1;
                    A = 0;
                    B = 0;

               }
            }
            //設定Deuce條件
            if (A >= 24 && B == A)
            {
                //Deuce亮起
                Deuce.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFD4ECF3"));
                Final.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF6B878F"));
            }
            string.Format("{0:00}", A);                        
            PPontA.Text = A.ToString("00");
            string.Format("{0:00}", B);
            PPontB.Text = B.ToString("00");
            WinNumber.Text = C.ToString();

        }
    
       
                private void Button_Click_1(object sender, RoutedEventArgs e)
         {

            double A = int.Parse(PPontA.Text);
            double B = int.Parse(PPontB.Text);
            double C = int.Parse(WinNumber.Text);
            //增加隊伍B分數
            B += 1;           
            //設定賽末點條件
            if (B >= 24 && A <= B - 1)
            {
                //賽末點亮起
                Final.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFD4ECF3"));
                Deuce.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF6B878F"));
                            
                //設定勝利條件
                if (B >= 25 && A <= B - 2)
                {                    
                    Final.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF6B878F"));
                    Deuce.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF6B878F"));

                    Win.Background = ColorB.Background;
                    //增加勝場數
                    C += 1;                    
                    A = 0;
                    B = 0;
                }
            }
            //設定Deuce條件
            if (B >= 24 && A == B)
           {
                //Deuce亮起
                Deuce.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFD4ECF3"));
                Final.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF6B878F"));
           }
            string.Format("{0:00}", B);            
            PPontB.Text = B.ToString("00");
            string.Format("{0:00}", A);            
            PPontA.Text = A.ToString("00");
            WinNumber.Text = C.ToString();

        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double B = int.Parse(PPontB.Text);
            double A = int.Parse(PPontA.Text);        

            //減少對伍A分數
            A -= 1;
            string.Format("{0:00}", A);
            PPontA.Text = A.ToString("00");
            string.Format("{0:00}", B);
            PPontB.Text = B.ToString("00");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double A = int.Parse(PPontA.Text);
            double B = int.Parse(PPontB.Text);

            //減少對伍B分數
            B -= 1;
            string.Format("{0:00}", B);
            PPontB.Text = B.ToString("00");
            string.Format("{0:00}", A);
            PPontA.Text = A.ToString("00");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double PLAY = int.Parse(Play.Text);

            //增加隊伍數量
            PLAY += 1;
            Play.Text = PLAY.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double PLAY = int.Parse(Play.Text);
            //減少對伍數量
            PLAY -= 1;
            Play.Text = PLAY.ToString();
        }
    }
}
