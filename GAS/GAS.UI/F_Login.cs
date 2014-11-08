using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using GAS.BLL;

namespace GAS.UI
{
    public partial class F_Login : Form
    {

        #region 定义
        F_AdminForm adminForm;
        F_UserForm userform;
        IDAL  DALFunc;
        #endregion

        public F_Login()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (textName.Text != "" & textPass.Text != "")
            {
                bool LoginRes = DALFunc.LoginChek(textName.Text.Trim(), textPass.Text.Trim());

                if (LoginRes)
                {
                    ModuleClass.UIData.Login_Name = textName.Text.Trim();
                    ModuleClass.UIData.Login_n = (int)(this.Tag);
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textName.Text = "";
                    textPass.Text = "";
                }
                

                MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textName.Text = "";
                textPass.Text = "";
            }
            else
                MessageBox.Show("请将登录信息添写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void F_Login_Activated(object sender, EventArgs e)
        {
            textName.Focus();
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                textPass.Focus();
        }

        private void textPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                butLogin.Focus();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            try
            {
                DALFunc.TestCon();
                textName.Text = "";
                textPass.Text = "";
            }
            catch
            {
                MessageBox.Show("数据库连接失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
