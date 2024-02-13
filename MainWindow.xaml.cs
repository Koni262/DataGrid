using System;
using System.Collections.ObjectModel;
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

namespace DataGrid
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Brotherhood> knigths = new ObservableCollection<Brotherhood>();

            //Create DataGrid Items Info
            knigths.Add(new Brotherhood { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Carac the Valiant", Position = "Knight", Email = "Carac.Valiant@gmail.com", Phone = "+13473169708" });
            knigths.Add(new Brotherhood { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Dicky the Faithful", Position = "Commander", Email = "Dicky.Faithful@gmail.com", Phone = "+13418229354" });
            knigths.Add(new Brotherhood { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Conan the Brave", Position = "Knight", Email = "Conan.Brave@gmail.com", Phone = "+12053991236" });
            knigths.Add(new Brotherhood { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Niel of the East", Position = "Knight", Email = "Neil.East@gmail.com", Phone = "+12537123847" });
            knigths.Add(new Brotherhood { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Bernier the Tenacious", Position = "Trainee", Email = "Bernier.Tenacious@gmail.com", Phone = "+18205925748" });
            knigths.Add(new Brotherhood { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "Heimart the Warm", Position = "Kngiht", Email = "Heimart.Warm@gmail.com", Phone = "+18544604901" });
            knigths.Add(new Brotherhood { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Frank the Patrol", Position = "Commander", Email = "Frank.Patrol@gmail.com", Phone = "+16676605204" });
            knigths.Add(new Brotherhood { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Wilkie the Rude", Position = "Knight", Email = "Wilkie.Rude@gmail.com", Phone = "+15345428426" });
            knigths.Add(new Brotherhood { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Mainfridus the Shadow", Position = "", Email = "Mainfridus.Shadow@gmail.com", Phone = "+18034509062" });
            knigths.Add(new Brotherhood { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Mosse the Smile", Position = "Trainee", Email = "Mosse.Smile@gmail.com", Phone = "+12488118268" });

           KnightsDataGrid.ItemsSource = knigths;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                  

                    IsMaximized = false;
                }
            }
        }
    }

    public class Brotherhood
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
        public string Name { get;  set; }
    }

}
