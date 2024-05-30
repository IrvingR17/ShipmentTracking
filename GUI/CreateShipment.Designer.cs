namespace ShipmentTracking.GUI
{
    partial class CreateShipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateShipment));
            this.customerCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterCustomerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deliveryPlaceCB = new System.Windows.Forms.ComboBox();
            this.registerCityBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseOrderTxtBox = new System.Windows.Forms.TextBox();
            this.purchaseOrderTxtBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialCB = new System.Windows.Forms.ComboBox();
            this.registerMaterialBtn = new System.Windows.Forms.Button();
            this.registerCarrierBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.carrierCB = new System.Windows.Forms.ComboBox();
            this.bolTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.registerDriverBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.driverCB = new System.Windows.Forms.ComboBox();
            this.registerPlatformBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.platformCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.quantity2TxtBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.invoiceDTP = new System.Windows.Forms.DateTimePicker();
            this.shipDTP = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cuuCheckBox = new System.Windows.Forms.CheckBox();
            this.nationalCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // customerCB
            // 
            this.customerCB.FormattingEnabled = true;
            this.customerCB.Location = new System.Drawing.Point(40, 43);
            this.customerCB.Name = "customerCB";
            this.customerCB.Size = new System.Drawing.Size(270, 21);
            this.customerCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // RegisterCustomerBtn
            // 
            this.RegisterCustomerBtn.Location = new System.Drawing.Point(353, 40);
            this.RegisterCustomerBtn.Name = "RegisterCustomerBtn";
            this.RegisterCustomerBtn.Size = new System.Drawing.Size(131, 23);
            this.RegisterCustomerBtn.TabIndex = 20;
            this.RegisterCustomerBtn.Text = "Register customer";
            this.RegisterCustomerBtn.UseVisualStyleBackColor = true;
            this.RegisterCustomerBtn.Click += new System.EventHandler(this.registerCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ship To";
            // 
            // deliveryPlaceCB
            // 
            this.deliveryPlaceCB.FormattingEnabled = true;
            this.deliveryPlaceCB.Location = new System.Drawing.Point(40, 93);
            this.deliveryPlaceCB.Name = "deliveryPlaceCB";
            this.deliveryPlaceCB.Size = new System.Drawing.Size(270, 21);
            this.deliveryPlaceCB.TabIndex = 1;
            // 
            // registerCityBtn
            // 
            this.registerCityBtn.Location = new System.Drawing.Point(353, 93);
            this.registerCityBtn.Name = "registerCityBtn";
            this.registerCityBtn.Size = new System.Drawing.Size(131, 23);
            this.registerCityBtn.TabIndex = 21;
            this.registerCityBtn.Text = "Register city";
            this.registerCityBtn.UseVisualStyleBackColor = true;
            this.registerCityBtn.Click += new System.EventHandler(this.registerCityBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Invoice";
            // 
            // invoiceTxtBox
            // 
            this.invoiceTxtBox.Location = new System.Drawing.Point(40, 143);
            this.invoiceTxtBox.Name = "invoiceTxtBox";
            this.invoiceTxtBox.Size = new System.Drawing.Size(127, 20);
            this.invoiceTxtBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Purchase Order";
            // 
            // purchaseOrderTxtBox
            // 
            this.purchaseOrderTxtBox.Location = new System.Drawing.Point(40, 196);
            this.purchaseOrderTxtBox.Name = "purchaseOrderTxtBox";
            this.purchaseOrderTxtBox.Size = new System.Drawing.Size(127, 20);
            this.purchaseOrderTxtBox.TabIndex = 3;
            // 
            // purchaseOrderTxtBox2
            // 
            this.purchaseOrderTxtBox2.Location = new System.Drawing.Point(40, 246);
            this.purchaseOrderTxtBox2.Name = "purchaseOrderTxtBox2";
            this.purchaseOrderTxtBox2.Size = new System.Drawing.Size(127, 20);
            this.purchaseOrderTxtBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Purchase Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Material Description";
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.Location = new System.Drawing.Point(40, 351);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.Size = new System.Drawing.Size(127, 20);
            this.quantityTxtBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Invoice Date";
            // 
            // materialCB
            // 
            this.materialCB.FormattingEnabled = true;
            this.materialCB.Location = new System.Drawing.Point(40, 299);
            this.materialCB.Name = "materialCB";
            this.materialCB.Size = new System.Drawing.Size(398, 21);
            this.materialCB.TabIndex = 5;
            // 
            // registerMaterialBtn
            // 
            this.registerMaterialBtn.Location = new System.Drawing.Point(482, 297);
            this.registerMaterialBtn.Name = "registerMaterialBtn";
            this.registerMaterialBtn.Size = new System.Drawing.Size(131, 23);
            this.registerMaterialBtn.TabIndex = 22;
            this.registerMaterialBtn.Text = "Register material";
            this.registerMaterialBtn.UseVisualStyleBackColor = true;
            this.registerMaterialBtn.Click += new System.EventHandler(this.registerMaterialBtn_Click);
            // 
            // registerCarrierBtn
            // 
            this.registerCarrierBtn.Location = new System.Drawing.Point(964, 40);
            this.registerCarrierBtn.Name = "registerCarrierBtn";
            this.registerCarrierBtn.Size = new System.Drawing.Size(131, 23);
            this.registerCarrierBtn.TabIndex = 23;
            this.registerCarrierBtn.Text = "Register carrier";
            this.registerCarrierBtn.UseVisualStyleBackColor = true;
            this.registerCarrierBtn.Click += new System.EventHandler(this.registerCarrierBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(651, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Carrier";
            // 
            // carrierCB
            // 
            this.carrierCB.FormattingEnabled = true;
            this.carrierCB.Location = new System.Drawing.Point(651, 43);
            this.carrierCB.Name = "carrierCB";
            this.carrierCB.Size = new System.Drawing.Size(270, 21);
            this.carrierCB.TabIndex = 8;
            // 
            // bolTxtBox
            // 
            this.bolTxtBox.Location = new System.Drawing.Point(651, 94);
            this.bolTxtBox.Name = "bolTxtBox";
            this.bolTxtBox.Size = new System.Drawing.Size(127, 20);
            this.bolTxtBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(651, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "# Bol";
            // 
            // registerDriverBtn
            // 
            this.registerDriverBtn.Location = new System.Drawing.Point(964, 141);
            this.registerDriverBtn.Name = "registerDriverBtn";
            this.registerDriverBtn.Size = new System.Drawing.Size(131, 23);
            this.registerDriverBtn.TabIndex = 24;
            this.registerDriverBtn.Text = "Register driver";
            this.registerDriverBtn.UseVisualStyleBackColor = true;
            this.registerDriverBtn.Click += new System.EventHandler(this.registerDriverBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(651, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Driver";
            // 
            // driverCB
            // 
            this.driverCB.FormattingEnabled = true;
            this.driverCB.Location = new System.Drawing.Point(651, 144);
            this.driverCB.Name = "driverCB";
            this.driverCB.Size = new System.Drawing.Size(270, 21);
            this.driverCB.TabIndex = 10;
            // 
            // registerPlatformBtn
            // 
            this.registerPlatformBtn.Location = new System.Drawing.Point(964, 196);
            this.registerPlatformBtn.Name = "registerPlatformBtn";
            this.registerPlatformBtn.Size = new System.Drawing.Size(131, 23);
            this.registerPlatformBtn.TabIndex = 25;
            this.registerPlatformBtn.Text = "Register plataforma";
            this.registerPlatformBtn.UseVisualStyleBackColor = true;
            this.registerPlatformBtn.Click += new System.EventHandler(this.registerPlatformBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(651, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Plataforma/Caja";
            // 
            // platformCB
            // 
            this.platformCB.FormattingEnabled = true;
            this.platformCB.Location = new System.Drawing.Point(651, 199);
            this.platformCB.Name = "platformCB";
            this.platformCB.Size = new System.Drawing.Size(270, 21);
            this.platformCB.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(649, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ship Date";
            // 
            // quantity2TxtBox
            // 
            this.quantity2TxtBox.Location = new System.Drawing.Point(651, 302);
            this.quantity2TxtBox.Name = "quantity2TxtBox";
            this.quantity2TxtBox.Size = new System.Drawing.Size(127, 20);
            this.quantity2TxtBox.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(651, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Quantity";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.saveBtn.Location = new System.Drawing.Point(936, 425);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(108, 23);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // invoiceDTP
            // 
            this.invoiceDTP.Location = new System.Drawing.Point(42, 405);
            this.invoiceDTP.Name = "invoiceDTP";
            this.invoiceDTP.Size = new System.Drawing.Size(200, 20);
            this.invoiceDTP.TabIndex = 7;
            // 
            // shipDTP
            // 
            this.shipDTP.Location = new System.Drawing.Point(651, 253);
            this.shipDTP.Name = "shipDTP";
            this.shipDTP.Size = new System.Drawing.Size(200, 20);
            this.shipDTP.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1050, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cuuCheckBox
            // 
            this.cuuCheckBox.AutoSize = true;
            this.cuuCheckBox.Location = new System.Drawing.Point(652, 351);
            this.cuuCheckBox.Name = "cuuCheckBox";
            this.cuuCheckBox.Size = new System.Drawing.Size(79, 17);
            this.cuuCheckBox.TabIndex = 14;
            this.cuuCheckBox.Text = "PlantaCUU";
            this.cuuCheckBox.UseVisualStyleBackColor = true;
            // 
            // nationalCheckBox
            // 
            this.nationalCheckBox.AutoSize = true;
            this.nationalCheckBox.Location = new System.Drawing.Point(735, 351);
            this.nationalCheckBox.Name = "nationalCheckBox";
            this.nationalCheckBox.Size = new System.Drawing.Size(68, 17);
            this.nationalCheckBox.TabIndex = 15;
            this.nationalCheckBox.Text = "Nacional";
            this.nationalCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 460);
            this.Controls.Add(this.nationalCheckBox);
            this.Controls.Add(this.cuuCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shipDTP);
            this.Controls.Add(this.invoiceDTP);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.quantity2TxtBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.registerPlatformBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.platformCB);
            this.Controls.Add(this.registerDriverBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.driverCB);
            this.Controls.Add(this.bolTxtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.registerCarrierBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.carrierCB);
            this.Controls.Add(this.registerMaterialBtn);
            this.Controls.Add(this.materialCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.purchaseOrderTxtBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.purchaseOrderTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.invoiceTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerCityBtn);
            this.Controls.Add(this.deliveryPlaceCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisterCustomerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerCB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateShipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateShipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterCustomerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deliveryPlaceCB;
        private System.Windows.Forms.Button registerCityBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox invoiceTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox purchaseOrderTxtBox;
        private System.Windows.Forms.TextBox purchaseOrderTxtBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox materialCB;
        private System.Windows.Forms.Button registerMaterialBtn;
        private System.Windows.Forms.Button registerCarrierBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox carrierCB;
        private System.Windows.Forms.TextBox bolTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button registerDriverBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox driverCB;
        private System.Windows.Forms.Button registerPlatformBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox platformCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox quantity2TxtBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker invoiceDTP;
        private System.Windows.Forms.DateTimePicker shipDTP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cuuCheckBox;
        private System.Windows.Forms.CheckBox nationalCheckBox;
    }
}