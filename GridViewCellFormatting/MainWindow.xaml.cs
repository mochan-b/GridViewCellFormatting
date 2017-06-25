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

namespace GridViewCellFormatting
{
    public class MyData
    {
        public int data1 { get; set; }
        public int data2 { get; set; }
        public int data3 { get; set; }

        public int sum { get => data1 + data2 + data3; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<MyData> data { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            data = new ObservableCollection<MyData>();
            data.Add(new MyData { data1 = 1, data2 = 2, data3 = 3 });
            data.Add(new MyData { data1 = 5, data2 = 6, data3 = 7 });
            data.Add(new MyData { data1 = 10, data2 = 7, data3 = 4 });
        }
    }
}
