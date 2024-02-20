using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
