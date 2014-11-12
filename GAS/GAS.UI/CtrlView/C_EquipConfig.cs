using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GAS.BLL;

namespace GAS.UI.CtrlView
{
    public partial class C_EquipConfig : UserControl
    {
        IDAL DALFunc;
        DataSet dataset = new DataSet();

        public C_EquipConfig()
        {
            InitializeComponent();
        }

        private void C_EquipConfig_Load(object sender, EventArgs e)
        {
            
            lbox_Type.Items.Clear();
            dataset.Clear();
            dataset = DALFunc.QueryTable("EquipTypeAbl");
            lbox_Type.Items.Add(dataset.Tables[0].Rows[1]);

            lbox_Equip.Items.Clear();
            dataset.Clear();
            dataset = DALFunc.QueryTable("EquipTypeSlet");
            lbox_Type.Items.Add(dataset.Tables[0].Rows[1]);

            txtbox_Num.Text = "";
            lbox_L1.Items.Clear();
            lbox_L2.Items.Clear();
            lbox_L3.Items.Clear();
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FormView.F_AddEquip addequip = new FormView.F_AddEquip();
            addequip.Show();
            addequip.Dispose();

            dataset.Clear();
            lbox_Type.Items.Clear();
            dataset = DALFunc.QueryTable("EquipTypeAbl");
            lbox_Type.Items.Add(dataset.Tables[0].Rows[1]);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            lbox_Type.Items.RemoveAt(lbox_Type.SelectedIndex);
            /////////删除表一行数据

            dataset.Clear();
            lbox_Equip.Items.Clear();
            dataset = DALFunc.QueryTable("EquipTypeSlet");
            lbox_Type.Items.Add(dataset.Tables[0].Rows[1]);
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            lbox_Equip.Items.Add(lbox_Type.SelectedItem);
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            lbox_Equip.Items.RemoveAt(lbox_Equip.SelectedIndex);
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            string L1, L2, L3;
            dataset.Clear();
            dataset = DALFunc.QueryTable("EquipTypeSlet");
            txtbox_Num.Text = dataset.Tables[0].Rows[3].ToString();

            L1 = dataset.Tables[0].Rows[4].ToString();
            string[] L1D = L1.Split(';');
            lbox_L1.Items.Clear();
            for (int i = 0; i < L1D.Count();i++ )
            {
                lbox_L1.Items.Add(L1D[i]);
            }
            
            L2 = dataset.Tables[0].Rows[5].ToString();
            string[] L2D = L2.Split(';');
            lbox_L2.Items.Clear();
            for (int i = 0; i < L2D.Count(); i++)
            {
                lbox_L2.Items.Add(L2D[i]);
            }
            
            L3 = dataset.Tables[0].Rows[6].ToString();
            string[] L3D = L3.Split(';');
            lbox_L3.Items.Clear();
            for (int i = 0; i < L3D.Count(); i++)
            {
                lbox_L3.Items.Add(L3D[i]);
            }
            

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            /////写EquipTypeSlet数据表
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //////////创建数据表
        }


    }
}
