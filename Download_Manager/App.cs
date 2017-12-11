using System;
using System.Collections.Generic;
using System.Text;

namespace Download_Manager
{
    static class App
    {
        static DataBase db;
        public static DataBase DB
        {
            get
            {
                if (db == null)
                {
                    db = new DataBase();
                }
                return db;
            }
        }
    }
}
