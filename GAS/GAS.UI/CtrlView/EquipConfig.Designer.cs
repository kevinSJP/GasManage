namespace GAS.UI.CtrlView
{
    partial class EquipConfig
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
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPage_L1 = new System.Windows.Forms.TabPage();
            this.tbPage_L2 = new System.Windows.Forms.TabPage();
            this.btn_create = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lab_Num = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbox_type = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbox_Equip = new System.Windows.Forms.ListBox();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tbPage_L3 = new System.Windows.Forms.TabPage();
            this.lbox_L1 = new System.Windows.Forms.ListBox();
            this.lbox_L2 = new System.Windows.Forms.ListBox();
            this.lbox_L3 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tbPage_L1.SuspendLayout();
            this.tbPage_L2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbPage_L3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(210, 99);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(58, 38);
            this.btn_Left.TabIndex = 1;
            this.btn_Left.Text = "左移";
            this.btn_Left.UseVisualStyleBackColor = true;
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(210, 187);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(58, 34);
            this.btn_Right.TabIndex = 2;
            this.btn_Right.Text = "右移";
            this.btn_Right.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPage_L1);
            this.tabControl1.Controls.Add(this.tbPage_L2);
            this.tabControl1.Controls.Add(this.tbPage_L3);
            this.tabControl1.Location = new System.Drawing.Point(554, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(317, 231);
            this.tabControl1.TabIndex = 6;
            // 
            // tbPage_L1
            // 
            this.tbPage_L1.Controls.Add(this.lbox_L1);
            this.tbPage_L1.Location = new System.Drawing.Point(4, 22);
            this.tbPage_L1.Name = "tbPage_L1";
            this.tbPage_L1.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage_L1.Size = new System.Drawing.Size(309, 205);
            this.tbPage_L1.TabIndex = 0;
            this.tbPage_L1.Text = "L1数据";
            this.tbPage_L1.UseVisualStyleBackColor = true;
            // 
            // tbPage_L2
            // 
            this.tbPage_L2.Controls.Add(this.lbox_L2);
            this.tbPage_L2.Location = new System.Drawing.Point(4, 22);
            this.tbPage_L2.Name = "tbPage_L2";
            this.tbPage_L2.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage_L2.Size = new System.Drawing.Size(309, 205);
            this.tbPage_L2.TabIndex = 1;
            this.tbPage_L2.Text = "L2数据";
            this.tbPage_L2.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(797, 373);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(99, 66);
            this.btn_create.TabIndex = 9;
            this.btn_create.Text = "创建表";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lab_Num);
            this.panel1.Location = new System.Drawing.Point(554, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 100);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 10;
            // 
            // lab_Num
            // 
            this.lab_Num.AutoSize = true;
            this.lab_Num.Location = new System.Drawing.Point(21, 43);
            this.lab_Num.Name = "lab_Num";
            this.lab_Num.Size = new System.Drawing.Size(65, 12);
            this.lab_Num.TabIndex = 9;
            this.lab_Num.Text = "设备数量：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.lbox_type);
            this.groupBox1.Location = new System.Drawing.Point(4, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 411);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可选设备：";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(124, 342);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(50, 48);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(27, 342);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(50, 48);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // lbox_type
            // 
            this.lbox_type.FormattingEnabled = true;
            this.lbox_type.ItemHeight = 12;
            this.lbox_type.Location = new System.Drawing.Point(27, 20);
            this.lbox_type.Name = "lbox_type";
            this.lbox_type.Size = new System.Drawing.Size(147, 292);
            this.lbox_type.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_Read);
            this.groupBox2.Controls.Add(this.lbox_Equip);
            this.groupBox2.Location = new System.Drawing.Point(288, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 411);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择加入的设备：";
            // 
            // lbox_Equip
            // 
            this.lbox_Equip.FormattingEnabled = true;
            this.lbox_Equip.ItemHeight = 12;
            this.lbox_Equip.Location = new System.Drawing.Point(37, 20);
            this.lbox_Equip.Name = "lbox_Equip";
            this.lbox_Equip.Size = new System.Drawing.Size(124, 292);
            this.lbox_Equip.TabIndex = 6;
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(37, 342);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(51, 48);
            this.btn_Read.TabIndex = 7;
            this.btn_Read.Text = "读取";
            this.btn_Read.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(119, 342);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(51, 48);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "更改";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // tbPage_L3
            // 
            this.tbPage_L3.Controls.Add(this.lbox_L3);
            this.tbPage_L3.Location = new System.Drawing.Point(4, 22);
            this.tbPage_L3.Name = "tbPage_L3";
            this.tbPage_L3.Size = new System.Drawing.Size(309, 205);
            this.tbPage_L3.TabIndex = 2;
            this.tbPage_L3.Text = "L3数据";
            this.tbPage_L3.UseVisualStyleBackColor = true;
            // 
            // lbox_L1
            // 
            this.lbox_L1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_L1.FormattingEnabled = true;
            this.lbox_L1.ItemHeight = 12;
            this.lbox_L1.Location = new System.Drawing.Point(3, 3);
            this.lbox_L1.Name = "lbox_L1";
            this.lbox_L1.Size = new System.Drawing.Size(303, 199);
            this.lbox_L1.TabIndex = 0;
            // 
            // lbox_L2
            // 
            this.lbox_L2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_L2.FormattingEnabled = true;
            this.lbox_L2.ItemHeight = 12;
            this.lbox_L2.Location = new System.Drawing.Point(3, 3);
            this.lbox_L2.Name = "lbox_L2";
            this.lbox_L2.Size = new System.Drawing.Size(303, 199);
            this.lbox_L2.TabIndex = 0;
            // 
            // lbox_L3
            // 
            this.lbox_L3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_L3.FormattingEnabled = true;
            this.lbox_L3.ItemHeight = 12;
            this.lbox_L3.Location = new System.Drawing.Point(0, 0);
            this.lbox_L3.Name = "lbox_L3";
            this.lbox_L3.Size = new System.Drawing.Size(309, 205);
            this.lbox_L3.TabIndex = 0;
            // 
            // EquipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Left);
            this.Name = "EquipConfig";
            this.Size = new System.Drawing.Size(944, 457);
            this.tabControl1.ResumeLayout(false);
            this.tbPage_L1.ResumeLayout(false);
            this.tbPage_L2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tbPage_L3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPage_L1;
        private System.Windows.Forms.TabPage tbPage_L2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lab_Num;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox lbox_type;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.ListBox lbox_Equip;
        private System.Windows.Forms.ListBox lbox_L1;
        private System.Windows.Forms.TabPage tbPage_L3;
        private System.Windows.Forms.ListBox lbox_L2;
        private System.Windows.Forms.ListBox lbox_L3;
    }
}
