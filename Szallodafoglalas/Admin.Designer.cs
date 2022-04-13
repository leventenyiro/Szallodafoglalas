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
            this.tabControlAdmin.SuspendLayout();
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tabPageHotels;
        private TabPage tabPageReserve;
        private TabPage tabPageStat;
    }
}