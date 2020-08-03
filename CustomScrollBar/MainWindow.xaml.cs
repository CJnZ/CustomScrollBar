using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CustomScrollBar
{

    public class people
    {
        public string name { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string birthday { get; set; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        ObservableCollection<people> peopleList = new ObservableCollection<people>();

        public MainWindow()
        {
            InitializeComponent();
          //  this.LoadData(null, null);
        }
        private void LoadData(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; ++i)
            {
                peopleList.Add(new people()
                {
                    name = "小明",
                    age = "18",
                    sex = "男",
                    birthday = "1990-9-9"
                });
                peopleList.Add(new people()
                {
                    name = "小红",
                    age = "18",
                    sex = "女",
                    birthday = "1990-9-9"
                });
            }

            if((this.FindName("DATA_GRID") as DataGrid) != null)
            {
                DataGrid dg = new DataGrid();
                dg = (DataGrid)(this.FindName("DATA_GRID"));
                dg.ItemsSource = peopleList;
            }
           // ((this.FindName("DATA_GRID")) as DataGrid).ItemsSource = peopleList;
        }
    }
}
