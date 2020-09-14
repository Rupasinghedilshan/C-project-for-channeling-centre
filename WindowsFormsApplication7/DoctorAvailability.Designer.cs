namespace WindowsFormsApplication7
{
    partial class DoctorAvailability
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.doctorAvailabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neerogaChannelingCenterDataSet3 = new WindowsFormsApplication7.NeerogaChannelingCenterDataSet3();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDocAvailability = new System.Windows.Forms.DataGridView();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.doctor_AvailabilityTableAdapter = new WindowsFormsApplication7.NeerogaChannelingCenterDataSet3TableAdapters.Doctor_AvailabilityTableAdapter();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAvailabilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neerogaChannelingCenterDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocAvailability)).BeginInit();
            this.panelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 331);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(549, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DataSource = this.doctorAvailabilityBindingSource;
            this.comboBox1.DisplayMember = "UserID";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(645, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "UserID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // doctorAvailabilityBindingSource
            // 
            this.doctorAvailabilityBindingSource.DataMember = "Doctor_Availability";
            this.doctorAvailabilityBindingSource.DataSource = this.neerogaChannelingCenterDataSet3;
            // 
            // neerogaChannelingCenterDataSet3
            // 
            this.neerogaChannelingCenterDataSet3.DataSetName = "NeerogaChannelingCenterDataSet3";
            this.neerogaChannelingCenterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridViewDocAvailability);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 299);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Availability";
            // 
            // dataGridViewDocAvailability
            // 
            this.dataGridViewDocAvailability.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridViewDocAvailability.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDocAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocAvailability.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewDocAvailability.Location = new System.Drawing.Point(0, 47);
            this.dataGridViewDocAvailability.Name = "dataGridViewDocAvailability";
            this.dataGridViewDocAvailability.Size = new System.Drawing.Size(851, 210);
            this.dataGridViewDocAvailability.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // doctor_AvailabilityTableAdapter
            // 
            this.doctor_AvailabilityTableAdapter.ClearBeforeFill = true;
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelDrag.Controls.Add(this.label13);
            this.panelDrag.Controls.Add(this.btnClose);
            this.panelDrag.Controls.Add(this.bunifuTileButton2);
            this.panelDrag.Location = new System.Drawing.Point(-1, -3);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(878, 27);
            this.panelDrag.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.AliceBlue;
            this.label13.Location = new System.Drawing.Point(-16, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(284, 22);
            this.label13.TabIndex = 14;
            this.label13.Text = "Neeroga Health Care - Doctor availability";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.color = System.Drawing.Color.DarkRed;
            this.btnClose.colorActive = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = null;
            this.btnClose.ImagePosition = 19;
            this.btnClose.ImageZoom = 50;
            this.btnClose.LabelPosition = 24;
            this.btnClose.LabelText = "x";
            this.btnClose.Location = new System.Drawing.Point(840, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 24);
            this.btnClose.TabIndex = 13;
            this.btnClose.Tag = "";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.DarkRed;
            this.bunifuTileButton2.color = System.Drawing.Color.DarkRed;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = null;
            this.bunifuTileButton2.ImagePosition = 27;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 29;
            this.bunifuTileButton2.LabelText = "-";
            this.bunifuTileButton2.Location = new System.Drawing.Point(805, 2);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(34, 24);
            this.bunifuTileButton2.TabIndex = 12;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click_1);
            // 
            // DoctorAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 377);
            this.Controls.Add(this.panelDrag);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorAvailability";
            this.Load += new System.EventHandler(this.DoctorAvailability_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorAvailabilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neerogaChannelingCenterDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocAvailability)).EndInit();
            this.panelDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dataGridViewDocAvailability;
        private System.Windows.Forms.ComboBox comboBox1;
        private NeerogaChannelingCenterDataSet3 neerogaChannelingCenterDataSet3;
        private System.Windows.Forms.BindingSource doctorAvailabilityBindingSource;
        private NeerogaChannelingCenterDataSet3TableAdapters.Doctor_AvailabilityTableAdapter doctor_AvailabilityTableAdapter;
        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuTileButton btnClose;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
    }
}