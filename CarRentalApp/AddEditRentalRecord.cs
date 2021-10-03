using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _db;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            titleLabel.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;
            _db = new CarRentalEntities();
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit) {
            InitializeComponent();
            titleLabel.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit.");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbCustomerName.Text = recordToEdit.CustomerName;
            dateRented.Value = (DateTime)recordToEdit.DateRented;
            dateReturned.Value =(DateTime)recordToEdit.DateReturned;
            tbCost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string customerName = tbCustomerName.Text;
                var dtRented = dateRented.Value;
                var dtReturned = dateReturned.Value;
                double cost = Convert.ToDouble(tbCost.Text);

                var car = carType.Text;
                var isValid = true;

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerName))
                {
                    isValid = false;
                    MessageBox.Show($"Please enter missing data.\n\r");
                }

                if (dtRented > dtReturned)
                {
                    isValid = false;
                    MessageBox.Show("Illegal Date Selection");
                }

                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();

                    if (isEditMode)
                    {
                        var id = int.Parse(lblRecordId.Text);
                        rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                    }
                        rentalRecord.CustomerName = customerName;
                        rentalRecord.DateRented = dtRented;
                        rentalRecord.DateReturned = dtReturned;
                        rentalRecord.Cost = (decimal)cost;
                        rentalRecord.TypeOfCarId = (int)carType.SelectedValue;
                        
                        
                    if(!isEditMode)
                        _db.CarRentalRecords.Add(rentalRecord);
                        
                    _db.SaveChanges();

                    MessageBox.Show($"Customer Name: {customerName}\n\r" +
                    $"Date Rented: {dtRented}\n\r" +
                    $"Date Returned: {dtReturned}\n\r" +
                    $"Cost: {cost}\n\r" +
                    $"Car Type: {car} \n\r" +
                    $"THANK YOU FOR YOUR BUSINESS");
                    
                    Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Select * from TypesOfCars
            var cars = _db.TypesOfCars
                .Select(q => new { Id = q.Id, Name = q.Make + " " + q.Model})
                .ToList();

            carType.DisplayMember = "Name";
            carType.ValueMember = "Id";
            carType.DataSource = cars;
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
