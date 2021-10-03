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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
           
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //Select * From TypeOfCars
            //var cars = _db.TypesOfCars.ToList();

            //Select id as CarId, name as CarName from TypesOfCars
            //var cars = _db.TypesOfCars
            //    .Select(q => new { CarId = q.Id, CarName = q.Make})
            //    .ToList();

            try
            {
                PopulateGrid();
            }

            catch (Exception ex) {                
                MessageBox.Show(ex.Message);
        }

            //    gvVehicleList.Columns[0].HeaderText = "ID";
            //   gvVehicleList.Columns[1].HeaderText = "NAME";
        }
        public void PopulateGrid() {

            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    q.Make,
                    q.Model,
                    q.VIN,
                    q.Year,
                    q.LicensePlateNumber,
                    q.Id
                })
                .ToList();

            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            //My code (his didnt work :\)
            try { 
                int selectedrowindex = gvVehicleList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gvVehicleList.Rows[selectedrowindex];
                var id = (int)selectedRow.Cells["Id"].Value;
                //My code (his didnt work :\)

                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                var addEditVehicle = new AddEditVehicle(car, this);

                if (!Utils.FormIsOpen("AddEditVehicle"))
                {
                    addEditVehicle.MdiParent = this.MdiParent;
                    addEditVehicle.Show();
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
}

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {

                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Delete", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    _db.TypesOfCars.Remove(car);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}
