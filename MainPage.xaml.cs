
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
//using System.Windows.Forms.MessageBox.Show("Test");
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hangman
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        String b = "";
        String b1 = "";


        private void button_Click(object sender, RoutedEventArgs e)
        {

            String a = this.text.Text;
            //MessageBox.Show(a);
            // TextBox t = new TextBox();
            this.display.Text = "";
            int i; int c = 0; int o = 0; int x = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                    c++;
                else
                {
                    int flag = 0;
                    int j;
                    for (j = 0; j < 4; j++)
                    {
                        if (b[j] == a[i])
                            flag = 1;
                    }
                    if (flag == 0)
                        x++;
                    else
                        o++;
                }
            }
            String c1 = c.ToString();
            String c2 = o.ToString();
            String c3 = x.ToString();
            if (c == 4)
                this.display.Text = "You Win!";
            else
            this.display.Text = "c = " + c1 + "\no = " + c2 + "\nx = " + c3;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            b = this.passwordBox.Password;
            this.passwordBox.Password = "";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            b1 = this.passwordBox1.Password;
            this.passwordBox1.Password = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String a = this.textBox.Text;
            //MessageBox.Show(a);
            // TextBox t = new TextBox();
            this.display1.Text = "";
            int i; int c = 0; int o = 0; int x = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == b1[i])
                    c++;
                else
                {
                    int flag = 0;
                    int j;
                    for (j = 0; j < 4; j++)
                    {
                        if (b1[j] == a[i])
                            flag = 1;
                    }
                    if (flag == 0)
                        x++;
                    else
                        o++;
                }
            }
            String c1 = c.ToString();
            String c2 = o.ToString();
            String c3 = x.ToString();
            if (c == 4)
                this.display1.Text = "You Win!";
            else
                this.display1.Text = "c = " + c1 + "\no = " + c2 + "\nx = " + c3;

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string)
            {
               this.textBox1.Text = "Hi, " + e.Parameter.ToString();
            }
            else
            {
                this.textBox1.Text = "Hi!";
            }
            base.OnNavigatedTo(e);
        }
    }
}
