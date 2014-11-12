using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAS.UI.ModuleClass
{
    class UIData
    {
        #region 全局变量
        public static int Login_n = 0;          //用户登录与重新登录的标识
        public static string Login_ID = "";     //定义全局变量，记录当前登录的用户编号
        public static string Login_Name = "";   //定义全局变量，记录当前登录的用户名
        public static bool CloseConf=true;
        #endregion
    }
}
