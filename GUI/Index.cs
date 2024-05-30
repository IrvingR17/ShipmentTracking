using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ShipmentTracking.GUI
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();

            button3.Click += button3_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateShipment createShipment = new CreateShipment();
            createShipment.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShipmentTracking shipmentTracking = new ShipmentTracking();
            shipmentTracking.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}
