using plannificationCours.back.data.dto;
using plannificationCours.back.data.entities;
using plannificationCours.presenter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace plannificationCours.front.views.impl
{
    /// <summary>
    /// Logique d'interaction pour SalleView.xaml
    /// </summary>
    public partial class SalleView : Window,ISalleView
    {
        private bool isEdit = false;
        private bool isSuccessfull = false;
        private string message;
        private static SalleView instance = null;
        


        private SalleView()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closing;
            this.WindowStyle = WindowStyle.None;

            ActiveEvent();          
        }
        public static SalleView GetInstance(MenuFormView parent)
        {
            if(instance == null)
            {
                instance = new SalleView();
                instance.Owner = parent;
            }
            return instance;

        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; // Annule la fermeture de la fenêtre
            this.Hide(); // Cache la fenêtre
        }

        public string Message { get => message; set => message = value; }
        public bool IsEdit { get => isEdit; set =>isEdit = value; }
        public bool IsSuccessfull { get =>isSuccessfull; set => isSuccessfull = value; }
        public int SalleId { get => int.Parse(salleId.Text); set => salleId.Text = value.ToString(); }
        public string salleName { get => inputSalleName.Text; set => throw new NotImplementedException(); }
 

        public event EventHandler clickBtnAddEvent;
        public event EventHandler clickBtnDelEvent;
        public event EventHandler clickBtnUpEvent;
        public event EventHandler SelectSalleEvent;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void SetBindingSource(ObservableCollection<SalleDto> salleList)
        {
         
            dgvSalle.ItemsSource = salleList;     
            
        }
        private void ActiveEvent()
        {
            btnAddSalle.Click += delegate
            {
                clickBtnAddEvent.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            btnDelSalle.Click += delegate
            {
                clickBtnDelEvent.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            btnUpSalle.Click += delegate
            {
                clickBtnUpEvent.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            dgvSalle.SelectionChanged += delegate
            {
                SelectSalleEvent.Invoke(this, EventArgs.Empty);
            };
        }

        public void ShowForm()
        {
            Show();
        }

        public void HideForm()
        {
           Hide();
        }
    }
}
