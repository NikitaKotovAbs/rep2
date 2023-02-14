using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
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

namespace крестикинолики
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int player;
        public MainWindow()
        {
            InitializeComponent();
            player = 1;
            label.Content = "Сейчас ходит первый игрок";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
                    sender.GetType().GetProperty("Content").SetValue(sender, "x");
                    player = 0;
                    label.Content = "Сейчас ходит второй игрок";
                    break;
                case 0:
                    sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
                    sender.GetType().GetProperty("Content").SetValue(sender, "0");
                    player = 1;
                    label.Content = "Сейчас ходит первый игрок";
                    break;
                default:
                    break;
            }
            checkwin();

            /*MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString());*/
        }
        private void reset()
        {

        }
        private void checkwin()
        {
            /*while (MessageBox.Show("Вы победили") == ) { }*/
            if (_1.IsEnabled == false && _2.IsEnabled == false && _3.IsEnabled == false && _4.IsEnabled == false && _5.IsEnabled == false && _6.IsEnabled == false && _7.IsEnabled == false && _8.IsEnabled == false && _9.IsEnabled == false)
            {
                MessageBox.Show("Ничья");
                _1.Content = null;
                _2.Content = null;
                _3.Content = null;
                _4.Content = null;
                _5.Content = null;
                _6.Content = null;
                _7.Content = null;
                _8.Content = null;
                _9.Content = null;
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                Start.IsEnabled = true;
                Reset.IsEnabled = false;
            }
            else
            if (_1.Content == "x" && _2.Content == "x" && _3.Content == "x" || _1.Content == "0" && _2.Content == "0" && _3.Content == "0")
                {
                    MessageBox.Show("Вы победили");
                    _1.Content = null;
                    _2.Content = null;
                    _3.Content = null;
                    _4.Content = null;
                    _5.Content = null;
                    _6.Content = null;
                    _7.Content = null;
                    _8.Content = null;
                    _9.Content = null;
                    _1.IsEnabled = false;
                    _2.IsEnabled = false;
                    _3.IsEnabled = false;
                    _4.IsEnabled = false;
                    _5.IsEnabled = false;
                    _6.IsEnabled = false;
                    _7.IsEnabled = false;
                    _8.IsEnabled = false;
                    _9.IsEnabled = false;
                    Start.IsEnabled = true;
                    Reset.IsEnabled = false;
                }
                else
                if (_4.Content == "x" && _5.Content == "x" && _6.Content == "x" || _4.Content == "0" && _5.Content == "0" && _6.Content == "0")
                {
                    MessageBox.Show("Вы победили");
                    _1.Content = null;
                    _2.Content = null;
                    _3.Content = null;
                    _4.Content = null;
                    _5.Content = null;
                    _6.Content = null;
                    _7.Content = null;
                    _8.Content = null;
                    _9.Content = null;
                    _1.IsEnabled = false;
                    _2.IsEnabled = false;
                    _3.IsEnabled = false;
                    _4.IsEnabled = false;
                    _5.IsEnabled = false;
                    _6.IsEnabled = false;
                    _7.IsEnabled = false;
                    _8.IsEnabled = false;
                    _9.IsEnabled = false;
                    Start.IsEnabled = true;
                    Reset.IsEnabled = false;
                }
                else
                if (_7.Content == "x" && _8.Content == "x" && _9.Content == "x" || _7.Content == "0" && _8.Content == "0" && _9.Content == "0")
                {
                    MessageBox.Show("Вы победили");
                    _1.Content = null;
                    _2.Content = null;
                    _3.Content = null;
                    _4.Content = null;
                    _5.Content = null;
                    _6.Content = null;
                    _7.Content = null;
                    _8.Content = null;
                    _9.Content = null;
                    _1.IsEnabled = false;
                    _2.IsEnabled = false;
                    _3.IsEnabled = false;
                    _4.IsEnabled = false;
                    _5.IsEnabled = false;
                    _6.IsEnabled = false;
                    _7.IsEnabled = false;
                    _8.IsEnabled = false;
                    _9.IsEnabled = false;
                    Start.IsEnabled = true;
                    Reset.IsEnabled = false;
                }
                else
                if (_1.Content == "x" && _5.Content == "x" && _9.Content == "x" || _1.Content == "0" && _5.Content == "0" && _9.Content == "0")
                {
                    MessageBox.Show("Вы победили");
                    _1.Content = null;
                    _2.Content = null;
                    _3.Content = null;
                    _4.Content = null;
                    _5.Content = null;
                    _6.Content = null;
                    _7.Content = null;
                    _8.Content = null;
                    _9.Content = null;
                    _1.IsEnabled = false;
                    _2.IsEnabled = false;
                    _3.IsEnabled = false;
                    _4.IsEnabled = false;
                    _5.IsEnabled = false;
                    _6.IsEnabled = false;
                    _7.IsEnabled = false;
                    _8.IsEnabled = false;
                    _9.IsEnabled = false;
                    Start.IsEnabled = true;
                    Reset.IsEnabled = false;
                }
                else
                if (_3.Content == "x" && _5.Content == "x" && _7.Content == "x" || _3.Content == "0" && _5.Content == "0" && _7.Content == "0")
                {
                    MessageBox.Show("Вы победили");
                    _1.Content = null;
                    _2.Content = null;
                    _3.Content = null;
                    _4.Content = null;
                    _5.Content = null;
                    _6.Content = null;
                    _7.Content = null;
                    _8.Content = null;
                    _9.Content = null;
                    _1.IsEnabled = false;
                    _2.IsEnabled = false;
                    _3.IsEnabled = false;
                    _4.IsEnabled = false;
                    _5.IsEnabled = false;
                    _6.IsEnabled = false;
                    _7.IsEnabled = false;
                    _8.IsEnabled = false;
                    _9.IsEnabled = false;
                    Start.IsEnabled = true;
                    Reset.IsEnabled = false;
                }
                else
                if (_1.Content == "x" && _4.Content == "x" && _7.Content == "x" || _1.Content == "0" && _4.Content == "0" && _7.Content == "0")
                {
                    MessageBox.Show("Вы победили");
                    _1.Content = null;
                    _2.Content = null;
                    _3.Content = null;
                    _4.Content = null;
                    _5.Content = null;
                    _6.Content = null;
                    _7.Content = null;
                    _8.Content = null;
                    _9.Content = null;
                    _1.IsEnabled = false;
                    _2.IsEnabled = false;
                    _3.IsEnabled = false;
                    _4.IsEnabled = false;
                    _5.IsEnabled = false;
                    _6.IsEnabled = false;
                    _7.IsEnabled = false;
                    _8.IsEnabled = false;
                    _9.IsEnabled = false;
                    Start.IsEnabled = true;
                    Reset.IsEnabled = false;
                }
                else
                if (_3.Content == "x" && _6.Content == "x" && _9.Content == "x" || _3.Content == "0" && _6.Content == "0" && _9.Content == "0")
                {
                    MessageBox.Show("Вы победили");
                    _1.Content = null;
                    _2.Content = null;
                    _3.Content = null;
                    _4.Content = null;
                    _5.Content = null;
                    _6.Content = null;
                    _7.Content = null;
                    _8.Content = null;
                    _9.Content = null;
                    _1.IsEnabled = false;
                    _2.IsEnabled = false;
                    _3.IsEnabled = false;
                    _4.IsEnabled = false;
                    _5.IsEnabled = false;
                    _6.IsEnabled = false;
                    _7.IsEnabled = false;
                    _8.IsEnabled = false;
                    _9.IsEnabled = false;
                    Start.IsEnabled = true;
                    Reset.IsEnabled = false;
                }
                if (_2.Content == "x" && _5.Content == "x" && _8.Content == "x" || _2.Content == "0" && _5.Content == "0" && _8.Content == "0")
                {
                    MessageBox.Show("Вы победили");
                    _1.Content = null;
                    _2.Content = null;
                    _3.Content = null;
                    _4.Content = null;
                    _5.Content = null;
                    _6.Content = null;
                    _7.Content = null;
                    _8.Content = null;
                    _9.Content = null;
                    _1.IsEnabled = false;
                    _2.IsEnabled = false;
                    _3.IsEnabled = false;
                    _4.IsEnabled = false;
                    _5.IsEnabled = false;
                    _6.IsEnabled = false;
                    _7.IsEnabled = false;
                    _8.IsEnabled = false;
                    _9.IsEnabled = false;
                    Start.IsEnabled = true;
                    Reset.IsEnabled = false;
                }

        }
        private void Name_click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _1.Content = null;
            _2.Content = null;
            _3.Content = null;
            _4.Content = null;
            _5.Content = null;
            _6.Content = null;
            _7.Content = null;
            _8.Content = null;
            _9.Content = null;
            _1.IsEnabled = true;
            _2.IsEnabled = true;
            _3.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;
            _9.IsEnabled = true;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            _1.IsEnabled = true;
            _2.IsEnabled = true;
            _3.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;
            _9.IsEnabled = true;
            Start.IsEnabled = false;
            Reset.IsEnabled = true;
        }
    }
}
