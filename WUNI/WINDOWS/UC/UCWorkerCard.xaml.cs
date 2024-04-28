﻿using System;
using System.Collections.Generic;
using System.IO;
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
using WUNI.Class;

namespace WUNI.WINDOWS.UC
{
    /// <summary>
    /// Interaction logic for UCWorkerCard.xaml
    /// </summary>
    public partial class UCWorkerCard : UserControl
    {
        private String workerID;
        public UCWorkerCard()
        {
            InitializeComponent();
        }
        public UCWorkerCard(Worker worker)
        {
            InitializeComponent();

            string path = Environment.CurrentDirectory;
            string path1 = Directory.GetParent(path).Parent.Parent.FullName;
            this.workerID = worker.WorkerID;
            workerName.Text = worker.Name.ToString();
            workerRating.Text = "Đánh giá: " + worker.Rating.ToString();
            workerAddress.Text = "Địa chỉ: " + worker.Address.ToString();
            lblPhoneNumber.Text ="Số điện thoại: " +  worker.PhoneNumber.ToString();
            imgProfile.ImageSource = new BitmapImage(new Uri(path1 + "\\WorkerImage\\" + worker.WorkerID.ToString() + ".png")); 
            workerPrice.Text = worker.PricePerHour.ToString() + "k /Giờ";
        }
        private void btnMore_Click(object sender, RoutedEventArgs e)
        {
            WCustomerMain wCustomerMain = (WCustomerMain)Window.GetWindow(this);
            MessageBox.Show(wCustomerMain.CustomerID);
            WWorkerDetails workerDetails = new WWorkerDetails(wCustomerMain.CustomerID, this.workerID);
            workerDetails.Show();
            
        }
    }
}
