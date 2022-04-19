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
            this.numericUpDownBed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerReserveDate = new System.Windows.Forms.DateTimePicker();
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
            this.groupBoxReserveDelete.Location = new System.Drawing.Point(12, 301);
            this.groupBoxReserveDelete.Name = "groupBoxReserveDelete";
            this.groupBoxReserveDelete.Size = new System.Drawing.Size(199, 90);
            this.groupBoxReserveDelete.TabIndex = 10;
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
            this.listBoxHotel.Size = new System.Drawing.Size(562, 364);
            this.listBoxHotel.TabIndex = 8;
            // 
            // groupBoxReserve
            // 
            this.groupBoxReserve.Controls.Add(this.numericUpDownBed);
            this.groupBoxReserve.Controls.Add(this.label4);
            this.groupBoxReserve.Controls.Add(this.textBoxTel);
            this.groupBoxReserve.Controls.Add(this.label3);
            this.groupBoxReserve.Controls.Add(this.textBoxEmail);
            this.groupBoxReserve.Controls.Add(this.label2);
            this.groupBoxReserve.Controls.Add(this.label1);
            this.groupBoxReserve.Controls.Add(this.dateTimePickerReserveDate);
            this.groupBoxReserve.Controls.Add(this.buttonReserve);
            this.groupBoxReserve.Controls.Add(this.labelName);
            this.groupBoxReserve.Controls.Add(this.textBoxName);
            this.groupBoxReserve.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReserve.Name = "groupBoxReserve";
            this.groupBoxReserve.Size = new System.Drawing.Size(199, 283);
            this.groupBoxReserve.TabIndex = 9;
            this.groupBoxReserve.TabStop = false;
            this.groupBoxReserve.Text = "Foglalás";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ágyak száma";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(6, 125);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.PlaceholderText = "+36701234567";
            this.textBoxTel.Size = new System.Drawing.Size(177, 23);
            this.textBoxTel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefonszám";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(6, 81);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(177, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Érkezés dátuma";
            // 
            // dateTimePickerReserveDate
            // 
            this.dateTimePickerReserveDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerReserveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReserveDate.Location = new System.Drawing.Point(6, 225);
            this.dateTimePickerReserveDate.Name = "dateTimePickerReserveDate";
            this.dateTimePickerReserveDate.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerReserveDate.TabIndex = 4;
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(115, 254);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(75, 23);
            this.buttonReserve.TabIndex = 5;
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
            this.ClientSize = new System.Drawing.Size(800, 400);
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
        private Label label4;
        private TextBox textBoxTel;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerReserveDate;
        private Button buttonReserve;
        private Label labelName;
        private TextBox textBoxName;
    }
}