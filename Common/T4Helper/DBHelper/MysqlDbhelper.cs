using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Common.T4Helper.DBHelper
{
    public class EntityHelper
    {
        public static List<Entity> GetEntities(string connectionString, List<string> databases)
        {
            var list = new List<Entity>();

            // 数据库连接
            var conn = new MySqlConnection(@"server=127.0.0.1;uid=root;pwd=123456;charset=utf8;");

            // 需要解析的数据库
            var database = new List<string> { "fyt_cms" };
            try
            {
                conn.Open();
                var dbs = string.Join("','", databases.ToArray());
                var cmd = string.Format(@"SELECT `information_schema`.`COLUMNS`.`TABLE_SCHEMA`
                                                    ,`information_schema`.`COLUMNS`.`TABLE_NAME`
                                                    ,`information_schema`.`COLUMNS`.`COLUMN_NAME`
                                                    ,`information_schema`.`COLUMNS`.`DATA_TYPE`
                                                    ,`information_schema`.`COLUMNS`.`COLUMN_COMMENT`
                                                    ,`information_schema`.`COLUMNS`.`COLUMN_KEY`
                                                    ,`information_schema`.`COLUMNS`.`CHARACTER_MAXIMUM_LENGTH`
                                                    ,`information_schema`.`COLUMNS`.`NUMERIC_PRECISION`
                                                    ,`information_schema`.`COLUMNS`.`NUMERIC_SCALE`
                                                    ,`information_schema`.`COLUMNS`.`IS_NULLABLE`
                                                    ,`information_schema`.`TABLES`.`TABLE_COMMENT`
                                                FROM `information_schema`.`COLUMNS`,`information_schema`.`TABLES`
                                                WHERE 
                                                    `information_schema`.`COLUMNS`.`TABLE_SCHEMA`=`information_schema`.`TABLES`.`TABLE_SCHEMA` 
                                                    AND `information_schema`.`COLUMNS`.`TABLE_NAME`=`information_schema`.`TABLES`.`TABLE_NAME`
                                                    AND `information_schema`.`COLUMNS`.`TABLE_SCHEMA` IN ('{0}') ", dbs);
                using (var reader = MySqlHelper.ExecuteReader(conn, cmd))
                {
                    while (reader.Read())
                    {
                        var db = reader["TABLE_SCHEMA"].ToString();
                        var table = reader["TABLE_NAME"].ToString();
                        var column = reader["COLUMN_NAME"].ToString();
                        var type = reader["DATA_TYPE"].ToString();
                        var comment = reader["COLUMN_COMMENT"] == null ? "" : reader["COLUMN_COMMENT"].ToString();
                        var columnKey = reader["COLUMN_KEY"] == null ? "" : reader["COLUMN_KEY"].ToString();
                        var maxLength = reader["CHARACTER_MAXIMUM_LENGTH"] == null ? "" : reader["CHARACTER_MAXIMUM_LENGTH"].ToString();
                        var numPrecision = reader["NUMERIC_PRECISION"] == null ? "" : reader["NUMERIC_PRECISION"].ToString();
                        var numScale = reader["NUMERIC_SCALE"] == null ? "" : reader["NUMERIC_SCALE"].ToString();
                        var isNull = reader["IS_NULLABLE"] == null ? "" : reader["IS_NULLABLE"].ToString();
                        var chTableName = reader["TABLE_COMMENT"] == null ? "" : reader["TABLE_COMMENT"].ToString();
                        var entity = list.FirstOrDefault(x => x.TableName == table);
                        if (entity == null)
                        {
                            entity = new Entity(table, chTableName);
                            entity.Fields.Add(new Field
                            {
                                Name = column,
                                Type = GetCLRType(type),
                                Comment = comment,
                                ColumnKey = columnKey,
                                MaxLength= maxLength,
                                NumPrecision= numPrecision,
                                NumScale= numScale,
                                IsNull= isNull
                            });

                            list.Add(entity);
                        }
                        else
                        {
                            entity.Fields.Add(new Field
                            {
                                Name = column,
                                Type = GetCLRType(type),
                                Comment = comment,
                                ColumnKey = columnKey,
                                MaxLength = maxLength,
                                NumPrecision = numPrecision,
                                NumScale = numScale,
                                IsNull = isNull
                            });
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return list;
        }



        public static string GetCLRType(string dbType)
        {
            switch (dbType)
            {
                case "bigint":
                    return "long";
                case "tinyint":
                case "smallint":
                case "mediumint":
                case "int":
                case "integer":
                    return "int";
                case "double":
                    return "double";
                case "float":
                    return "float";
                case "decimal":
                    return "decimal";
                case "numeric":
                case "real":
                    return "decimal";
                case "bit":
                    return "bool";
                case "date":
                case "time":
                case "year":
                case "datetime":
                case "timestamp":
                    return "DateTime";
                case "tinyblob":
                case "blob":
                case "mediumblob":
                case "longblog":
                case "binary":
                case "varbinary":
                    return "byte[]";
                case "char":
                case "varchar":
                case "tinytext":
                case "text":
                case "mediumtext":
                case "longtext":
                    return "string";
                case "point":
                case "linestring":
                case "polygon":
                case "geometry":
                case "multipoint":
                case "multilinestring":
                case "multipolygon":
                case "geometrycollection":
                case "enum":
                case "set":
                default:
                    return dbType;
            }
        }
    }

    public class Entity
    {
        public Entity()
        {
            this.Fields = new List<Field>();
        }

        public Entity(string name,string cname)
            : this()
        {
            this.TableName = name;
            this.EntityName = TableNameConvertModelName(name);
            this.ChName = cname;
        }

        public string EntityName { get; set; }
        public string TableName { get; set; }
        public string ChName { get; set; }
        public List<Field> Fields { get; set; }

        public static string TableNameConvertModelName(string name)
        {
            var modelName = string.Empty;
            if (string.IsNullOrWhiteSpace(name))
            {
                return name;
            }
            var arrName = name.Split('_');
            if (arrName.Any())
            {
                foreach (var m in arrName)
                {
                    modelName += string.IsNullOrWhiteSpace(m) ? "" : m.Substring(0, 1).ToUpper() + m.Substring(1);
                }
            }
            return modelName;
        }
    }

    public class Field
    {
        public string Name { get; set; }

        public string Type { get; set; }
        public string Comment { get; set; }

        public string ColumnKey { get; set; }

        public string MaxLength { get; set; }

        public string NumPrecision { get; set; }

        public string NumScale { get; set; }
        public string IsNull { get; set; }
    }
}
