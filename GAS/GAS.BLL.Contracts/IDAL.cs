using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace GAS.BLL
{
    public interface IDAL
    {

        bool LoginChek(string Name, string Pass);
        void TestCon();
    }
}
