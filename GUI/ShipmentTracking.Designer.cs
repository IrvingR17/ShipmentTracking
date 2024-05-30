namespace ShipmentTracking.GUI
{
    partial class ShipmentTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentTracking));
            this.backBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shipmentsDGV = new System.Windows.Forms.DataGridView();
            this.optionsCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nationalCheckBox = new System.Windows.Forms.CheckBox();
            this.cuuCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.generatePDFBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(1253, 552);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Atrás";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(1049, 30);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(279, 20);
            this.searchTxtBox.TabIndex = 3;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1049, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // shipmentsDGV
            // 
            this.shipmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmentsDGV.Location = new System.Drawing.Point(12, 56);
            this.shipmentsDGV.Name = "shipmentsDGV";
            this.shipmentsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.shipmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shipmentsDGV.Size = new System.Drawing.Size(1316, 489);
            this.shipmentsDGV.TabIndex = 5;
            this.shipmentsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipmentsDGV_CellDoubleClick);
            // 
            // optionsCB
            // 
            this.optionsCB.FormattingEnabled = true;
            this.optionsCB.Items.AddRange(new object[] {
            "Embarques en proceso",
            "Embarques completados",
            "Todos los embarques",
            "Todos los embarques en proceso",
            "Todos los embarques completados"});
            this.optionsCB.Location = new System.Drawing.Point(12, 29);
            this.optionsCB.Name = "optionsCB";
            this.optionsCB.Size = new System.Drawing.Size(251, 21);
            this.optionsCB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthComboBox.Location = new System.Drawing.Point(300, 28);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(155, 21);
            this.monthComboBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mes";
            // 
            // nationalCheckBox
            // 
            this.nationalCheckBox.AutoSize = true;
            this.nationalCheckBox.Location = new System.Drawing.Point(490, 28);
            this.nationalCheckBox.Name = "nationalCheckBox";
            this.nationalCheckBox.Size = new System.Drawing.Size(68, 17);
            this.nationalCheckBox.TabIndex = 10;
            this.nationalCheckBox.Text = "Nacional";
            this.nationalCheckBox.UseVisualStyleBackColor = true;
            // 
            // cuuCheckBox
            // 
            this.cuuCheckBox.AutoSize = true;
            this.cuuCheckBox.Location = new System.Drawing.Point(565, 28);
            this.cuuCheckBox.Name = "cuuCheckBox";
            this.cuuCheckBox.Size = new System.Drawing.Size(82, 17);
            this.cuuCheckBox.TabIndex = 11;
            this.cuuCheckBox.Text = "Planta CUU";
            this.cuuCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Location = new System.Drawing.Point(1172, 552);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Eliminar";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // generatePDFBtn
            // 
            this.generatePDFBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.generatePDFBtn.Location = new System.Drawing.Point(1027, 551);
            this.generatePDFBtn.Name = "generatePDFBtn";
            this.generatePDFBtn.Size = new System.Drawing.Size(139, 23);
            this.generatePDFBtn.TabIndex = 13;
            this.generatePDFBtn.Text = "Generar Reporte";
            this.generatePDFBtn.UseVisualStyleBackColor = false;
            this.generatePDFBtn.Click += new System.EventHandler(this.generatePDFBtn_Click);
            // 
            // ShipmentTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 587);
            this.Controls.Add(this.generatePDFBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.cuuCheckBox);
            this.Controls.Add(this.nationalCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optionsCB);
            this.Controls.Add(this.shipmentsDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShipmentTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShipmentTracking";
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView shipmentsDGV;
        private System.Windows.Forms.ComboBox optionsCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox nationalCheckBox;
        private System.Windows.Forms.CheckBox cuuCheckBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button generatePDFBtn;
    }
}