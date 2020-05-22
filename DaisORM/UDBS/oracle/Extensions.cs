using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaisORM.UDBS.Oracle
{
    public static class Extensions
    {
        public static void AddWithValue(this OracleParameterCollection cmd, string parameterName, object value)
        {
            cmd.Add(parameterName, value);
        }
    }
}
