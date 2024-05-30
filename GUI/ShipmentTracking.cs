using ShipmentTracking.Data;
using ShipmentTracking.Entities;
using ShipmentTracking.Entities.ViewModels;
using ShipmentTracking.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShipmentTracking.GUI
{
    public partial class ShipmentTracking : Form
    {
        List<ShipmentViewModel> shipments;

        public ShipmentTracking()
        {
            InitializeComponent();
            optionsCB.SelectedIndex = 2;

            optionsCB.SelectedIndexChanged += new EventHandler(FilterData);
            monthComboBox.SelectedIndexChanged += new EventHandler(FilterData);
            nationalCheckBox.CheckedChanged += new EventHandler(FilterData);
            cuuCheckBox.CheckedChanged += new EventHandler(FilterData);

            LoadShipments();

            optionsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shipmentsDGV.ReadOnly = true;
            shipmentsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shipmentsDGV.MultiSelect = false;
        }

        public void LoadShipments()
        {
            using (var context = new ApplicationDbContext())
            {
                shipments = context.Shipments
                    .Select(s => new ShipmentViewModel
                    {
                        Id = s.Id,
                        CustomerName = s.CustomerId.Name,
                        DeliveryPlaceName = s.DeliveryPlaceId.Name,
                        Invoice = s.Invoice,
                        PurchaseOrder = s.PurchaseOrder,
                        PurchaseOrder2 = s.PurchaseOrder2,
                        MaterialDescription = s.MaterialDescriptionId.Description,
                        Quantity = s.Quantity,
                        InvoiceDate = s.InvoiceDate,
                        CarrierName = s.CarrierId.Name,
                        Bol = s.Bol,
                        DriverName = s.DriverId.Name,
                        PlatformBox = s.PlatformBoxId.Description,
                        ShipDate = s.ShipDate,
                        Quantity2 = s.Quantity2,
                        DeliveryDate = s.DeliveryDate,
                        IsProcessed = s.IsProcessed,
                        IsNational = s.IsNational,
                        Month = s.Month,
                        IsChihuahua = s.IsChihuahua
                    })
                    .ToList();

                FilterData(null, null);
            }
        }

        private void FilterData(object sender, EventArgs e)
        {
            var filteredShipments = shipments.AsQueryable();
            var selectedFilter = optionsCB.SelectedItem.ToString();

            if (selectedFilter == "Todos los embarques" && optionsCB.SelectedItem != null)
            {
                shipmentsDGV.DataSource = filteredShipments.ToList();
                monthComboBox.Enabled = false;
                nationalCheckBox.Enabled = false;
                cuuCheckBox.Enabled = false;
            }
            else
            {
                if (optionsCB.SelectedItem != null)
                {
                    selectedFilter = optionsCB.SelectedItem.ToString();

                    if (selectedFilter == "Todos los embarques en proceso")
                    {
                        monthComboBox.Enabled = false;
                        nationalCheckBox.Enabled = false;
                        cuuCheckBox.Enabled = false;
                        filteredShipments = shipments.AsQueryable();
                        filteredShipments = filteredShipments.Where(s => !s.IsProcessed);
                    }
                    else if (selectedFilter == "Todos los embarques completados")
                    {
                        monthComboBox.Enabled = false;
                        nationalCheckBox.Enabled = false;
                        cuuCheckBox.Enabled = false;
                        filteredShipments = shipments.AsQueryable();
                        filteredShipments = filteredShipments.Where(s => s.IsProcessed);
                    }
                    else if (selectedFilter == "Embarques completados")
                    {
                        monthComboBox.Enabled = true;
                        nationalCheckBox.Enabled = true;
                        cuuCheckBox.Enabled = true;
                        filteredShipments = filteredShipments.Where(s => s.IsProcessed);

                    }
                    else if (selectedFilter == "Embarques en proceso")
                    {
                        monthComboBox.Enabled = true;
                        nationalCheckBox.Enabled = true;
                        cuuCheckBox.Enabled = true;
                        filteredShipments = filteredShipments.Where(s => !s.IsProcessed);

                    }
                }

                if (cuuCheckBox.Enabled)
                {
                    if (monthComboBox.SelectedItem != null)
                    {
                        selectedFilter = monthComboBox.SelectedItem.ToString();
                        filteredShipments = filteredShipments.Where(s => s.Month.Contains(selectedFilter));
                    }

                    if (nationalCheckBox.Checked)
                    {
                        filteredShipments = filteredShipments.Where(s => s.IsNational);
                    }
                    else
                    {
                        filteredShipments = filteredShipments.Where(s => !s.IsNational);
                    }

                    if (cuuCheckBox.Checked)
                    {
                        filteredShipments = filteredShipments.Where(s => s.IsChihuahua);
                    }
                    else
                    {
                        filteredShipments = filteredShipments.Where(s => !s.IsChihuahua);
                    }
                }

                shipmentsDGV.DataSource = filteredShipments.ToList();
            }

            shipmentsDGV.Columns["Id"].Visible = false;
            shipmentsDGV.Columns["DeliveryDate"].Visible = false;
            shipmentsDGV.Columns["IsProcessed"].Visible = false;
            shipmentsDGV.Columns["IsNational"].Visible = false;
            shipmentsDGV.Columns["Month"].Visible = false;
            shipmentsDGV.Columns["IsChihuahua"].Visible = false;
            shipmentsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Close();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTxtBox.Text.ToLower();

            if (shipmentsDGV.IsCurrentCellInEditMode)
            {
                shipmentsDGV.EndEdit();
            }

            shipmentsDGV.SuspendLayout();

            try
            {
                foreach (DataGridViewRow row in shipmentsDGV.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool rowVisible = row.Cells.Cast<DataGridViewCell>()
                                            .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm));

                        this.shipmentsDGV.CurrentCell = null;
                        row.Visible = rowVisible;
                    }
                }
            }
            finally
            {
                shipmentsDGV.ResumeLayout();
            }

            shipmentsDGV.ClearSelection();
        }

        private void shipmentsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int shipmentId = (int)shipmentsDGV.Rows[e.RowIndex].Cells["Id"].Value;
                using (var context = new ApplicationDbContext())
                {
                    var shipment = context.Shipments
                    .Where(s => s.Id == shipmentId)
                    .Select(s => new ShipmentViewModel
                    {
                        Id = s.Id,
                        CustomerName = s.CustomerId.Name,
                        DeliveryPlaceName = s.DeliveryPlaceId.Name,
                        Invoice = s.Invoice,
                        PurchaseOrder = s.PurchaseOrder,
                        PurchaseOrder2 = s.PurchaseOrder2,
                        MaterialDescription = s.MaterialDescriptionId.Description,
                        Quantity = s.Quantity,
                        InvoiceDate = s.InvoiceDate,
                        CarrierName = s.CarrierId.Name,
                        Bol = s.Bol,
                        DriverName = s.DriverId.Name,
                        PlatformBox = s.PlatformBoxId.Description,
                        ShipDate = s.ShipDate,
                        Quantity2 = s.Quantity2,
                        IsProcessed = s.IsProcessed,
                        IsNational = s.IsNational,
                        Month = s.Month,
                        IsChihuahua = s.IsChihuahua
                    })
                    .SingleOrDefault();

                    if (shipment == null)
                    {
                        MessageBox.Show("Embarque no encontrado.");
                    }
                    else
                    {
                        ProceedShipment proceedShipment = new ProceedShipment(shipment, this);
                        proceedShipment.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (shipmentsDGV.SelectedRows.Count > 0)
            {
                int selectedEntityId = (int)shipmentsDGV.SelectedRows[0].Cells["Id"].Value;

                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este elemento?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (ApplicationDbContext context = new ApplicationDbContext())
                        {
                            Shipment shipmentToDelete = context.Shipments.Find(selectedEntityId);
                            context.Shipments.Remove(shipmentToDelete);
                            context.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al ejecutar la operación.\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void generatePDFBtn_Click(object sender, EventArgs e)
        {
            PDFGenerator pDFGenerator = new PDFGenerator();
            pDFGenerator.GenerateShipmentReport(shipmentsDGV);
        }

        public void RefreshDataGridView()
        {
            LoadShipments();
        }
    }
}
