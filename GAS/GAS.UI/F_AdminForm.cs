using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAS.UI
{
    public partial class F_AdminForm : Form
    {
        #region 实例控件
        CtrlView.C_EquipConfig equipconf = new CtrlView.C_EquipConfig();
        CtrlView.C_FileConfig fileConf = new CtrlView.C_FileConfig();
        CtrlView.C_SetAlgorithm setalg = new CtrlView.C_SetAlgorithm();
        FormView.F_User user = new FormView.F_User();
        F_UserForm userform = new F_UserForm();
        //ModuleClass.UIData uidata = new ModuleClass.UIData();
        #endregion

        public F_AdminForm()
        {
            InitializeComponent();
            
        }

        private void F_AdminForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
            
        }

        private void btn_EquipConf_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();           
            panel1.Controls.Add(equipconf);
        }

        private void btn_FileConf_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(fileConf);
        }

        private void btn_AlgConf_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(setalg);
        }

        private void btn_UserMana_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(pictureBox1);
            pictureBox1.Dock=DockStyle.Fill;
            user.Show();
            user.Dispose();
        }

        private void btn_Complet_Click(object sender, EventArgs e)
        {
            ModuleClass.UIData.CloseConf = false;
            userform.Show();
            userform.Dispose();
            this.Close();

        }

        private void F_AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ModuleClass.UIData.CloseConf==true)
                Application.Exit();
        }


    }
}
