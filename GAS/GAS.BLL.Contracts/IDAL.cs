using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GAS.BLL
{
    public interface IDAL
    {
        #region login使用
        bool[] LoginChek(string Name, string Pass);
        void TestCon();
        #endregion

        #region EquipConfig使用
        DataSet QueryTable(string TableName);
        #endregion
    }
}
