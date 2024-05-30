using ShipmentTracking.Data;
using ShipmentTracking.Entities;
using ShipmentTracking.Entities.Interfaces;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace ShipmentTracking.GUI
{
    public partial class RegisterData : Form
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private string entity = "";
        private Type currentEntityType;

        public RegisterData(string entity)
        {
            InitializeComponent();

            this.entity = entity;
            label1.Text = "Registrar " + entity;
            dataDGV.ReadOnly = true;
            dataDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataDGV.MultiSelect = false;

            switch (entity)
            {
                case "Customer":
                    currentEntityType = typeof(Customer);
                    LoadEntities<Customer>();
                    break;
                case "DeliveryPlace":
                    currentEntityType = typeof(DeliveryPlace);
                    LoadEntities<DeliveryPlace>();
                    break;
                case "Material":
                    currentEntityType = typeof(Material);
                    LoadEntities<Material>();
                    break;
                case "Carrier":
                    currentEntityType = typeof(Carrier);
                    LoadEntities<Carrier>();
                    break;
                case "Driver":
                    currentEntityType = typeof(Driver);
                    LoadEntities<Driver>();
                    break;
                case "Platform":
                    currentEntityType = typeof(PlatformBox);
                    LoadEntities<PlatformBox>();
                    break;
            }

            dataDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private EntityHandler<T> GetEntityHandler<T>() where T : class, IEntity
        {
            return new EntityHandler<T>();
        }

        private void LoadEntities<T>() where T : class, IEntity
        {
            var handler = GetEntityHandler<T>();
            var entities = handler.GetAllEntities();
            dataDGV.DataSource = entities;
            dataDGV.Columns["Id"].Visible = false;
            dataDGV.Columns["TextField"].Visible = false;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CreateShipment createShipment = new CreateShipment();
            createShipment.Show();
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string userInput = dataTxtBox.Text;

            if (!string.IsNullOrEmpty(userInput))
            {
                try
                {
                    switch (entity)
                    {
                        case "Customer":
                            var customer = new Customer
                            { Name = userInput };
                            context.Customers.Add(customer);
                            context.SaveChanges();
                            LoadEntities<Customer>();
                            break;
                        case "DeliveryPlace":
                            var deliveryPlace = new DeliveryPlace
                            { Name = userInput };
                            context.DeliveryPlaces.Add(deliveryPlace);
                            context.SaveChanges();
                            LoadEntities<DeliveryPlace>();
                            break;
                        case "Material":
                            var material = new Material
                            { Description = userInput };
                            context.Materials.Add(material);
                            context.SaveChanges();
                            LoadEntities<Material>();
                            break;
                        case "Carrier":
                            var carrier = new Carrier
                            { Name = userInput };
                            context.Carriers.Add(carrier);
                            context.SaveChanges();
                            LoadEntities<Carrier>();
                            break;
                        case "Driver":
                            var driver = new Driver
                            { Name = userInput };
                            context.Drivers.Add(driver);
                            context.SaveChanges();
                            LoadEntities<Driver>();
                            break;
                        case "Platform":
                            var platform = new PlatformBox
                            { Description = userInput };
                            context.PlatformBoxes.Add(platform);
                            context.SaveChanges();
                            LoadEntities<PlatformBox>();
                            break;
                    }
                    dataTxtBox.Text = "";
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("El valor ingresado ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (var entry in context.ChangeTracker.Entries())
                {
                    entry.State = EntityState.Detached;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido en el ComboBox.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataDGV.SelectedRows.Count > 0)
            {
                int selectedEntityId = (int)dataDGV.SelectedRows[0].Cells["Id"].Value;

                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este elemento?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        if (currentEntityType == typeof(Carrier))
                        {
                            var handler = new EntityHandler<Carrier>();
                            handler.DeleteEntity(selectedEntityId);
                            LoadEntities<Carrier>();
                        }
                        else if (currentEntityType == typeof(Customer))
                        {
                            var handler = new EntityHandler<Customer>();
                            handler.DeleteEntity(selectedEntityId);
                            LoadEntities<Customer>();
                        }
                        else if (currentEntityType == typeof(DeliveryPlace))
                        {
                            var handler = new EntityHandler<DeliveryPlace>();
                            handler.DeleteEntity(selectedEntityId);
                            LoadEntities<DeliveryPlace>();
                        }
                        else if (currentEntityType == typeof(Driver))
                        {
                            var handler = new EntityHandler<Driver>();
                            handler.DeleteEntity(selectedEntityId);
                            LoadEntities<Driver>();
                        }
                        else if (currentEntityType == typeof(Material))
                        {
                            var handler = new EntityHandler<Material>();
                            handler.DeleteEntity(selectedEntityId);
                            LoadEntities<Material>();
                        }
                        else if (currentEntityType == typeof(PlatformBox))
                        {
                            var handler = new EntityHandler<PlatformBox>();
                            handler.DeleteEntity(selectedEntityId);
                            LoadEntities<PlatformBox>();
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        MessageBox.Show("Ocurrió un error al ejecutar la operación, probablemente estas borrando" +
                            " un registro que ya esta asociado a uno o mas embarques.\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void dataDGV_SelectionChanged(object sender, EventArgs e)
        {
            deleteBtn.Enabled = dataDGV.SelectedRows.Count > 0;
        }

        private void editCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dataDGV.SelectedRows.Count > 0)
            {
                dataDGV.ReadOnly = !editCheckBox.Checked;
                saveEditBtn.Visible = editCheckBox.Checked;
                foreach (DataGridViewRow row in dataDGV.Rows)
                {
                    if (row.Selected)
                    {
                        row.ReadOnly = !editCheckBox.Checked;
                    }
                }
            }
            else
            {
                editCheckBox.Checked = false;
            }
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataDGV.SelectedRows.Count > 0 && editCheckBox.Checked)
                {
                    DataGridViewRow selectedRow = dataDGV.SelectedRows[0];

                    if (currentEntityType == typeof(Carrier))
                    {
                        var handler = new EntityHandler<Carrier>();
                        handler.EditEntity((int)selectedRow.Cells[0].Value, selectedRow.Cells[1].Value.ToString());
                        dataDGV.ReadOnly = true;
                    }
                    else if (currentEntityType == typeof(Customer))
                    {
                        var handler = new EntityHandler<Customer>();
                        handler.EditEntity((int)selectedRow.Cells[0].Value, selectedRow.Cells[1].Value.ToString());
                        dataDGV.ReadOnly = true;
                    }
                    else if (currentEntityType == typeof(DeliveryPlace))
                    {
                        var handler = new EntityHandler<DeliveryPlace>();
                        handler.EditEntity((int)selectedRow.Cells[0].Value, selectedRow.Cells[1].Value.ToString());
                        dataDGV.ReadOnly = true;
                    }
                    else if (currentEntityType == typeof(Driver))
                    {
                        var handler = new EntityHandler<Driver>();
                        handler.EditEntity((int)selectedRow.Cells[0].Value, selectedRow.Cells[1].Value.ToString());
                        dataDGV.ReadOnly = true;
                    }
                    else if (currentEntityType == typeof(Material))
                    {
                        var handler = new EntityHandler<Material>();
                        handler.EditEntity((int)selectedRow.Cells[0].Value, selectedRow.Cells[1].Value.ToString());
                        dataDGV.ReadOnly = true;
                    }
                    else if (currentEntityType == typeof(PlatformBox))
                    {
                        var handler = new EntityHandler<PlatformBox>();
                        handler.EditEntity((int)selectedRow.Cells[0].Value, selectedRow.Cells[1].Value.ToString());
                        dataDGV.ReadOnly = true;
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione una fila y active la edición para guardar los cambios.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al ejecutar la operación.\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            editCheckBox.Checked = false;
        }
    }
}
