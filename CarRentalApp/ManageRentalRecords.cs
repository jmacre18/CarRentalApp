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
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities _db;

        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord
            {
                MdiParent = this.MdiParent
            };
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;

                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                var addEditRentalRecord = new AddEditRentalRecord(record);
                addEditRentalRecord.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {

                var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Delete",
                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    _db.CarRentalRecords.Remove(record);
                    _db.SaveChanges();
                }

                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateGrid() {
            var records = _db.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.id,
                q.Cost,
                Car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model

            }).ToList();

            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateIn"].HeaderText = "Date In";
            gvRecordList.Columns["DateOut"].HeaderText = "Date Out";

            gvRecordList.Columns["Id"].Visible = false;
        }
    }
}
