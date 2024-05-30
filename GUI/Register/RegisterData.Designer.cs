namespace ShipmentTracking.GUI
{
    partial class RegisterData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterData));
            this.label1 = new System.Windows.Forms.Label();
            this.dataTxtBox = new System.Windows.Forms.TextBox();
            this.dataDGV = new System.Windows.Forms.DataGridView();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editCheckBox = new System.Windows.Forms.CheckBox();
            this.saveEditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar datos";
            // 
            // dataTxtBox
            // 
            this.dataTxtBox.Location = new System.Drawing.Point(16, 30);
            this.dataTxtBox.Name = "dataTxtBox";
            this.dataTxtBox.Size = new System.Drawing.Size(283, 20);
            this.dataTxtBox.TabIndex = 1;
            // 
            // dataDGV
            // 
            this.dataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDGV.Location = new System.Drawing.Point(16, 57);
            this.dataDGV.Name = "dataDGV";
            this.dataDGV.Size = new System.Drawing.Size(772, 352);
            this.dataDGV.TabIndex = 2;
            this.dataDGV.SelectionChanged += new System.EventHandler(this.dataDGV_SelectionChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(314, 28);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Guardar";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(713, 415);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Atrás";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(632, 415);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Eliminar";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editCheckBox
            // 
            this.editCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.editCheckBox.AutoSize = true;
            this.editCheckBox.Location = new System.Drawing.Point(582, 415);
            this.editCheckBox.Name = "editCheckBox";
            this.editCheckBox.Size = new System.Drawing.Size(44, 23);
            this.editCheckBox.TabIndex = 6;
            this.editCheckBox.Text = "Editar";
            this.editCheckBox.UseVisualStyleBackColor = true;
            this.editCheckBox.CheckedChanged += new System.EventHandler(this.editCheckBox_CheckedChanged);
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.BackColor = System.Drawing.Color.LightGreen;
            this.saveEditBtn.Location = new System.Drawing.Point(453, 415);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Size = new System.Drawing.Size(123, 23);
            this.saveEditBtn.TabIndex = 7;
            this.saveEditBtn.Text = "Guardar Edición";
            this.saveEditBtn.UseVisualStyleBackColor = false;
            this.saveEditBtn.Visible = false;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // RegisterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveEditBtn);
            this.Controls.Add(this.editCheckBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.dataDGV);
            this.Controls.Add(this.dataTxtBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dataDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataTxtBox;
        private System.Windows.Forms.DataGridView dataDGV;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.CheckBox editCheckBox;
        private System.Windows.Forms.Button saveEditBtn;
    }
}