using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4MsSqlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbHelper = DbFactory.CreatDb(Config.DbType);
            var dtList = dbHelper.GetDbTables();
            foreach (DbTable dbTable in dtList)
            {
                string tableName = dbTable.TableName;
                var dbColList = dbHelper.GetDbColumns(tableName, "dbo");
                var primaryKey = dbColList.FirstOrDefault(p => p.IsPrimaryKey);
                Console.WriteLine("tableName:" + tableName);
            }
        }
    }
}
