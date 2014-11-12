namespace GAS.UI.CtrlView
{
    partial class C_SetAlgorithm
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
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.lbox_Equip = new System.Windows.Forms.ListBox();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.lbox_Alg = new System.Windows.Forms.ListBox();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.lbox_UsedAlg = new System.Windows.Forms.ListBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.gbox1.SuspendLayout();
            this.gbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.lbox_Equip);
            this.gbox1.Location = new System.Drawing.Point(59, 39);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(252, 356);
            this.gbox1.TabIndex = 0;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "所包含设备：";
            // 
            // lbox_Equip
            // 
            this.lbox_Equip.FormattingEnabled = true;
            this.lbox_Equip.ItemHeight = 12;
            this.lbox_Equip.Location = new System.Drawing.Point(38, 56);
            this.lbox_Equip.Name = "lbox_Equip";
            this.lbox_Equip.Size = new System.Drawing.Size(181, 268);
            this.lbox_Equip.TabIndex = 0;
            // 
            // gbox2
            // 
            this.gbox2.Controls.Add(this.lbox_Alg);
            this.gbox2.Controls.Add(this.btn_Right);
            this.gbox2.Controls.Add(this.btn_Left);
            this.gbox2.Controls.Add(this.lbox_UsedAlg);
            this.gbox2.Location = new System.Drawing.Point(357, 39);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(477, 356);
            this.gbox2.TabIndex = 1;
            this.gbox2.TabStop = false;
            this.gbox2.Text = "算法配置：";
            // 
            // lbox_Alg
            // 
            this.lbox_Alg.FormattingEnabled = true;
            this.lbox_Alg.ItemHeight = 12;
            this.lbox_Alg.Location = new System.Drawing.Point(33, 46);
            this.lbox_Alg.Name = "lbox_Alg";
            this.lbox_Alg.Size = new System.Drawing.Size(147, 292);
            this.lbox_Alg.TabIndex = 9;
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(218, 180);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(58, 34);
            this.btn_Right.TabIndex = 8;
            this.btn_Right.Text = "右移";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(218, 72);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(58, 38);
            this.btn_Left.TabIndex = 7;
            this.btn_Left.Text = "左移";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // lbox_UsedAlg
            // 
            this.lbox_UsedAlg.FormattingEnabled = true;
            this.lbox_UsedAlg.ItemHeight = 12;
            this.lbox_UsedAlg.Location = new System.Drawing.Point(309, 46);
            this.lbox_UsedAlg.Name = "lbox_UsedAlg";
            this.lbox_UsedAlg.Size = new System.Drawing.Size(124, 292);
            this.lbox_UsedAlg.TabIndex = 10;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(808, 420);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_Enter.TabIndex = 2;
            this.btn_Enter.Text = "确认";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // C_SetAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.gbox1);
            this.Name = "C_SetAlgorithm";
            this.Size = new System.Drawing.Size(944, 467);
            this.Load += new System.EventHandler(this.C_SetAlgorithm_Load);
            this.gbox1.ResumeLayout(false);
            this.gbox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.ListBox lbox_Equip;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.ListBox lbox_Alg;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.ListBox lbox_UsedAlg;
        private System.Windows.Forms.Button btn_Enter;
    }
}
