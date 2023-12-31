﻿using ScottPlot;
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
using System.Windows.Shapes;

namespace stalcraft_observer
{
    /// <summary>
    /// Логика взаимодействия для ShowRequest.xaml
    /// </summary>
    public partial class ShowRequest : Window
    {
        public ShowRequest(List<Prices> prices)
        {
            InitializeComponent();



            List<double> values = new List<double>();
            List<dynamic> list = new List<dynamic>();  

            foreach (var value in prices)
            {
                values.Add(value.Price);

                list.Add(new { Amount = value.Amount, Price = value.Price, Time = value.Time});    
            }
            
            DataGrid.ItemsSource = list; 
            Chart.Plot.AddBar(values.ToArray());

            //Chart.Plot.SetAxisLimits(yMin: 0);
            Chart.Refresh();
        }
    }
}
