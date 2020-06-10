using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreDapperSample.Database
{
    public interface IDBHelper
    {
        IDbConnection OpenConnection();
    }
}
