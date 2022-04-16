namespace Szallodafoglalas
{
    partial class Admin
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageHotels = new System.Windows.Forms.TabPage();
            this.listBoxHotel = new System.Windows.Forms.ListBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddHotel = new System.Windows.Forms.Button();
            this.numericUpDownTwoBed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOneBed = new System.Windows.Forms.NumericUpDown();
            this.labelHotelTwoBed = new System.Windows.Forms.Label();
            this.labelHotelOneBed = new System.Windows.Forms.Label();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.tabPageReserve = new System.Windows.Forms.TabPage();
            this.groupBoxReserve = new System.Windows.Forms.GroupBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerReserveDate = new System.Windows.Forms.DateTimePicker();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxReserveName = new System.Windows.Forms.TextBox();
            this.groupBoxReserveDelete = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.listBoxReserves = new System.Windows.Forms.ListBox();
            this.listBoxReserveHotel = new System.Windows.Forms.ListBox();
            this.tabPageStat = new System.Windows.Forms.TabPage();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageHotels.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwoBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOneBed)).BeginInit();
            this.tabPageReserve.SuspendLayout();
            this.groupBoxReserve.SuspendLayout();
            this.groupBoxReserveDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageHotels);
            this.tabControlAdmin.Controls.Add(this.tabPageReserve);
            this.tabControlAdmin.Controls.Add(this.tabPageStat);
            this.tabControlAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(776, 426);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPageHotels
            // 
            this.tabPageHotels.Controls.Add(this.listBoxHotel);
            this.tabPageHotels.Controls.Add(this.groupBoxAdd);
            this.tabPageHotels.Location = new System.Drawing.Point(4, 24);
            this.tabPageHotels.Name = "tabPageHotels";
            this.tabPageHotels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHotels.Size = new System.Drawing.Size(768, 398);
            this.tabPageHotels.TabIndex = 0;
            this.tabPageHotels.Text = "Hotelek";
            this.tabPageHotels.UseVisualStyleBackColor = true;
            // 
            // listBoxHotel
            // 
            this.listBoxHotel.FormattingEnabled = true;
            this.listBoxHotel.ItemHeight = 15;
            this.listBoxHotel.Location = new System.Drawing.Point(211, 6);
            this.listBoxHotel.Name = "listBoxHotel";
            this.listBoxHotel.Size = new System.Drawing.Size(551, 379);
            this.listBoxHotel.TabIndex = 3;
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
            this.groupBoxAdd.TabIndex = 2;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Hozzáadás";
            // 
            // buttonAddHotel
            // 
            this.buttonAddHotel.Location = new System.Drawing.Point(118, 187);
            this.buttonAddHotel.Name = "buttonAddHotel";
            this.buttonAddHotel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddHotel.TabIndex = 7;
            this.buttonAddHotel.Text = "Hozzáadás";
            this.buttonAddHotel.UseVisualStyleBackColor = true;
            this.buttonAddHotel.Click += new System.EventHandler(this.buttonAddHotel_Click);
            // 
            // numericUpDownTwoBed
            // 
            this.numericUpDownTwoBed.Location = new System.Drawing.Point(6, 148);
            this.numericUpDownTwoBed.Name = "numericUpDownTwoBed";
            this.numericUpDownTwoBed.Size = new System.Drawing.Size(177, 23);
            this.numericUpDownTwoBed.TabIndex = 6;
            // 
            // numericUpDownOneBed
            // 
            this.numericUpDownOneBed.Location = new System.Drawing.Point(6, 90);
            this.numericUpDownOneBed.Name = "numericUpDownOneBed";
            this.numericUpDownOneBed.Size = new System.Drawing.Size(177, 23);
            this.numericUpDownOneBed.TabIndex = 5;
            // 
            // labelHotelTwoBed
            // 
            this.labelHotelTwoBed.AutoSize = true;
            this.labelHotelTwoBed.Location = new System.Drawing.Point(0, 130);
            this.labelHotelTwoBed.Name = "labelHotelTwoBed";
            this.labelHotelTwoBed.Size = new System.Drawing.Size(134, 15);
            this.labelHotelTwoBed.TabIndex = 4;
            this.labelHotelTwoBed.Text = "Egy ágyas szobák száma";
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
            // tabPageReserve
            // 
            this.tabPageReserve.Controls.Add(this.groupBoxReserve);
            this.tabPageReserve.Controls.Add(this.groupBoxReserveDelete);
            this.tabPageReserve.Controls.Add(this.listBoxReserves);
            this.tabPageReserve.Controls.Add(this.listBoxReserveHotel);
            this.tabPageReserve.Location = new System.Drawing.Point(4, 24);
            this.tabPageReserve.Name = "tabPageReserve";
            this.tabPageReserve.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReserve.Size = new System.Drawing.Size(768, 398);
            this.tabPageReserve.TabIndex = 1;
            this.tabPageReserve.Text = "Foglalás";
            this.tabPageReserve.UseVisualStyleBackColor = true;
            // 
            // groupBoxReserve
            // 
            this.groupBoxReserve.Controls.Add(this.textBoxTel);
            this.groupBoxReserve.Controls.Add(this.label3);
            this.groupBoxReserve.Controls.Add(this.textBoxEmail);
            this.groupBoxReserve.Controls.Add(this.label2);
            this.groupBoxReserve.Controls.Add(this.label1);
            this.groupBoxReserve.Controls.Add(this.dateTimePickerReserveDate);
            this.groupBoxReserve.Controls.Add(this.buttonReserve);
            this.groupBoxReserve.Controls.Add(this.labelName);
            this.groupBoxReserve.Controls.Add(this.textBoxReserveName);
            this.groupBoxReserve.Location = new System.Drawing.Point(6, 6);
            this.groupBoxReserve.Name = "groupBoxReserve";
            this.groupBoxReserve.Size = new System.Drawing.Size(199, 283);
            this.groupBoxReserve.TabIndex = 8;
            this.groupBoxReserve.TabStop = false;
            this.groupBoxReserve.Text = "Foglalás";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(6, 125);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(177, 23);
            this.textBoxTel.TabIndex = 13;
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
            this.textBoxEmail.TabIndex = 11;
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
            this.label1.Location = new System.Drawing.Point(0, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Érkezés dátuma";
            // 
            // dateTimePickerReserveDate
            // 
            this.dateTimePickerReserveDate.Location = new System.Drawing.Point(6, 199);
            this.dateTimePickerReserveDate.Name = "dateTimePickerReserveDate";
            this.dateTimePickerReserveDate.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerReserveDate.TabIndex = 8;
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(115, 254);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(75, 23);
            this.buttonReserve.TabIndex = 7;
            this.buttonReserve.Text = "Foglalás";
            this.buttonReserve.UseVisualStyleBackColor = true;
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
            this.groupBoxReserveDelete.Location = new System.Drawing.Point(6, 295);
            this.groupBoxReserveDelete.Name = "groupBoxReserveDelete";
            this.groupBoxReserveDelete.Size = new System.Drawing.Size(199, 90);
            this.groupBoxReserveDelete.TabIndex = 6;
            this.groupBoxReserveDelete.TabStop = false;
            this.groupBoxReserveDelete.Text = "Foglalás törlése";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(118, 64);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
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
            // listBoxReserves
            // 
            this.listBoxReserves.FormattingEnabled = true;
            this.listBoxReserves.ItemHeight = 15;
            this.listBoxReserves.Location = new System.Drawing.Point(493, 6);
            this.listBoxReserves.Name = "listBoxReserves";
            this.listBoxReserves.Size = new System.Drawing.Size(275, 379);
            this.listBoxReserves.TabIndex = 5;
            // 
            // listBoxReserveHotel
            // 
            this.listBoxReserveHotel.FormattingEnabled = true;
            this.listBoxReserveHotel.ItemHeight = 15;
            this.listBoxReserveHotel.Location = new System.Drawing.Point(211, 6);
            this.listBoxReserveHotel.Name = "listBoxReserveHotel";
            this.listBoxReserveHotel.Size = new System.Drawing.Size(275, 379);
            this.listBoxReserveHotel.TabIndex = 4;
            // 
            // tabPageStat
            // 
            this.tabPageStat.Location = new System.Drawing.Point(4, 24);
            this.tabPageStat.Name = "tabPageStat";
            this.tabPageStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStat.Size = new System.Drawing.Size(768, 398);
            this.tabPageStat.TabIndex = 2;
            this.tabPageStat.Text = "Statisztika";
            this.tabPageStat.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageHotels.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwoBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOneBed)).EndInit();
            this.tabPageReserve.ResumeLayout(false);
            this.groupBoxReserve.ResumeLayout(false);
            this.groupBoxReserve.PerformLayout();
            this.groupBoxReserveDelete.ResumeLayout(false);
            this.groupBoxReserveDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tabPageHotels;
        private TabPage tabPageReserve;
        private TabPage tabPageStat;
        private ListBox listBoxHotel;
        private GroupBox groupBoxAdd;
        private Button buttonAddHotel;
        private NumericUpDown numericUpDownTwoBed;
        private NumericUpDown numericUpDownOneBed;
        private Label labelHotelTwoBed;
        private Label labelHotelOneBed;
        private Label labelHotelName;
        private TextBox textBoxHotelName;
        private ListBox listBoxReserveHotel;
        private GroupBox groupBoxReserveDelete;
        private Button buttonDelete;
        private Label labelId;
        private TextBox textBoxId;
        private ListBox listBoxReserves;
        private GroupBox groupBoxReserve;
        private TextBox textBoxTel;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerReserveDate;
        private Button buttonReserve;
        private Label labelName;
        private TextBox textBoxReserveName;
    }
}