namespace Szallodafoglalas
{
    partial class User
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
            this.tabPageReserve = new System.Windows.Forms.TabPage();
            this.groupBoxReserve = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerReserveFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReserveTo = new System.Windows.Forms.DateTimePicker();
            this.listBoxReserveHotel = new System.Windows.Forms.ListBox();
            this.listBoxReserves = new System.Windows.Forms.ListBox();
            this.groupBoxReserveDelete = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageReserve.SuspendLayout();
            this.groupBoxReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxReserveDelete.SuspendLayout();
            this.tabControlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageReserve
            // 
            this.tabPageReserve.Controls.Add(this.groupBoxReserveDelete);
            this.tabPageReserve.Controls.Add(this.listBoxReserves);
            this.tabPageReserve.Controls.Add(this.listBoxReserveHotel);
            this.tabPageReserve.Controls.Add(this.groupBoxReserve);
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
            this.groupBoxReserve.Controls.Add(this.dateTimePickerReserveTo);
            this.groupBoxReserve.Controls.Add(this.dateTimePickerReserveFrom);
            this.groupBoxReserve.Controls.Add(this.button1);
            this.groupBoxReserve.Controls.Add(this.numericUpDown1);
            this.groupBoxReserve.Controls.Add(this.numericUpDown2);
            this.groupBoxReserve.Controls.Add(this.label3);
            this.groupBoxReserve.Controls.Add(this.label4);
            this.groupBoxReserve.Controls.Add(this.labelName);
            this.groupBoxReserve.Controls.Add(this.textBox);
            this.groupBoxReserve.Location = new System.Drawing.Point(6, 6);
            this.groupBoxReserve.Name = "groupBoxReserve";
            this.groupBoxReserve.Size = new System.Drawing.Size(199, 283);
            this.groupBoxReserve.TabIndex = 3;
            this.groupBoxReserve.TabStop = false;
            this.groupBoxReserve.Text = "Foglalás";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 37);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(177, 23);
            this.textBox.TabIndex = 0;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Egy ágyas szobák száma";
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
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(6, 90);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(177, 23);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 148);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(177, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Foglalás";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerReserveFrom
            // 
            this.dateTimePickerReserveFrom.Location = new System.Drawing.Point(6, 187);
            this.dateTimePickerReserveFrom.Name = "dateTimePickerReserveFrom";
            this.dateTimePickerReserveFrom.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerReserveFrom.TabIndex = 8;
            // 
            // dateTimePickerReserveTo
            // 
            this.dateTimePickerReserveTo.Location = new System.Drawing.Point(6, 216);
            this.dateTimePickerReserveTo.Name = "dateTimePickerReserveTo";
            this.dateTimePickerReserveTo.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerReserveTo.TabIndex = 9;
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
            // listBoxReserves
            // 
            this.listBoxReserves.FormattingEnabled = true;
            this.listBoxReserves.ItemHeight = 15;
            this.listBoxReserves.Location = new System.Drawing.Point(493, 6);
            this.listBoxReserves.Name = "listBoxReserves";
            this.listBoxReserves.Size = new System.Drawing.Size(275, 379);
            this.listBoxReserves.TabIndex = 5;
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
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(6, 35);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(177, 23);
            this.textBoxId.TabIndex = 0;
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
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(118, 64);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // tabControlUser
            // 
            this.tabControlUser.Controls.Add(this.tabPageReserve);
            this.tabControlUser.Controls.Add(this.tabPage1);
            this.tabControlUser.Location = new System.Drawing.Point(12, 12);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(776, 426);
            this.tabControlUser.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 398);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlUser);
            this.Name = "User";
            this.Text = "User";
            this.tabPageReserve.ResumeLayout(false);
            this.groupBoxReserve.ResumeLayout(false);
            this.groupBoxReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxReserveDelete.ResumeLayout(false);
            this.groupBoxReserveDelete.PerformLayout();
            this.tabControlUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPageReserve;
        private GroupBox groupBoxReserveDelete;
        private Button buttonDelete;
        private Label labelId;
        private TextBox textBoxId;
        private ListBox listBoxReserves;
        private ListBox listBoxReserveHotel;
        private GroupBox groupBoxReserve;
        private DateTimePicker dateTimePickerReserveTo;
        private DateTimePicker dateTimePickerReserveFrom;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label4;
        private Label labelName;
        private TextBox textBox;
        private TabControl tabControlUser;
        private TabPage tabPage1;
    }
}