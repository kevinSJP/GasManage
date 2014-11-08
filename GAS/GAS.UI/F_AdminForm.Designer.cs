namespace GAS.UI
{
    partial class F_AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AdminForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_EquipConf = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_FileConf = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_AlgConf = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_UserMana = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ReLogin = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_EquipConf,
            this.toolStripSeparator1,
            this.btn_FileConf,
            this.toolStripSeparator2,
            this.btn_AlgConf,
            this.toolStripSeparator3,
            this.btn_UserMana,
            this.toolStripSeparator4,
            this.btn_ReLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_EquipConf
            // 
            this.btn_EquipConf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_EquipConf.Image = ((System.Drawing.Image)(resources.GetObject("btn_EquipConf.Image")));
            this.btn_EquipConf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EquipConf.Name = "btn_EquipConf";
            this.btn_EquipConf.Size = new System.Drawing.Size(248, 31);
            this.btn_EquipConf.Text = "设备与节点数配置";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btn_FileConf
            // 
            this.btn_FileConf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_FileConf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_FileConf.Image = ((System.Drawing.Image)(resources.GetObject("btn_FileConf.Image")));
            this.btn_FileConf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FileConf.Name = "btn_FileConf";
            this.btn_FileConf.Size = new System.Drawing.Size(190, 31);
            this.btn_FileConf.Text = "算法文件管理";
            this.btn_FileConf.ToolTipText = "算法文件管理";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // btn_AlgConf
            // 
            this.btn_AlgConf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_AlgConf.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlgConf.Image")));
            this.btn_AlgConf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AlgConf.Name = "btn_AlgConf";
            this.btn_AlgConf.Size = new System.Drawing.Size(190, 31);
            this.btn_AlgConf.Text = "预测算法配置";
            this.btn_AlgConf.ToolTipText = "预测算法配置";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // btn_UserMana
            // 
            this.btn_UserMana.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_UserMana.Image = ((System.Drawing.Image)(resources.GetObject("btn_UserMana.Image")));
            this.btn_UserMana.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_UserMana.Name = "btn_UserMana";
            this.btn_UserMana.Size = new System.Drawing.Size(132, 31);
            this.btn_UserMana.Text = "用户管理";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // btn_ReLogin
            // 
            this.btn_ReLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_ReLogin.Image = ((System.Drawing.Image)(resources.GetObject("btn_ReLogin.Image")));
            this.btn_ReLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ReLogin.Name = "btn_ReLogin";
            this.btn_ReLogin.Size = new System.Drawing.Size(132, 31);
            this.btn_ReLogin.Text = "配置完成";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 467);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(944, 467);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // F_AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "F_AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统配置工具";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_EquipConf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_FileConf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_AlgConf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_UserMana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_ReLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}