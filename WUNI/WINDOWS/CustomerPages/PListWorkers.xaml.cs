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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WUNI.Class;
using WUNI.DAOClass;
using WUNI.WINDOWS.UC;
namespace WUNI.WINDOWS.CustomerPages
{
    /// <summary>
    /// Interaction logic for PListWorkers.xaml
    /// </summary>
    public partial class PListWorkers : Page
    {
        private Field field;
        private List<Worker> workers;
        public PListWorkers()
        {
            InitializeComponent();
        }
        public PListWorkers(Field field)
        {
            InitializeComponent();
            
            this.field = field;
            WorkerDAO workerDAO = new WorkerDAO();
            this.workers = workerDAO.GetListWokerOfField(field.FieldID);
            foreach (var woker in workers)
            {
                UCWorkerCard uCWorkerCard = new UCWorkerCard(woker);
                ufgWorkers.Children.Add(uCWorkerCard);
            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ufgWorkers.Children.Clear();

            ComboBox comboBox = sender as ComboBox;
            var sortedWorker = this.workers;

            if (comboBox.SelectedIndex == 0)
            {
                sortedWorker = workers.OrderBy(worker => worker.PricePerHour).ToList();
            }
            else if (comboBox.SelectedIndex == 1)
            {
                sortedWorker = workers.OrderByDescending(worker => worker.PricePerHour).ToList();

            }
            else
            {
                sortedWorker = workers.OrderByDescending(worker => worker.Rating).ToList();
            }
            foreach (var woker in sortedWorker)
            {
                UCWorkerCard uCWorkerCard = new UCWorkerCard(woker);
                ufgWorkers.Children.Add(uCWorkerCard);
            }


        }
    }
}