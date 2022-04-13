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
            this.groupBoxReserve = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageHotels.SuspendLayout();
            this.tabPageReserve.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOneBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwoBed)).BeginInit();
            this.groupBoxReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.tabPageReserve.Controls.Add(this.listBox1);
            this.tabPageReserve.Controls.Add(this.groupBoxReserve);
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
            this.buttonAddHotel.Text = "Hozzáadás";
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
            // groupBoxReserve
            // 
            this.groupBoxReserve.Controls.Add(this.button1);
            this.groupBoxReserve.Controls.Add(this.numericUpDown1);
            this.groupBoxReserve.Controls.Add(this.numericUpDown2);
            this.groupBoxReserve.Controls.Add(this.label3);
            this.groupBoxReserve.Controls.Add(this.label4);
            this.groupBoxReserve.Controls.Add(this.labelName);
            this.groupBoxReserve.Controls.Add(this.textBox1);
            this.groupBoxReserve.Location = new System.Drawing.Point(6, 6);
            this.groupBoxReserve.Name = "groupBoxReserve";
            this.groupBoxReserve.Size = new System.Drawing.Size(199, 218);
            this.groupBoxReserve.TabIndex = 3;
            this.groupBoxReserve.TabStop = false;
            this.groupBoxReserve.Text = "Foglalás";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Foglalás";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 148);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(177, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(6, 90);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(177, 23);
            this.numericUpDown2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Egy ágyas szobák száma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Egy ágyas szobák száma";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 23);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(211, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(551, 379);
            this.listBox1.TabIndex = 4;
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
            this.tabPageReserve.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOneBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTwoBed)).EndInit();
            this.groupBoxReserve.ResumeLayout(false);
            this.groupBoxReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private ListBox listBox1;
        private GroupBox groupBoxReserve;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label4;
        private Label labelName;
        private TextBox textBox1;
    }
}