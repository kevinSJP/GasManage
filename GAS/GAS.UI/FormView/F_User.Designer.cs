namespace GAS.UI.FormView
{
    partial class F_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_User));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_UserAdd = new System.Windows.Forms.ToolStripButton();
            this.tool_UserAmend = new System.Windows.Forms.ToolStripButton();
            this.tool_UserDelete = new System.Windows.Forms.ToolStripButton();
            this.tool_UserPopedom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_Close = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(251, 154);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_UserAdd,
            this.tool_UserAmend,
            this.tool_UserDelete,
            this.tool_UserPopedom,
            this.toolStripSeparator1,
            this.tool_Close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_UserAdd
            // 
            this.tool_UserAdd.Image = ((System.Drawing.Image)(resources.GetObject("tool_UserAdd.Image")));
            this.tool_UserAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_UserAdd.Name = "tool_UserAdd";
            this.tool_UserAdd.Size = new System.Drawing.Size(51, 22);
            this.tool_UserAdd.Text = "添加";
            // 
            // tool_UserAmend
            // 
            this.tool_UserAmend.Image = ((System.Drawing.Image)(resources.GetObject("tool_UserAmend.Image")));
            this.tool_UserAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_UserAmend.Name = "tool_UserAmend";
            this.tool_UserAmend.Size = new System.Drawing.Size(51, 22);
            this.tool_UserAmend.Text = "修改";
            // 
            // tool_UserDelete
            // 
            this.tool_UserDelete.Image = ((System.Drawing.Image)(resources.GetObject("tool_UserDelete.Image")));
            this.tool_UserDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_UserDelete.Name = "tool_UserDelete";
            this.tool_UserDelete.Size = new System.Drawing.Size(51, 22);
            this.tool_UserDelete.Text = "删除";
            // 
            // tool_UserPopedom
            // 
            this.tool_UserPopedom.Image = ((System.Drawing.Image)(resources.GetObject("tool_UserPopedom.Image")));
            this.tool_UserPopedom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_UserPopedom.Name = "tool_UserPopedom";
            this.tool_UserPopedom.Size = new System.Drawing.Size(51, 22);
            this.tool_UserPopedom.Text = "权限";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tool_Close
            // 
            this.tool_Close.Image = ((System.Drawing.Image)(resources.GetObject("tool_Close.Image")));
            this.tool_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Close.Name = "tool_Close";
            this.tool_Close.Size = new System.Drawing.Size(51, 22);
            this.tool_Close.Text = "关闭";
            // 
            // F_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "F_User";
            this.Text = "F_User";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_UserAdd;
        private System.Windows.Forms.ToolStripButton tool_UserAmend;
        private System.Windows.Forms.ToolStripButton tool_UserDelete;
        private System.Windows.Forms.ToolStripButton tool_UserPopedom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tool_Close;
    }
}