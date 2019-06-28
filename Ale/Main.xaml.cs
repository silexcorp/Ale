using Ale.func;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Ale {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Main: Window {

        /* KEY LISTENER */
        private LowLevelKeyboardListener _listener;
        WMPLib.WindowsMediaPlayer audio;

        public Main() {
            InitializeComponent();
        }

        void close() {
            App.Current.Shutdown();     //Para cerrar la aplicación
            _listener.UnHookKeyboard(); //Parar key listener
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            /* Inicializar key listener */
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;
            _listener.HookKeyboard();

            audio = new WMPLib.WindowsMediaPlayer();

        }

        String texto;
        void _listener_OnKeyPressed(object sender, KeyPressedArgs e) {
            //MessageBox.Show(e.KeyPressed.ToString());
            if(!e.KeyPressed.ToString().Equals("Space") & !e.KeyPressed.ToString().Equals("Return")) {
                if(!e.KeyPressed.ToString().Equals("Return") &
                    !e.KeyPressed.ToString().Equals("LeftShift") &
                    !e.KeyPressed.ToString().Equals("LeftCtrl") &
                    !e.KeyPressed.ToString().Equals("LeftAlt") &
                    !e.KeyPressed.ToString().Equals("Space") &
                    !e.KeyPressed.ToString().Equals("RightShift") &
                    !e.KeyPressed.ToString().Equals("RightCtrl") &
                    !e.KeyPressed.ToString().Equals("RightAlt") &
                    !e.KeyPressed.ToString().Equals(" ") &
                    !e.KeyPressed.ToString().Equals("AltGr") &
                    !e.KeyPressed.ToString().Equals("Oem1") &
                    !e.KeyPressed.ToString().Equals("OemComma") &
                    !e.KeyPressed.ToString().Equals("Back") &
                    !e.KeyPressed.ToString().Equals("OemPeriod"))
                    texto += e.KeyPressed.ToString();
                
                string path = AppDomain.CurrentDomain.BaseDirectory;

                if (e.KeyPressed.ToString().Equals("A")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("B")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("C")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("D")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("E")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("F")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("G")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("H")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("I")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("J")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("K")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("L")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("M")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("N")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("Oem3")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("O")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("P")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("Q")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("R")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("S")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("T")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("U")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("V")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("W")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("X")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("Y")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }
                if (e.KeyPressed.ToString().Equals("Z")) { audio.URL = path + @"\source\mp3\okan.mp3"; audio.controls.play(); TheEnclosingMethod("img_corazon.png"); }

                if (e.KeyPressed.ToString().Equals("D0")) { audio.URL = path + @"\source\mp3\0.mp3"; audio.controls.play(); TheEnclosingMethod("img_10.png"); }
                if(e.KeyPressed.ToString().Equals("D1")) { audio.URL = path + @"\source\mp3\1.mp3"; audio.controls.play(); TheEnclosingMethod("img_1.png"); }
                if(e.KeyPressed.ToString().Equals("D2")) { audio.URL = path + @"\source\mp3\2.mp3"; audio.controls.play(); TheEnclosingMethod("img_2.png"); }
                if(e.KeyPressed.ToString().Equals("D3")) { audio.URL = path + @"\source\mp3\3.mp3"; audio.controls.play(); TheEnclosingMethod("img_3.png"); }
                if(e.KeyPressed.ToString().Equals("D4")) { audio.URL = path + @"\source\mp3\4.mp3"; audio.controls.play(); TheEnclosingMethod("img_4.png"); }
                if(e.KeyPressed.ToString().Equals("D5")) { audio.URL = path + @"\source\mp3\5.mp3"; audio.controls.play(); TheEnclosingMethod("img_5.png"); }
                if(e.KeyPressed.ToString().Equals("D6")) { audio.URL = path + @"\source\mp3\6.mp3"; audio.controls.play(); TheEnclosingMethod("img_6.png"); }
                if(e.KeyPressed.ToString().Equals("D7")) { audio.URL = path + @"\source\mp3\7.mp3"; audio.controls.play(); TheEnclosingMethod("img_7.png"); }
                if(e.KeyPressed.ToString().Equals("D8")) { audio.URL = path + @"\source\mp3\8.mp3"; audio.controls.play(); TheEnclosingMethod("img_8.png"); }
                if(e.KeyPressed.ToString().Equals("D9")) { audio.URL = path + @"\source\mp3\9.mp3"; audio.controls.play(); TheEnclosingMethod("img_9.png"); }

                texto = "";

            } else {

            }
            
            //if (Keys.F1.ToString() == e.KeyPressed.ToString() && Keys.Control == System.Windows.Forms.Control.ModifierKeys)
        }

        public async void TheEnclosingMethod(string image)
        {
            this.main_grid.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Ale;component/source/img/" + image, UriKind.Absolute)) };
            this.main_grid.Stretch = Stretch.UniformToFill;
            this.main_grid.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            this.main_grid.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            main_grid.Visibility = Visibility.Visible;
            await Task.Delay(800);
            main_grid.Visibility = Visibility.Hidden;
        }
    }
}
