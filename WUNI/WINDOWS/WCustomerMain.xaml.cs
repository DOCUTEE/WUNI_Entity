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
using System.Windows.Shapes;

namespace WUNI.WINDOWS
{
    /// <summary>
    /// Interaction logic for WCustomerMain.xaml
    /// </summary>
    public partial class WCustomerMain : Window
    {
        private string workerID;
        public WCustomerMain()
        {
            InitializeComponent();
        }
        public WCustomerMain(string workerID)
        {
            InitializeComponent();
            this.workerID = workerID;
        }
    }
}