using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;

namespace Nutricao.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
