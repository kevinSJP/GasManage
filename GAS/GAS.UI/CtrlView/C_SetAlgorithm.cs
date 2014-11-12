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
    public partial class C_SetAlgorithm : UserControl
    {
        DataClass DALFunc = new DataClass();
        DataSet dataset = new DataSet();

        public C_SetAlgorithm()
        {
            InitializeComponent();
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            lbox_UsedAlg.Items.Add(lbox_Alg.SelectedItem);
        }

        private void C_SetAlgorithm_Load(object sender, EventArgs e)
        {
            lbox_Equip.Items.Clear();
            dataset.Clear();
            dataset = DALFunc.QueryTable("EquipTypeAbl");
            lbox_Equip.Items.Add(dataset.Tables[0].Rows[1]);

            lbox_Alg.Items.Clear();
            dataset.Clear();
            dataset = DALFunc.QueryTable("AlgTypeAbl");
            lbox_Alg.Items.Add(dataset.Tables[0].Rows[1]);
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            lbox_UsedAlg.Items.RemoveAt(lbox_UsedAlg.SelectedIndex);
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            /////更新表AlgTypeSlet
            /////创建算法表
        }
    }
}
