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
            this.tabPageReserve = new System.Windows.Forms.TabPage();
            this.tabPageStat = new System.Windows.Forms.TabPage();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.labelHotelOneBed = new System.Windows.Forms.Label();
            this.labelHotelTwoBed = new System.Windows.Forms.Label();
            this.numericUpDownOneBed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTwoBed = new System.Windows.Forms.NumericUpDown();
            this.buttonAddHotel = new System.Windows.Forms.Button();
            this.listBoxHotel = new System.Windows.Forms.ListBox();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageHotels.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOneBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwoBed)).BeginInit();
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
            this.tabControlAdmin.SelectedIndexChanged += new System.EventHandler(this.tabControlAdmin_SelectedIndexChanged);
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
            // tabPageReserve
            // 
            this.tabPageReserve.Location = new System.Drawing.Point(4, 24);
            this.tabPageReserve.Name = "tabPageReserve";
            this.tabPageReserve.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReserve.Size = new System.Drawing.Size(768, 398);
            this.tabPageReserve.TabIndex = 1;
            this.tabPageReserve.Text = "Foglalás";
            this.tabPageReserve.UseVisualStyleBackColor = true;
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
            // textBoxHotelName
            // 
            this.textBoxHotelName.Location = new System.Drawing.Point(6, 37);
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(177, 23);
            this.textBoxHotelName.TabIndex = 0;
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
            // labelHotelOneBed
            // 
            this.labelHotelOneBed.AutoSize = true;
            this.labelHotelOneBed.Location = new System.Drawing.Point(6, 72);
            this.labelHotelOneBed.Name = "labelHotelOneBed";
            this.labelHotelOneBed.Size = new System.Drawing.Size(134, 15);
            this.labelHotelOneBed.TabIndex = 3;
            this.labelHotelOneBed.Text = "Egy ágyas szobák száma";
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
            // numericUpDownOneBed
            // 
            this.numericUpDownOneBed.Location = new System.Drawing.Point(6, 90);
            this.numericUpDownOneBed.Name = "numericUpDownOneBed";
            this.numericUpDownOneBed.Size = new System.Drawing.Size(177, 23);
            this.numericUpDownOneBed.TabIndex = 5;
            // 
            // numericUpDownTwoBed
            // 
            this.numericUpDownTwoBed.Location = new System.Drawing.Point(6, 148);
            this.numericUpDownTwoBed.Name = "numericUpDownTwoBed";
            this.numericUpDownTwoBed.Size = new System.Drawing.Size(177, 23);
            this.numericUpDownTwoBed.TabIndex = 6;
            // 
            // buttonAddHotel
            // 
            this.buttonAddHotel.Location = new System.Drawing.Point(118, 187);
            this.buttonAddHotel.Name = "buttonAddHotel";
            this.buttonAddHotel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddHotel.TabIndex = 7;
            this.buttonAddHotel.Text = "button1";
            this.buttonAddHotel.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOneBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwoBed)).EndInit();
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
    }
}