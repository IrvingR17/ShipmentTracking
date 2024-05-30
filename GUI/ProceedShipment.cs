using ShipmentTracking.Data;
using ShipmentTracking.Entities;
using ShipmentTracking.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShipmentTracking.GUI
{
    public partial class ProceedShipment : Form
    {
        ShipmentViewModel shipmentViewModel;
        ShipmentTracking trackingWindow;

        private List<Customer> allCustomers;
        private List<DeliveryPlace> allDeliveryPlaces;
        private List<Material> allMaterials;
        private List<Carrier> allCarriers;
        private List<Driver> allDrivers;
        private List<PlatformBox> allPlatforms;

        public ProceedShipment(ShipmentViewModel shipmentViewModel, ShipmentTracking trackingWindow)
        {
            InitializeComponent();
            LoadShipmentDetails(shipmentViewModel);
            this.shipmentViewModel = shipmentViewModel;
            this.trackingWindow = trackingWindow;

            AutocompleteComboBox();
        }

        private void LoadShipmentDetails(ShipmentViewModel shipmentViewModel)
        {
            invoiceTextBox.Text = shipmentViewModel.Invoice;
            purchaseOrderTextBox.Text = shipmentViewModel.PurchaseOrder;
            purchaseOrderTextBox2.Text = shipmentViewModel.PurchaseOrder2;
            quantityTextBox.Text = shipmentViewModel.Quantity.ToString();
            invoiceDatePicker.Value = shipmentViewModel.InvoiceDate;
            bolTextBox.Text = shipmentViewModel.Bol;
            shipDatePicker.Value = shipmentViewModel.ShipDate;
            quantity2TextBox.Text = shipmentViewModel.Quantity2.ToString();
            nationalCheckBox.Checked = shipmentViewModel.IsNational;
            cuuCheckBox.Checked = shipmentViewModel.IsChihuahua;
            isProcessedCheckBox.Checked = shipmentViewModel.IsProcessed;

            if (isProcessedCheckBox.Checked)
            {
                OTDDateTimePicker.Enabled = false;
            }
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    allCustomers = context.Customers.ToList();
                    allDeliveryPlaces = context.DeliveryPlaces.ToList();
                    allMaterials = context.Materials.ToList();
                    allCarriers = context.Carriers.ToList();
                    allDrivers = context.Drivers.ToList();
                    allPlatforms = context.PlatformBoxes.ToList();

                    customerCB.Items.Clear();
                    deliveryPlaceCB.Items.Clear();
                    materialCB.Items.Clear();
                    carrierCB.Items.Clear();
                    driverCB.Items.Clear();
                    platformCB.Items.Clear();

                    AutoCompleteStringCollection autoCompleteCollectionCustomers = new AutoCompleteStringCollection();
                    AutoCompleteStringCollection autoCompleteCollectionDeliveryPlaces = new AutoCompleteStringCollection();
                    AutoCompleteStringCollection autoCompleteCollectionMaterials = new AutoCompleteStringCollection();
                    AutoCompleteStringCollection autoCompleteCollectionCarriers = new AutoCompleteStringCollection();
                    AutoCompleteStringCollection autoCompleteCollectionDrivers = new AutoCompleteStringCollection();
                    AutoCompleteStringCollection autoCompleteCollectionPlatforms = new AutoCompleteStringCollection();

                    foreach (var customer in allCustomers)
                    {
                        autoCompleteCollectionCustomers.Add(customer.Name);
                    }
                    foreach (var deliveryPlace in allDeliveryPlaces)
                    {
                        autoCompleteCollectionDeliveryPlaces.Add(deliveryPlace.Name);
                    }
                    foreach (var material in allMaterials)
                    {
                        autoCompleteCollectionMaterials.Add(material.Description);
                    }
                    foreach (var carrier in allCarriers)
                    {
                        autoCompleteCollectionCarriers.Add(carrier.Name);
                    }
                    foreach (var driver in allDrivers)
                    {
                        autoCompleteCollectionDrivers.Add(driver.Name);
                    }
                    foreach (var platform in allPlatforms)
                    {
                        autoCompleteCollectionPlatforms.Add(platform.Description);
                    }

                    customerCB.AutoCompleteCustomSource = autoCompleteCollectionCustomers;
                    customerCB.DataSource = allCustomers;
                    customerCB.DisplayMember = "Name";
                    customerCB.ValueMember = "Id";
                    customerCB.Text = shipmentViewModel.CustomerName;

                    deliveryPlaceCB.AutoCompleteCustomSource = autoCompleteCollectionDeliveryPlaces;
                    deliveryPlaceCB.DataSource = allDeliveryPlaces;
                    deliveryPlaceCB.DisplayMember = "Name";
                    deliveryPlaceCB.ValueMember = "Id";
                    deliveryPlaceCB.Text = shipmentViewModel.DeliveryPlaceName;

                    materialCB.AutoCompleteCustomSource = autoCompleteCollectionMaterials;
                    materialCB.DataSource = allMaterials;
                    materialCB.DisplayMember = "Description";
                    materialCB.ValueMember = "Id";
                    materialCB.Text = shipmentViewModel.MaterialDescription;

                    carrierCB.AutoCompleteCustomSource = autoCompleteCollectionCarriers;
                    carrierCB.DataSource = allCarriers;
                    carrierCB.DisplayMember = "Name";
                    carrierCB.ValueMember = "Id";
                    carrierCB.Text = shipmentViewModel.CarrierName;

                    driverCB.AutoCompleteCustomSource = autoCompleteCollectionDrivers;
                    driverCB.DataSource = allDrivers;
                    driverCB.DisplayMember = "Name";
                    driverCB.ValueMember = "Id";
                    driverCB.Text = shipmentViewModel.DriverName;

                    platformCB.AutoCompleteCustomSource = autoCompleteCollectionPlatforms;
                    platformCB.DataSource = allPlatforms;
                    platformCB.DisplayMember = "Description";
                    platformCB.ValueMember = "Id";
                    platformCB.Text = shipmentViewModel.PlatformBox;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading categories: " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                Shipment shipment;
                if (editionCheckBox.Checked)
                {
                    string customerName = customerCB.Text;
                    string deliveryPlaceName = deliveryPlaceCB.Text;
                    string invoice = invoiceTextBox.Text;
                    string purchaseOrder = purchaseOrderTextBox.Text;
                    string purchaseOrder2 = purchaseOrderTextBox2.Text;
                    string materialDescription = materialCB.Text;
                    string quantityText = quantityTextBox.Text;
                    DateTime invoiceDate = invoiceDatePicker.Value;
                    string carrierName = carrierCB.Text;
                    string bol = bolTextBox.Text;
                    string driverName = driverCB.Text;
                    string platformBoxName = platformCB.Text;
                    string quantity2Text = quantity2TextBox.Text;
                    DateTime shipDate = shipDatePicker.Value;

                    if (string.IsNullOrWhiteSpace(customerName) ||
                        string.IsNullOrWhiteSpace(deliveryPlaceName) ||
                        string.IsNullOrWhiteSpace(invoice) ||
                        string.IsNullOrWhiteSpace(purchaseOrder) ||
                        string.IsNullOrWhiteSpace(purchaseOrder2) ||
                        string.IsNullOrWhiteSpace(materialDescription) ||
                        string.IsNullOrWhiteSpace(quantityText) ||
                        string.IsNullOrWhiteSpace(carrierName) ||
                        string.IsNullOrWhiteSpace(bol) ||
                        string.IsNullOrWhiteSpace(driverName) ||
                        string.IsNullOrWhiteSpace(platformBoxName) ||
                        string.IsNullOrWhiteSpace(quantity2Text))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(quantityText, out int quantity) || !int.TryParse(quantity2Text, out int quantity2))
                    {
                        MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    shipment = context.Shipments.Find(shipmentViewModel.Id);
                    shipment.CustomerId = context.Customers.Find(customerCB.SelectedValue);
                    shipment.DeliveryPlaceId = context.DeliveryPlaces.Find(deliveryPlaceCB.SelectedValue);
                    shipment.Invoice = invoiceTextBox.Text;
                    shipment.PurchaseOrder = purchaseOrderTextBox.Text;
                    shipment.PurchaseOrder2 = purchaseOrderTextBox2.Text;
                    shipment.MaterialDescriptionId = context.Materials.Find(materialCB.SelectedValue);
                    shipment.Quantity = int.Parse(quantityTextBox.Text);
                    shipment.InvoiceDate = invoiceDatePicker.Value;
                    shipment.CarrierId = context.Carriers.Find(carrierCB.SelectedValue);
                    shipment.Bol = bolTextBox.Text;
                    shipment.DriverId = context.Drivers.Find(driverCB.SelectedValue);
                    shipment.PlatformBoxId = context.PlatformBoxes.Find(platformCB.SelectedValue);
                    shipment.ShipDate = shipDatePicker.Value;
                    shipment.Quantity2 = int.Parse(quantity2TextBox.Text);
                    shipment.DeliveryDate = OTDDateTimePicker.Value;
                    shipment.IsProcessed = isProcessedCheckBox.Checked;
                    shipment.IsNational = nationalCheckBox.Checked;
                    shipment.Month = shipDatePicker.Value.Month.ToString();
                    shipment.IsChihuahua = cuuCheckBox.Checked;

                    context.SaveChanges();

                    MessageBox.Show("La modificacion del embarque se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    trackingWindow = new ShipmentTracking();
                    trackingWindow.Show();
                    this.Close();

                }
                else
                {
                    shipment = context.Shipments.Find(shipmentViewModel.Id);
                    shipment.DeliveryDate = OTDDateTimePicker.Value;
                    shipment.IsProcessed = true;
                    context.SaveChanges();

                    MessageBox.Show("El embarque se ha marcado como completado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    trackingWindow.RefreshDataGridView();
                    trackingWindow.Show();
                    this.Close();
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            trackingWindow.Show();
            this.Close();
        }

        private void editionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editionCheckBox.Checked)
            {
                customerCB.Enabled = true;
                deliveryPlaceCB.Enabled = true;
                invoiceTextBox.ReadOnly = false;
                purchaseOrderTextBox.ReadOnly = false;
                purchaseOrderTextBox2.ReadOnly = false;
                materialCB.Enabled = true;
                quantityTextBox.ReadOnly = false;
                carrierCB.Enabled = true;
                invoiceDatePicker.Enabled = true;
                bolTextBox.ReadOnly = false;
                driverCB.Enabled = true;
                platformCB.Enabled = true;
                shipDatePicker.Enabled = true;
                quantity2TextBox.ReadOnly = false;
                nationalCheckBox.Enabled = true;
                cuuCheckBox.Enabled = true;
                isProcessedCheckBox.Enabled = true;
            }
            else
            {
                customerCB.Enabled = false;
                deliveryPlaceCB.Enabled = false;
                invoiceTextBox.ReadOnly = true;
                purchaseOrderTextBox.ReadOnly = true;
                purchaseOrderTextBox2.ReadOnly = true;
                materialCB.Enabled = false;
                quantityTextBox.ReadOnly = true;
                carrierCB.Enabled = false;
                invoiceDatePicker.Enabled = false;
                bolTextBox.ReadOnly = true;
                driverCB.Enabled = false;
                platformCB.Enabled = false;
                shipDatePicker.Enabled = false;
                quantity2TextBox.ReadOnly = true;
                nationalCheckBox.Enabled = false;
                cuuCheckBox.Enabled = false;
                isProcessedCheckBox.Enabled = false;
            }
        }

        private void AutocompleteComboBox()
        {
            customerCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            customerCB.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
