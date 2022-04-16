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
            this.groupBoxReserveDelete = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.listBoxReserves = new System.Windows.Forms.ListBox();
            this.listBoxReserveHotel = new System.Windows.Forms.ListBox();
            this.groupBoxReserve = new System.Windows.Forms.GroupBox();
            this.dateTimePickerReserveDate = new System.Windows.Forms.DateTimePicker();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxReserveDelete.SuspendLayout();
            this.groupBoxReserve.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxReserveDelete
            // 
            this.groupBoxReserveDelete.Controls.Add(this.buttonDelete);
            this.groupBoxReserveDelete.Controls.Add(this.labelId);
            this.groupBoxReserveDelete.Controls.Add(this.textBoxId);
            this.groupBoxReserveDelete.Location = new System.Drawing.Point(21, 325);
            this.groupBoxReserveDelete.Name = "groupBoxReserveDelete";
            this.groupBoxReserveDelete.Size = new System.Drawing.Size(199, 90);
            this.groupBoxReserveDelete.TabIndex = 10;
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
            this.listBoxReserves.Location = new System.Drawing.Point(508, 36);
            this.listBoxReserves.Name = "listBoxReserves";
            this.listBoxReserves.Size = new System.Drawing.Size(275, 379);
            this.listBoxReserves.TabIndex = 9;
            // 
            // listBoxReserveHotel
            // 
            this.listBoxReserveHotel.FormattingEnabled = true;
            this.listBoxReserveHotel.ItemHeight = 15;
            this.listBoxReserveHotel.Location = new System.Drawing.Point(226, 36);
            this.listBoxReserveHotel.Name = "listBoxReserveHotel";
            this.listBoxReserveHotel.Size = new System.Drawing.Size(275, 379);
            this.listBoxReserveHotel.TabIndex = 8;
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
            this.groupBoxReserve.Controls.Add(this.textBoxName);
            this.groupBoxReserve.Location = new System.Drawing.Point(21, 36);
            this.groupBoxReserve.Name = "groupBoxReserve";
            this.groupBoxReserve.Size = new System.Drawing.Size(199, 283);
            this.groupBoxReserve.TabIndex = 7;
            this.groupBoxReserve.TabStop = false;
            this.groupBoxReserve.Text = "Foglalás";
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 23);
            this.textBoxName.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(6, 81);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(177, 23);
            this.textBoxEmail.TabIndex = 11;
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
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxReserveDelete);
            this.Controls.Add(this.listBoxReserves);
            this.Controls.Add(this.listBoxReserveHotel);
            this.Controls.Add(this.groupBoxReserve);
            this.Name = "User";
            this.Text = "User";
            this.groupBoxReserveDelete.ResumeLayout(false);
            this.groupBoxReserveDelete.PerformLayout();
            this.groupBoxReserve.ResumeLayout(false);
            this.groupBoxReserve.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxReserveDelete;
        private Button buttonDelete;
        private Label labelId;
        private TextBox textBoxId;
        private ListBox listBoxReserves;
        private ListBox listBoxReserveHotel;
        private GroupBox groupBoxReserve;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerReserveDate;
        private Button buttonReserve;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxTel;
        private Label label3;
        private TextBox textBoxEmail;
    }
}