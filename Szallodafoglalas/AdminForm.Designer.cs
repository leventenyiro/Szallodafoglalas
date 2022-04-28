namespace Szallodafoglalas
{
    partial class AdminForm
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
            this.tabPageStat = new System.Windows.Forms.TabPage();
            this.plotViewStat = new OxyPlot.WindowsForms.PlotView();
            this.buttonStat = new System.Windows.Forms.Button();
            this.comboBoxStatHotel = new System.Windows.Forms.ComboBox();
            this.labelStatHotel = new System.Windows.Forms.Label();
            this.dateTimePickerStatTo = new System.Windows.Forms.DateTimePicker();
            this.labelInterval = new System.Windows.Forms.Label();
            this.dateTimePickerStatFrom = new System.Windows.Forms.DateTimePicker();
            this.tabPageHotel = new System.Windows.Forms.TabPage();
            this.groupBoxReserve = new System.Windows.Forms.GroupBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerReserveDateTo = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownBed = new System.Windows.Forms.NumericUpDown();
            this.labelReservationBed = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerReserveDateFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxReserveName = new System.Windows.Forms.TextBox();
            this.groupBoxReserveDelete = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddHotel = new System.Windows.Forms.Button();
            this.numericUpDownTwoBed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOneBed = new System.Windows.Forms.NumericUpDown();
            this.labelHotelTwoBed = new System.Windows.Forms.Label();
            this.labelHotelOneBed = new System.Windows.Forms.Label();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.listBoxReservation = new System.Windows.Forms.ListBox();
            this.listBoxHotel = new System.Windows.Forms.ListBox();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageStat.SuspendLayout();
            this.tabPageHotel.SuspendLayout();
            this.groupBoxReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBed)).BeginInit();
            this.groupBoxReserveDelete.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwoBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOneBed)).BeginInit();
            this.tabControlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageStat
            // 
            this.tabPageStat.Controls.Add(this.plotViewStat);
            this.tabPageStat.Controls.Add(this.buttonStat);
            this.tabPageStat.Controls.Add(this.comboBoxStatHotel);
            this.tabPageStat.Controls.Add(this.labelStatHotel);
            this.tabPageStat.Controls.Add(this.dateTimePickerStatTo);
            this.tabPageStat.Controls.Add(this.labelInterval);
            this.tabPageStat.Controls.Add(this.dateTimePickerStatFrom);
            this.tabPageStat.Location = new System.Drawing.Point(4, 24);
            this.tabPageStat.Name = "tabPageStat";
            this.tabPageStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStat.Size = new System.Drawing.Size(1357, 398);
            this.tabPageStat.TabIndex = 2;
            this.tabPageStat.Text = "Statisztika";
            this.tabPageStat.UseVisualStyleBackColor = true;
            // 
            // plotViewStat
            // 
            this.plotViewStat.Location = new System.Drawing.Point(193, 6);
            this.plotViewStat.Name = "plotViewStat";
            this.plotViewStat.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewStat.Size = new System.Drawing.Size(1157, 385);
            this.plotViewStat.TabIndex = 4;
            this.plotViewStat.Text = "plotView1";
            this.plotViewStat.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewStat.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewStat.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // buttonStat
            // 
            this.buttonStat.Location = new System.Drawing.Point(112, 143);
            this.buttonStat.Name = "buttonStat";
            this.buttonStat.Size = new System.Drawing.Size(75, 23);
            this.buttonStat.TabIndex = 3;
            this.buttonStat.Text = "Statisztika";
            this.buttonStat.UseVisualStyleBackColor = true;
            this.buttonStat.Click += new System.EventHandler(this.buttonStat_Click);
            // 
            // comboBoxStatHotel
            // 
            this.comboBoxStatHotel.FormattingEnabled = true;
            this.comboBoxStatHotel.Location = new System.Drawing.Point(3, 103);
            this.comboBoxStatHotel.Name = "comboBoxStatHotel";
            this.comboBoxStatHotel.Size = new System.Drawing.Size(184, 23);
            this.comboBoxStatHotel.TabIndex = 2;
            // 
            // labelStatHotel
            // 
            this.labelStatHotel.AutoSize = true;
            this.labelStatHotel.Location = new System.Drawing.Point(6, 85);
            this.labelStatHotel.Name = "labelStatHotel";
            this.labelStatHotel.Size = new System.Drawing.Size(36, 15);
            this.labelStatHotel.TabIndex = 13;
            this.labelStatHotel.Text = "Hotel";
            // 
            // dateTimePickerStatTo
            // 
            this.dateTimePickerStatTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerStatTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStatTo.Location = new System.Drawing.Point(3, 50);
            this.dateTimePickerStatTo.Name = "dateTimePickerStatTo";
            this.dateTimePickerStatTo.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerStatTo.TabIndex = 1;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(6, 3);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(67, 15);
            this.labelInterval.TabIndex = 11;
            this.labelInterval.Text = "Intervallum";
            // 
            // dateTimePickerStatFrom
            // 
            this.dateTimePickerStatFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerStatFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStatFrom.Location = new System.Drawing.Point(3, 21);
            this.dateTimePickerStatFrom.Name = "dateTimePickerStatFrom";
            this.dateTimePickerStatFrom.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerStatFrom.TabIndex = 0;
            this.dateTimePickerStatFrom.ValueChanged += new System.EventHandler(this.dateTimePickerStatFrom_ValueChanged);
            // 
            // tabPageHotel
            // 
            this.tabPageHotel.Controls.Add(this.groupBoxReserve);
            this.tabPageHotel.Controls.Add(this.groupBoxReserveDelete);
            this.tabPageHotel.Controls.Add(this.groupBoxAdd);
            this.tabPageHotel.Controls.Add(this.listBoxReservation);
            this.tabPageHotel.Controls.Add(this.listBoxHotel);
            this.tabPageHotel.Location = new System.Drawing.Point(4, 24);
            this.tabPageHotel.Name = "tabPageHotel";
            this.tabPageHotel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHotel.Size = new System.Drawing.Size(1357, 398);
            this.tabPageHotel.TabIndex = 1;
            this.tabPageHotel.Text = "Hotelek";
            this.tabPageHotel.UseVisualStyleBackColor = true;
            // 
            // groupBoxReserve
            // 
            this.groupBoxReserve.Controls.Add(this.labelTo);
            this.groupBoxReserve.Controls.Add(this.dateTimePickerReserveDateTo);
            this.groupBoxReserve.Controls.Add(this.numericUpDownBed);
            this.groupBoxReserve.Controls.Add(this.labelReservationBed);
            this.groupBoxReserve.Controls.Add(this.textBoxTel);
            this.groupBoxReserve.Controls.Add(this.labelTel);
            this.groupBoxReserve.Controls.Add(this.textBoxEmail);
            this.groupBoxReserve.Controls.Add(this.labelEmail);
            this.groupBoxReserve.Controls.Add(this.labelFrom);
            this.groupBoxReserve.Controls.Add(this.dateTimePickerReserveDateFrom);
            this.groupBoxReserve.Controls.Add(this.buttonReserve);
            this.groupBoxReserve.Controls.Add(this.labelName);
            this.groupBoxReserve.Controls.Add(this.textBoxReserveName);
            this.groupBoxReserve.Location = new System.Drawing.Point(1155, 3);
            this.groupBoxReserve.Name = "groupBoxReserve";
            this.groupBoxReserve.Size = new System.Drawing.Size(199, 337);
            this.groupBoxReserve.TabIndex = 2;
            this.groupBoxReserve.TabStop = false;
            this.groupBoxReserve.Text = "Foglalás";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(9, 261);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(89, 15);
            this.labelTo.TabIndex = 16;
            this.labelTo.Text = "Indulás dátuma";
            // 
            // dateTimePickerReserveDateTo
            // 
            this.dateTimePickerReserveDateTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerReserveDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReserveDateTo.Location = new System.Drawing.Point(6, 279);
            this.dateTimePickerReserveDateTo.Name = "dateTimePickerReserveDateTo";
            this.dateTimePickerReserveDateTo.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerReserveDateTo.TabIndex = 5;
            // 
            // numericUpDownBed
            // 
            this.numericUpDownBed.Location = new System.Drawing.Point(6, 178);
            this.numericUpDownBed.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBed.Name = "numericUpDownBed";
            this.numericUpDownBed.Size = new System.Drawing.Size(177, 23);
            this.numericUpDownBed.TabIndex = 3;
            this.numericUpDownBed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelReservationBed
            // 
            this.labelReservationBed.AutoSize = true;
            this.labelReservationBed.Location = new System.Drawing.Point(6, 160);
            this.labelReservationBed.Name = "labelReservationBed";
            this.labelReservationBed.Size = new System.Drawing.Size(76, 15);
            this.labelReservationBed.TabIndex = 14;
            this.labelReservationBed.Text = "Ágyak száma";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(6, 125);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.PlaceholderText = "+36701234567";
            this.textBoxTel.Size = new System.Drawing.Size(177, 23);
            this.textBoxTel.TabIndex = 2;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(6, 107);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(72, 15);
            this.labelTel.TabIndex = 12;
            this.labelTel.Text = "Telefonszám";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(6, 81);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(177, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 63);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 15);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "E-mail";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(9, 207);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(89, 15);
            this.labelFrom.TabIndex = 9;
            this.labelFrom.Text = "Érkezés dátuma";
            // 
            // dateTimePickerReserveDateFrom
            // 
            this.dateTimePickerReserveDateFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerReserveDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReserveDateFrom.Location = new System.Drawing.Point(6, 225);
            this.dateTimePickerReserveDateFrom.Name = "dateTimePickerReserveDateFrom";
            this.dateTimePickerReserveDateFrom.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerReserveDateFrom.TabIndex = 4;
            this.dateTimePickerReserveDateFrom.ValueChanged += new System.EventHandler(this.dateTimePickerReserveDateFrom_ValueChanged);
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(118, 308);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(75, 23);
            this.buttonReserve.TabIndex = 6;
            this.buttonReserve.Text = "Foglalás";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(28, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Név";
            // 
            // textBoxReserveName
            // 
            this.textBoxReserveName.Location = new System.Drawing.Point(6, 37);
            this.textBoxReserveName.Name = "textBoxReserveName";
            this.textBoxReserveName.Size = new System.Drawing.Size(177, 23);
            this.textBoxReserveName.TabIndex = 0;
            // 
            // groupBoxReserveDelete
            // 
            this.groupBoxReserveDelete.Controls.Add(this.buttonDelete);
            this.groupBoxReserveDelete.Controls.Add(this.labelId);
            this.groupBoxReserveDelete.Controls.Add(this.textBoxId);
            this.groupBoxReserveDelete.Location = new System.Drawing.Point(3, 295);
            this.groupBoxReserveDelete.Name = "groupBoxReserveDelete";
            this.groupBoxReserveDelete.Size = new System.Drawing.Size(199, 90);
            this.groupBoxReserveDelete.TabIndex = 3;
            this.groupBoxReserveDelete.TabStop = false;
            this.groupBoxReserveDelete.Text = "Foglalás törlése";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(118, 64);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(6, 17);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(60, 15);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Azonosító";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(6, 35);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(177, 23);
            this.textBoxId.TabIndex = 0;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAddHotel);
            this.groupBoxAdd.Controls.Add(this.numericUpDownTwoBed);
            this.groupBoxAdd.Controls.Add(this.numericUpDownOneBed);
            this.groupBoxAdd.Controls.Add(this.labelHotelTwoBed);
            this.groupBoxAdd.Controls.Add(this.labelHotelOneBed);
            this.groupBoxAdd.Controls.Add(this.labelHotelName);
            this.groupBoxAdd.Controls.Add(this.textBoxHotelName);
            this.groupBoxAdd.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(199, 218);
            this.groupBoxAdd.TabIndex = 1;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Hozzáadás";
            // 
            // buttonAddHotel
            // 
            this.buttonAddHotel.Location = new System.Drawing.Point(118, 187);
            this.buttonAddHotel.Name = "buttonAddHotel";
            this.buttonAddHotel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddHotel.TabIndex = 3;
            this.buttonAddHotel.Text = "Hozzáadás";
            this.buttonAddHotel.UseVisualStyleBackColor = true;
            this.buttonAddHotel.Click += new System.EventHandler(this.buttonAddHotel_Click);
            // 
            // numericUpDownTwoBed
            // 
            this.numericUpDownTwoBed.Location = new System.Drawing.Point(6, 148);
            this.numericUpDownTwoBed.Name = "numericUpDownTwoBed";
            this.numericUpDownTwoBed.Size = new System.Drawing.Size(177, 23);
            this.numericUpDownTwoBed.TabIndex = 2;
            // 
            // numericUpDownOneBed
            // 
            this.numericUpDownOneBed.Location = new System.Drawing.Point(6, 90);
            this.numericUpDownOneBed.Name = "numericUpDownOneBed";
            this.numericUpDownOneBed.Size = new System.Drawing.Size(177, 23);
            this.numericUpDownOneBed.TabIndex = 1;
            // 
            // labelHotelTwoBed
            // 
            this.labelHotelTwoBed.AutoSize = true;
            this.labelHotelTwoBed.Location = new System.Drawing.Point(0, 130);
            this.labelHotelTwoBed.Name = "labelHotelTwoBed";
            this.labelHotelTwoBed.Size = new System.Drawing.Size(132, 15);
            this.labelHotelTwoBed.TabIndex = 4;
            this.labelHotelTwoBed.Text = "Két ágyas szobák száma";
            // 
            // labelHotelOneBed
            // 
            this.labelHotelOneBed.AutoSize = true;
            this.labelHotelOneBed.Location = new System.Drawing.Point(6, 72);
            this.labelHotelOneBed.Name = "labelHotelOneBed";
            this.labelHotelOneBed.Size = new System.Drawing.Size(134, 15);
            this.labelHotelOneBed.TabIndex = 3;
            this.labelHotelOneBed.Text = "Egy ágyas szobák száma";
            // 
            // labelHotelName
            // 
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Location = new System.Drawing.Point(6, 19);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(28, 15);
            this.labelHotelName.TabIndex = 1;
            this.labelHotelName.Text = "Név";
            // 
            // textBoxHotelName
            // 
            this.textBoxHotelName.Location = new System.Drawing.Point(6, 37);
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(177, 23);
            this.textBoxHotelName.TabIndex = 0;
            // 
            // listBoxReservation
            // 
            this.listBoxReservation.FormattingEnabled = true;
            this.listBoxReservation.ItemHeight = 15;
            this.listBoxReservation.Location = new System.Drawing.Point(522, 6);
            this.listBoxReservation.Name = "listBoxReservation";
            this.listBoxReservation.Size = new System.Drawing.Size(627, 379);
            this.listBoxReservation.TabIndex = 5;
            // 
            // listBoxHotel
            // 
            this.listBoxHotel.FormattingEnabled = true;
            this.listBoxHotel.ItemHeight = 15;
            this.listBoxHotel.Location = new System.Drawing.Point(211, 6);
            this.listBoxHotel.Name = "listBoxHotel";
            this.listBoxHotel.Size = new System.Drawing.Size(305, 379);
            this.listBoxHotel.TabIndex = 4;
            this.listBoxHotel.SelectedIndexChanged += new System.EventHandler(this.listBoxReservationHotel_SelectedIndexChanged);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageHotel);
            this.tabControlAdmin.Controls.Add(this.tabPageStat);
            this.tabControlAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1365, 426);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 439);
            this.Controls.Add(this.tabControlAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.Text = "Admin";
            this.tabPageStat.ResumeLayout(false);
            this.tabPageStat.PerformLayout();
            this.tabPageHotel.ResumeLayout(false);
            this.groupBoxReserve.ResumeLayout(false);
            this.groupBoxReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBed)).EndInit();
            this.groupBoxReserveDelete.ResumeLayout(false);
            this.groupBoxReserveDelete.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwoBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOneBed)).EndInit();
            this.tabControlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPageStat;
        private TabPage tabPageHotel;
        private GroupBox groupBoxReserve;
        private NumericUpDown numericUpDownBed;
        private Label labelReservationBed;
        private TextBox textBoxTel;
        private Label labelTel;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelFrom;
        private DateTimePicker dateTimePickerReserveDateFrom;
        private Button buttonReserve;
        private Label labelName;
        private TextBox textBoxReserveName;
        private GroupBox groupBoxReserveDelete;
        private Button buttonDelete;
        private Label labelId;
        private TextBox textBoxId;
        private GroupBox groupBoxAdd;
        private Button buttonAddHotel;
        private NumericUpDown numericUpDownTwoBed;
        private NumericUpDown numericUpDownOneBed;
        private Label labelHotelTwoBed;
        private Label labelHotelOneBed;
        private Label labelHotelName;
        private TextBox textBoxHotelName;
        private ListBox listBoxReservation;
        private ListBox listBoxHotel;
        private TabControl tabControlAdmin;
        private Button buttonStat;
        private ComboBox comboBoxStatHotel;
        private Label labelStatHotel;
        private DateTimePicker dateTimePickerStatTo;
        private Label labelInterval;
        private DateTimePicker dateTimePickerStatFrom;
        private OxyPlot.WindowsForms.PlotView plotViewStat;
        private Label labelTo;
        private DateTimePicker dateTimePickerReserveDateTo;
    }
}