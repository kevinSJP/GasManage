using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GAS.BLL;
using GAS.DAL;

namespace GAS.UI.CtrlView
{
    public partial class C_FileConfig : UserControl
    {
        DataClass DALFunc = new DataClass();
        DataSet dataset = new DataSet();
        
        public C_FileConfig()
        {
            InitializeComponent();
        }

        private void C_FileConfig_Load(object sender, EventArgs e)
        {
            lbox_Type.Items.Clear();
            dataset = DALFunc.QueryTable("AlgTypeAbl");
            lbox_Type.Items.Add(dataset.Tables[0].Rows[1]);

            textBox1.Clear();
            textBox2.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FormView.F_AddAlgorithm addalg = new FormView.F_AddAlgorithm();
            addalg.Show();
            addalg.Dispose();

            lbox_Type.Items.Clear();
            dataset = DALFunc.QueryTable("AlgTypeAbl");
            lbox_Type.Items.Add(dataset.Tables[0].Rows[1]);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ////update表数据
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            lbox_Type.Items.RemoveAt(lbox_Type.SelectedIndex);
            /////删除一行数据
        }

        private void btn_Browse1_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName; //得到文件名 
                textBox1.Text = fileName;
            }
        }

        private void btn_Browse2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName; //得到文件名 
                textBox1.Text = fileName;
            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            ////update表数据
        }
    }
}
