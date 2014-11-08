namespace GAS.UI.CtrlView
{
    partial class C_Query
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spCtn = new System.Windows.Forms.SplitContainer();
            this.CkListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_EndTime = new System.Windows.Forms.Label();
            this.lab_StartTime = new System.Windows.Forms.Label();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.lab_Eq = new System.Windows.Forms.Label();
            this.btn_Query = new System.Windows.Forms.Button();
            this.tbCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DG1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spCtn)).BeginInit();
            this.spCtn.Panel1.SuspendLayout();
            this.spCtn.Panel2.SuspendLayout();
            this.spCtn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).BeginInit();
            this.SuspendLayout();
            // 
            // spCtn
            // 
            this.spCtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spCtn.Location = new System.Drawing.Point(0, 0);
            this.spCtn.Name = "spCtn";
            this.spCtn.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spCtn.Panel1
            // 
            this.spCtn.Panel1.Controls.Add(this.CkListBox1);
            this.spCtn.Panel1.Controls.Add(this.panel1);
            this.spCtn.Panel1.Controls.Add(this.btn_Query);
            // 
            // spCtn.Panel2
            // 
            this.spCtn.Panel2.Controls.Add(this.tbCtrl);
            this.spCtn.Size = new System.Drawing.Size(742, 461);
            this.spCtn.SplitterDistance = 105;
            this.spCtn.TabIndex = 2;
            // 
            // CkListBox1
            // 
            this.CkListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.CkListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.CkListBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CkListBox1.FormattingEnabled = true;
            this.CkListBox1.Items.AddRange(new object[] {
            "煤气实际流量",
            "煤气预测流量",
            "预测误差"});
            this.CkListBox1.Location = new System.Drawing.Point(392, 0);
            this.CkListBox1.Name = "CkListBox1";
            this.CkListBox1.Size = new System.Drawing.Size(185, 105);
            this.CkListBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lab_EndTime);
            this.panel1.Controls.Add(this.lab_StartTime);
            this.panel1.Controls.Add(this.DTP2);
            this.panel1.Controls.Add(this.DTP1);
            this.panel1.Controls.Add(this.cbox1);
            this.panel1.Controls.Add(this.lab_Eq);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 105);
            this.panel1.TabIndex = 0;
            // 
            // lab_EndTime
            // 
            this.lab_EndTime.AutoSize = true;
            this.lab_EndTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_EndTime.Location = new System.Drawing.Point(137, 67);
            this.lab_EndTime.Name = "lab_EndTime";
            this.lab_EndTime.Size = new System.Drawing.Size(80, 16);
            this.lab_EndTime.TabIndex = 11;
            this.lab_EndTime.Text = "截止时间:";
            // 
            // lab_StartTime
            // 
            this.lab_StartTime.AutoSize = true;
            this.lab_StartTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_StartTime.Location = new System.Drawing.Point(137, 31);
            this.lab_StartTime.Name = "lab_StartTime";
            this.lab_StartTime.Size = new System.Drawing.Size(88, 16);
            this.lab_StartTime.TabIndex = 10;
            this.lab_StartTime.Text = "起始时间：";
            // 
            // DTP2
            // 
            this.DTP2.CustomFormat = "yyyy-MM-dd HH:mm";
            this.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP2.Location = new System.Drawing.Point(231, 62);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(144, 21);
            this.DTP2.TabIndex = 9;
            // 
            // DTP1
            // 
            this.DTP1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP1.Location = new System.Drawing.Point(231, 26);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(144, 21);
            this.DTP1.TabIndex = 8;
            // 
            // cbox1
            // 
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Location = new System.Drawing.Point(18, 50);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(95, 20);
            this.cbox1.TabIndex = 7;
            // 
            // lab_Eq
            // 
            this.lab_Eq.AutoSize = true;
            this.lab_Eq.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Eq.Location = new System.Drawing.Point(16, 14);
            this.lab_Eq.Name = "lab_Eq";
            this.lab_Eq.Size = new System.Drawing.Size(72, 16);
            this.lab_Eq.TabIndex = 6;
            this.lab_Eq.Text = "设备号：";
            // 
            // btn_Query
            // 
            this.btn_Query.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Query.Location = new System.Drawing.Point(642, 35);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(77, 48);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            // 
            // tbCtrl
            // 
            this.tbCtrl.Controls.Add(this.tabPage1);
            this.tbCtrl.Controls.Add(this.tabPage2);
            this.tbCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrl.ItemSize = new System.Drawing.Size(100, 18);
            this.tbCtrl.Location = new System.Drawing.Point(0, 0);
            this.tbCtrl.Name = "tbCtrl";
            this.tbCtrl.SelectedIndex = 0;
            this.tbCtrl.Size = new System.Drawing.Size(742, 352);
            this.tbCtrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zg1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // zg1
            // 
            this.zg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zg1.Location = new System.Drawing.Point(3, 3);
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(728, 320);
            this.zg1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DG1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(977, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DG1
            // 
            this.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG1.Location = new System.Drawing.Point(3, 3);
            this.DG1.Name = "DG1";
            this.DG1.RowTemplate.Height = 23;
            this.DG1.Size = new System.Drawing.Size(971, 317);
            this.DG1.TabIndex = 0;
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spCtn);
            this.Name = "Query";
            this.Size = new System.Drawing.Size(742, 461);
            this.spCtn.Panel1.ResumeLayout(false);
            this.spCtn.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spCtn)).EndInit();
            this.spCtn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spCtn;
        public System.Windows.Forms.CheckedListBox CkListBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_EndTime;
        private System.Windows.Forms.Label lab_StartTime;
        private System.Windows.Forms.DateTimePicker DTP2;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.Label lab_Eq;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.TabControl tbCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private ZedGraph.ZedGraphControl zg1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DG1;

    }
}
