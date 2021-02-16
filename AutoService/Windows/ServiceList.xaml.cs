using System;
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
using AutoService.EF;
using static AutoService.EF.AppData;



namespace AutoService
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class ServiceList : Window
    {
        List<Service> list = new List<Service>();
        int listCount;


        public ServiceList()
        { 
            InitializeComponent();
            list = context.Service.ToList();
            listCount = list.
                Count();

            listService.ItemsSource = context.Service.ToList();
        }

        private void cmbItemsOnList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var si = (ComboBoxItem)((ComboBox)sender).SelectedItem;
            
            if (si.Content.ToString() == "Все")
            {
                listCount=list.Count();
            }
            else{
                listCount = Convert.ToInt32(si.Content.ToString());
            }
            listService.ItemsSource = null;
            listService.ItemsSource = list.OrderBy(c => c.ID)
                .Take(listCount)
                .ToList();
        }


        
    }
}
