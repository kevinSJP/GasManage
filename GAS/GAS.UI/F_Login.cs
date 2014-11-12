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
using GAS.DAL;

namespace GAS.UI
{
    public partial class F_Login : Form
    {

        #region 定义   
        //IDAL  DALFunc;
        DataClass DALFunc = new DataClass();
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
            /////////登陆验证/////////
            LoginFoemation();
            ////////测试方法/////////
            //TestLogin();
            
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
            ///////测试数据库连接/////////
            LoadFormation();
            
        }

        /// <summary>
        /// 测试数据库连接
        /// </summary>
        private void LoadFormation()
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

        /// <summary>
        /// 登录验证
        /// </summary>
        private void LoginFoemation()
        {
            if (textName.Text != "" & textPass.Text != "")
            {
                bool[] LoginRes = DALFunc.LoginChek(textName.Text.Trim(), textPass.Text.Trim());
                //bool[] LoginRes = new bool[2]; LoginRes[0] = true; LoginRes[1] = true;

                if (LoginRes[0])
                {
                    ModuleClass.UIData.Login_Name = textName.Text.Trim();
                    //ModuleClass.UIData.Login_n = (int)(this.Tag);
                    //this.Close();
                    if (LoginRes[1])
                    {
                        if (DialogResult.Yes == MessageBox.Show("您是否使用配置功能?", "通讯录", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            F_AdminForm adminForm = new F_AdminForm();
                            adminForm.ShowDialog();
                            this.Hide();
                            adminForm.Dispose();
                            
                        }
                        else
                        {
                            F_UserForm userform = new F_UserForm();
                            userform.ShowDialog();
                            this.Hide();
                            userform.Dispose();
                            
                        }

                        
                    }
                    else
                    {
                        F_UserForm userform = new F_UserForm();
                        userform.Show();
                        userform.Dispose();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textName.Text = "";
                    textPass.Text = "";

                }


            }
            else
                MessageBox.Show("请将登录信息添写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 跳转测试用
        /// </summary>
        private void TestLogin()
        {
            F_AdminForm adminForm = new F_AdminForm();
            adminForm.Show();
            adminForm.Dispose();
            this.Hide();
        }


    }
}
