namespace GAS.UI.CtrlView
{
    partial class FileConfig
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbox_type = new System.Windows.Forms.ListBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.gbox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Browse1 = new System.Windows.Forms.Button();
            this.btn_Browse2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.gbox1.SuspendLayout();
            this.gbox2.SuspendLayout();
            this.gbox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.btn_Update);
            this.gbox1.Controls.Add(this.btn_Delete);
            this.gbox1.Controls.Add(this.btn_Add);
            this.gbox1.Controls.Add(this.lbox_type);
            this.gbox1.Location = new System.Drawing.Point(47, 29);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(381, 411);
            this.gbox1.TabIndex = 12;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "可选算法：";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(223, 342);
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
            this.lbox_type.Size = new System.Drawing.Size(246, 292);
            this.lbox_type.TabIndex = 5;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(124, 342);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(50, 48);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // gbox2
            // 
            this.gbox2.Controls.Add(this.lab1);
            this.gbox2.Controls.Add(this.btn_Browse1);
            this.gbox2.Controls.Add(this.textBox1);
            this.gbox2.Location = new System.Drawing.Point(453, 65);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(430, 100);
            this.gbox2.TabIndex = 13;
            this.gbox2.TabStop = false;
            this.gbox2.Text = "算法路径设置：";
            // 
            // gbox3
            // 
            this.gbox3.Controls.Add(this.lab2);
            this.gbox3.Controls.Add(this.btn_Browse2);
            this.gbox3.Controls.Add(this.textBox2);
            this.gbox3.Location = new System.Drawing.Point(453, 241);
            this.gbox3.Name = "gbox3";
            this.gbox3.Size = new System.Drawing.Size(430, 100);
            this.gbox3.TabIndex = 14;
            this.gbox3.TabStop = false;
            this.gbox3.Text = "算法配置文件路径：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 21);
            this.textBox1.TabIndex = 0;
            // 
            // btn_Browse1
            // 
            this.btn_Browse1.Location = new System.Drawing.Point(319, 47);
            this.btn_Browse1.Name = "btn_Browse1";
            this.btn_Browse1.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse1.TabIndex = 1;
            this.btn_Browse1.Text = "浏览";
            this.btn_Browse1.UseVisualStyleBackColor = true;
            // 
            // btn_Browse2
            // 
            this.btn_Browse2.Location = new System.Drawing.Point(319, 40);
            this.btn_Browse2.Name = "btn_Browse2";
            this.btn_Browse2.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse2.TabIndex = 3;
            this.btn_Browse2.Text = "浏览";
            this.btn_Browse2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 21);
            this.textBox2.TabIndex = 2;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(23, 52);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(65, 12);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "选择文件：";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(33, 45);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(65, 12);
            this.lab2.TabIndex = 4;
            this.lab2.Text = "选择文件：";
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(733, 384);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(114, 56);
            this.btn_Enter.TabIndex = 15;
            this.btn_Enter.Text = "确认";
            this.btn_Enter.UseVisualStyleBackColor = true;
            // 
            // FileConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.gbox3);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.gbox1);
            this.Name = "FileConfig";
            this.Size = new System.Drawing.Size(944, 467);
            this.gbox1.ResumeLayout(false);
            this.gbox2.ResumeLayout(false);
            this.gbox2.PerformLayout();
            this.gbox3.ResumeLayout(false);
            this.gbox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox lbox_type;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.GroupBox gbox3;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btn_Browse1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Button btn_Browse2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Enter;
    }
}
