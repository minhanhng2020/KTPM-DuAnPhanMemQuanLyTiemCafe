namespace DuAnPhanMemQuanLyTiemCafe
{
    partial class fTableServices
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnCửaSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTableStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTableStatus = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.flpTableStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaoTácToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1016, 26);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thaoTácToolStripMenuItem
            // 
            this.thaoTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chuyểnCửaSổToolStripMenuItem,
            this.thayĐổiNgườiDùngToolStripMenuItem});
            this.thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            this.thaoTácToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.thaoTácToolStripMenuItem.Text = "Thao Tác";
            // 
            // chuyểnCửaSổToolStripMenuItem
            // 
            this.chuyểnCửaSổToolStripMenuItem.Name = "chuyểnCửaSổToolStripMenuItem";
            this.chuyểnCửaSổToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.chuyểnCửaSổToolStripMenuItem.Text = "Chuyển Cửa Sổ";
            // 
            // thayĐổiNgườiDùngToolStripMenuItem
            // 
            this.thayĐổiNgườiDùngToolStripMenuItem.Name = "thayĐổiNgườiDùngToolStripMenuItem";
            this.thayĐổiNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.thayĐổiNgườiDùngToolStripMenuItem.Text = "Thay Đổi Người Dùng";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // flpTableStatus
            // 
            this.flpTableStatus.Controls.Add(this.dgvTableStatus);
            this.flpTableStatus.Location = new System.Drawing.Point(0, 29);
            this.flpTableStatus.Name = "flpTableStatus";
            this.flpTableStatus.Size = new System.Drawing.Size(573, 550);
            this.flpTableStatus.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(579, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 332);
            this.panel1.TabIndex = 9;
            // 
            // dgvTableStatus
            // 
            this.dgvTableStatus.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvTableStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableStatus.Location = new System.Drawing.Point(3, 3);
            this.dgvTableStatus.Name = "dgvTableStatus";
            this.dgvTableStatus.RowTemplate.Height = 24;
            this.dgvTableStatus.Size = new System.Drawing.Size(570, 547);
            this.dgvTableStatus.TabIndex = 0;
            // 
            // fTableServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTableStatus);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.Name = "fTableServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch Vụ Bàn - Chương Trình Quản Lý Tiệm Cafe";
            this.Load += new System.EventHandler(this.fTableServices_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flpTableStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnCửaSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTableStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTableStatus;

    }
}