using ShipmentTracking.Data;
using ShipmentTracking.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ShipmentTracking.GUI
{
    public partial class CreateShipment : Form
    {
        private List<Customer> allCustomers;
        private List<DeliveryPlace> allDeliveryPlaces;
        private List<Material> allMaterials;
        private List<Carrier> allCarriers;
        private List<Driver> allDrivers;
        private List<PlatformBox> allPlatforms;

        public CreateShipment()
        {
            InitializeComponent();
            AutocompleteComboBox();
            LoadData();
        }

        private void LoadData()
        {
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

                    deliveryPlaceCB.AutoCompleteCustomSource = autoCompleteCollectionDeliveryPlaces;
                    deliveryPlaceCB.DataSource = allDeliveryPlaces;
                    deliveryPlaceCB.DisplayMember = "Name";
                    deliveryPlaceCB.ValueMember = "Id";

                    materialCB.AutoCompleteCustomSource = autoCompleteCollectionMaterials;
                    materialCB.DataSource = allMaterials;
                    materialCB.DisplayMember = "Description";
                    materialCB.ValueMember = "Id";

                    carrierCB.AutoCompleteCustomSource = autoCompleteCollectionCarriers;
                    carrierCB.DataSource = allCarriers;
                    carrierCB.DisplayMember = "Name";
                    carrierCB.ValueMember = "Id";

                    driverCB.AutoCompleteCustomSource = autoCompleteCollectionDrivers;
                    driverCB.DataSource = allDrivers;
                    driverCB.DisplayMember = "Name";
                    driverCB.ValueMember = "Id";

                    platformCB.AutoCompleteCustomSource = autoCompleteCollectionPlatforms;
                    platformCB.DataSource = allPlatforms;
                    platformCB.DisplayMember = "Description";
                    platformCB.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading categories: " + ex.Message);
            }

            ClearFormFields();
        }

        private void registerCustomer_Click(object sender, EventArgs e)
        {
            RegisterData registerData = new RegisterData("Customer");
            registerData.Show();
            this.Close();
        }

        private void registerCityBtn_Click(object sender, EventArgs e)
        {
            RegisterData registerData = new RegisterData("DeliveryPlace");
            registerData.Show();
            this.Close();
        }

        private void registerMaterialBtn_Click(object sender, EventArgs e)
        {
            RegisterData registerData = new RegisterData("Material");
            registerData.Show();
            this.Close();
        }

        private void registerCarrierBtn_Click(object sender, EventArgs e)
        {
            RegisterData registerData = new RegisterData("Carrier");
            registerData.Show();
            this.Close();
        }

        private void registerDriverBtn_Click(object sender, EventArgs e)
        {
            RegisterData registerData = new RegisterData("Driver");
            registerData.Show();
            this.Close();
        }

        private void registerPlatformBtn_Click(object sender, EventArgs e)
        {
            RegisterData registerData = new RegisterData("Platform");
            registerData.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerName = customerCB.Text;
            string deliveryPlaceName = deliveryPlaceCB.Text;
            string invoice = invoiceTxtBox.Text;
            string purchaseOrder = purchaseOrderTxtBox.Text;
            string purchaseOrder2 = purchaseOrderTxtBox2.Text;
            string materialDescription = materialCB.Text;
            string quantityText = quantityTxtBox.Text;
            DateTime invoiceDate = invoiceDTP.Value;
            string carrierName = carrierCB.Text;
            string bol = bolTxtBox.Text;
            string driverName = driverCB.Text;
            string platformBoxName = platformCB.Text;
            string quantity2Text = quantity2TxtBox.Text;
            DateTime shipDate = shipDTP.Value;

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
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    int customerId = (int)customerCB.SelectedValue;
                    int deliveryPlaceId = (int)deliveryPlaceCB.SelectedValue;
                    int materialId = (int)materialCB.SelectedValue;
                    int carrierId = (int)carrierCB.SelectedValue;
                    int driverId = (int)driverCB.SelectedValue;
                    int platformBoxId = (int)platformCB.SelectedValue;

                    var customer = context.Customers.Find(customerId);
                    var deliveryPlace = context.DeliveryPlaces.Find(deliveryPlaceId);
                    var material = context.Materials.Find(materialId);
                    var carrier = context.Carriers.Find(carrierId);
                    var driver = context.Drivers.Find(driverId);
                    var platformBox = context.PlatformBoxes.Find(platformBoxId);

                    var shipment = new Shipment
                    {
                        CustomerId = customer,
                        DeliveryPlaceId = deliveryPlace,
                        Invoice = invoiceTxtBox.Text,
                        PurchaseOrder = purchaseOrderTxtBox.Text,
                        PurchaseOrder2 = purchaseOrderTxtBox2.Text,
                        MaterialDescriptionId = material,
                        Quantity = int.Parse(quantityTxtBox.Text),
                        InvoiceDate = invoiceDTP.Value,
                        CarrierId = carrier,
                        Bol = bolTxtBox.Text,
                        DriverId = driver,
                        PlatformBoxId = platformBox,
                        ShipDate = shipDTP.Value,
                        Quantity2 = int.Parse(quantity2TxtBox.Text),
                        DeliveryDate = new DateTime(2099, 01, 01),
                        IsProcessed = false,
                        IsChihuahua = cuuCheckBox.Checked,
                        Month = shipDate.Month.ToString(),
                        IsNational = nationalCheckBox.Checked
                    };

                    context.Shipments.Add(shipment);
                    context.SaveChanges();

                    MessageBox.Show("El embarque se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                }
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2627 || sqlEx.Number == 2601))
                {
                    MessageBox.Show("El valor ingresado ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El valor ingresado ya existe o ocurrió un error al intentar guardar en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AutocompleteComboBox()
        {
            customerCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            customerCB.AutoCompleteSource = AutoCompleteSource.CustomSource;

            deliveryPlaceCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            deliveryPlaceCB.AutoCompleteSource = AutoCompleteSource.CustomSource;

            materialCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            materialCB.AutoCompleteSource = AutoCompleteSource.CustomSource;

            carrierCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            carrierCB.AutoCompleteSource = AutoCompleteSource.CustomSource;

            driverCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            driverCB.AutoCompleteSource = AutoCompleteSource.CustomSource;

            platformCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            platformCB.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ClearFormFields()
        {
            customerCB.Text = "";
            deliveryPlaceCB.Text = "";
            invoiceTxtBox.Text = "";
            purchaseOrderTxtBox.Text = "";
            purchaseOrderTxtBox2.Text = "";
            materialCB.Text = "";
            quantityTxtBox.Text = "";
            carrierCB.Text = "";
            bolTxtBox.Text = "";
            driverCB.Text = "";
            platformCB.Text = "";
            quantity2TxtBox.Text = "";
            invoiceDTP.Value = DateTime.Now;
            shipDTP.Value = DateTime.Now;
            nationalCheckBox.Checked = false;
            cuuCheckBox.Checked = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Close();
        }
    }
}
