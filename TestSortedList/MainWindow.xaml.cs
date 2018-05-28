using System;
using System.Collections;
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

namespace TestSortedList
{  

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private SortedList sl = new SortedList();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            sl.Add(DateTime.Now, DateTime.Now);
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (sl != null && sl.Count >0 )
            {
                // 获取键的集合 
                ICollection key = sl.Keys;

                Recheck:
                foreach (DateTime k in key)
                {
                    Console.WriteLine(k + ": " + sl[k]);
                    if ((DateTime) sl[k] < DateTime.Now.AddSeconds(-10))
                    {
                        sl.Remove(k);
                        goto Recheck;
                    }
                }
            }
        }
    }
}
