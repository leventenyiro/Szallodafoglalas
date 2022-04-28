namespace Szallodafoglalas
{
    partial class UserForm
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
            this.groupBoxReserveDelete = new System.Windows.Forms.GroupBox();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.listBoxHotel = new System.Windows.Forms.ListBox();
            this.groupBoxReserve = new System.Windows.Forms.GroupBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerReserveDateTo = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownBed = new System.Windows.Forms.NumericUpDown();
            this.labelBed = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerReserveDateFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxReserveDelete.SuspendLayout();
            this.groupBoxReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxReserveDelete
            // 
            this.groupBoxReserveDelete.Controls.Add(this.buttonDetails);
            this.groupBoxReserveDelete.Controls.Add(this.labelId);
            this.groupBoxReserveDelete.Controls.Add(this.textBoxId);
            this.groupBoxReserveDelete.Location = new System.Drawing.Point(12, 353);
            this.groupBoxReserveDelete.Name = "groupBoxReserveDelete";
            this.groupBoxReserveDelete.Size = new System.Drawing.Size(199, 90);
            this.groupBoxReserveDelete.TabIndex = 1;
            this.groupBoxReserveDelete.TabStop = false;
            this.groupBoxReserveDelete.Text = "Foglalás törlése";
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(118, 64);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonDetails.TabIndex = 1;
            this.buttonDetails.Text = "Részletek...";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
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
            // listBoxHotel
            // 
            this.listBoxHotel.FormattingEnabled = true;
            this.listBoxHotel.ItemHeight = 15;
            this.listBoxHotel.Location = new System.Drawing.Point(226, 21);
            this.listBoxHotel.Name = "listBoxHotel";
            this.listBoxHotel.Size = new System.Drawing.Size(562, 424);
            this.listBoxHotel.TabIndex = 3;
            // 
            // groupBoxReserve
            // 
            this.groupBoxReserve.Controls.Add(this.labelTo);
            this.groupBoxReserve.Controls.Add(this.dateTimePickerReserveDateTo);
            this.groupBoxReserve.Controls.Add(this.numericUpDownBed);
            this.groupBoxReserve.Controls.Add(this.labelBed);
            this.groupBoxReserve.Controls.Add(this.textBoxTel);
            this.groupBoxReserve.Controls.Add(this.labelTel);
            this.groupBoxReserve.Controls.Add(this.textBoxEmail);
            this.groupBoxReserve.Controls.Add(this.labelEmail);
            this.groupBoxReserve.Controls.Add(this.labelFrom);
            this.groupBoxReserve.Controls.Add(this.dateTimePickerReserveDateFrom);
            this.groupBoxReserve.Controls.Add(this.buttonReserve);
            this.groupBoxReserve.Controls.Add(this.labelName);
            this.groupBoxReserve.Controls.Add(this.textBoxName);
            this.groupBoxReserve.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReserve.Name = "groupBoxReserve";
            this.groupBoxReserve.Size = new System.Drawing.Size(199, 335);
            this.groupBoxReserve.TabIndex = 0;
            this.groupBoxReserve.TabStop = false;
            this.groupBoxReserve.Text = "Foglalás";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(9, 260);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(89, 15);
            this.labelTo.TabIndex = 16;
            this.labelTo.Text = "Indulás dátuma";
            // 
            // dateTimePickerReserveDateTo
            // 
            this.dateTimePickerReserveDateTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerReserveDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReserveDateTo.Location = new System.Drawing.Point(6, 278);
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
            // labelBed
            // 
            this.labelBed.AutoSize = true;
            this.labelBed.Location = new System.Drawing.Point(6, 160);
            this.labelBed.Name = "labelBed";
            this.labelBed.Size = new System.Drawing.Size(76, 15);
            this.labelBed.TabIndex = 14;
            this.labelBed.Text = "Ágyak száma";
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
            this.buttonReserve.Location = new System.Drawing.Point(115, 306);
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.groupBoxReserve);
            this.Controls.Add(this.groupBoxReserveDelete);
            this.Controls.Add(this.listBoxHotel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.Text = "User";
            this.groupBoxReserveDelete.ResumeLayout(false);
            this.groupBoxReserveDelete.PerformLayout();
            this.groupBoxReserve.ResumeLayout(false);
            this.groupBoxReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxReserveDelete;
        private Button buttonDetails;
        private Label labelId;
        private TextBox textBoxId;
        private ListBox listBoxHotel;
        private GroupBox groupBoxReserve;
        private NumericUpDown numericUpDownBed;
        private Label labelBed;
        private TextBox textBoxTel;
        private Label labelTel;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelFrom;
        private DateTimePicker dateTimePickerReserveDateFrom;
        private Button buttonReserve;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelTo;
        private DateTimePicker dateTimePickerReserveDateTo;
    }
}