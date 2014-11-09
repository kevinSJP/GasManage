using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GAS.DAL
{
    public class DataClass
    {
        #region 定义与实例化
        BaseClass baseClass=new BaseClass();
        #endregion


        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="Name">姓名</param>
        /// <param name="Pass">密码</param>
        /// <returns>check结果</returns>
        bool[] LoginChek(string Name, string Pass)
        {
            bool[] ifcom=new bool[2];
            SqlDataReader temDR = baseClass.getcom("select * from UserPope where Name='" + Name + "' and Pass='" + Pass + "'");
            ifcom[0] = temDR.Read();
            if (ifcom[0])
            {
                BaseClass.My_con.Close();
                BaseClass.My_con.Dispose();
                string i = temDR.GetString(4);
                ifcom[1]= bool.Parse(i);
            }
            BaseClass.con_close();
            return ifcom;
        }

        void TestCon()
        {
            baseClass.con_open();  //连接数据库
            BaseClass.con_close();
            
        }
    }
}
