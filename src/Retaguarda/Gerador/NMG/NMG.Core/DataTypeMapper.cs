using System;
using NMG.Core.Domain;

namespace NMG.Core
{
    public class DataTypeMapper
    {
        public Type MapFromDBType(ServerType serverType, string dataType, int? dataLength, int? dataPrecision,
                                  int? dataScale)
        {
            switch (serverType)
            {
                case ServerType.SqlServer:
                    return MapFromSqlServerDBType(dataType, dataLength, dataPrecision, dataScale);
                case ServerType.Oracle:
                    return MapFromOracleDBType(dataType, dataLength, dataPrecision, dataScale);
                case ServerType.MySQL:
                    return MapFromMySqlDBType(dataType, dataLength, dataPrecision, dataScale);
                case ServerType.PostgreSQL:
                    return MapFromPostgreDBType(dataType, dataLength, dataPrecision, dataScale);
                case ServerType.SQLite:
                    return MapFromSqliteDbType(dataType, dataLength, dataPrecision, dataScale);
            }
            return MapFromDBType(dataType, dataLength, dataPrecision, dataScale);
        }

        //http://msdn.microsoft.com/en-us/library/cc716729.aspx
        private Type MapFromSqlServerDBType(string dataType, int? dataLength, int? dataPrecision, int? dataScale)
        {
            return MapFromDBType(dataType, dataLength, dataPrecision, dataScale);
        }

        //http://docs.oracle.com/cd/B28359_01/win.111/b28376/appendixa.htm
        private Type MapFromOracleDBType(string dataType, int? dataLength, int? dataPrecision, int? dataScale)
        {
            if (string.Equals(dataType, "DATE", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dataType, "TIMESTAMP", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dataType, "TIMESTAMP WITH TIME ZONE", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dataType, "TIMESTAMP WITH LOCAL TIME ZONE", StringComparison.OrdinalIgnoreCase))
            {
                return typeof (System.DateTime);
            }

            if (string.Equals(dataType, "NUMBER", StringComparison.OrdinalIgnoreCase))
            {
                if (dataScale.GetValueOrDefault(0) == 0) //Integer type
                {
                    if (dataPrecision.GetValueOrDefault(0) >= 1 && dataPrecision.GetValueOrDefault(0) <= 4)
                        return typeof (System.Int16);
                    if (dataPrecision.GetValueOrDefault(0) >= 5 && dataPrecision.GetValueOrDefault(0) <= 9)
                        return typeof (System.Int32);
                    if (dataPrecision.GetValueOrDefault(0) >= 10 && dataPrecision.GetValueOrDefault(0) <= 18)
                        return typeof (System.Int64);
                }
                if (dataScale.GetValueOrDefault(0) > 0) //Floating type
                {
                    if (dataPrecision.GetValueOrDefault(0) >= 1 && dataPrecision.GetValueOrDefault(0) <= 7)
                        return typeof (System.Single);
                    if (dataPrecision.GetValueOrDefault(0) >= 8 && dataPrecision.GetValueOrDefault(0) <= 15)
                        return typeof (System.Double);
                }
                return typeof (System.Decimal);
            }

            if (string.Equals(dataType, "BLOB", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dataType, "BFILE *", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dataType, "LONG RAW", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dataType, "RAW", StringComparison.OrdinalIgnoreCase))
            {
                return typeof (byte[]);
            }

            if (string.Equals(dataType, "INTERVAL DAY TO SECOND", StringComparison.OrdinalIgnoreCase))
            {
                return typeof (System.TimeSpan);
            }

            if (string.Equals(dataType, "INTERVAL YEAR TO MONTH", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dataType, "LONG", StringComparison.OrdinalIgnoreCase))
            {
                return typeof (System.Int64);
            }

            if (string.Equals(dataType, "BINARY_FLOAT", StringComparison.OrdinalIgnoreCase))
            {
                return typeof (System.Single);
            }

            if (string.Equals(dataType, "BINARY_DOUBLE", StringComparison.OrdinalIgnoreCase))
            {
                return typeof (System.Double);
            }

            if (string.Equals(dataType, "BINARY_INTEGER", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dataType, "FLOAT", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(dataType, "REAL", StringComparison.OrdinalIgnoreCase))
            {
                return typeof (System.Decimal);
            }

            return typeof (System.String);
        }

        private Type MapFromMySqlDBType(string dataType, int? dataLength, int? dataPrecision, int? dataScale)
        {
            return MapFromDBType(dataType, dataLength, dataPrecision, dataScale);
        }

        private Type MapFromPostgreDBType(string dataType, int? dataLength, int? dataPrecision, int? dataScale)
        {
            return MapFromDBType(dataType, dataLength, dataPrecision, dataScale);
        }

        private Type MapFromSqliteDbType(string dataType, int? dataLength, int? dataPrecision, int? dataScale)
        {
            return MapFromDBType(dataType, dataLength, dataPrecision, dataScale);
        }
        private Type MapFromDBType(string dataType, int? dataLength, int? dataPrecision, int? dataScale)
        {
            string DATATYPE = dataType.ToUpperInvariant();

            if (DATATYPE.Contains("DATE") || DATATYPE.Contains("TIMESTAMP") || DATATYPE.Contains("TIME"))
                return typeof(DateTime);
            else if (DATATYPE.Contains("NUMBER") || DATATYPE.Contains("LONG") || DATATYPE.Contains("BIGINT"))
                    return typeof(long);
            else if (DATATYPE.Contains("SMALLINT") )
                return typeof(Int16);
            else if (DATATYPE.Contains("TINYINT") )
                return typeof(Byte);
            else if (DATATYPE.Contains("INT") || DATATYPE.Contains("INTERVAL YEAR TO MONTH") 
                || DATATYPE.Contains("BINARY_INTEGER") || DATATYPE.Contains("INTEGER"))
                    return typeof(int);
            else if (DATATYPE.Contains("BINARY_DOUBLE") || DATATYPE.Contains("NUMERIC"))
                    return typeof(double);
            else if (DATATYPE.Contains("BINARY_FLOAT") || DATATYPE.Contains("FLOAT"))
                    return typeof(float);
            else if (DATATYPE.Contains("BLOB") || DATATYPE.Contains("BFILE *") 
                || DATATYPE.Contains("LONG RAW") || DATATYPE.Contains("IMAGE")
                || DATATYPE.Contains("VARBINARY"))
                    return typeof(byte[]);
            else if (DATATYPE.Contains("INTERVAL DAY TO SECOND"))
                    return typeof(TimeSpan);
            else if (DATATYPE.Contains("BIT") || DATATYPE.Contains("BOOLEAN") )
                    return typeof(Boolean);
            else if (DATATYPE.Contains("DECIMAL") || DATATYPE.Contains("MONEY") )
                    return typeof(decimal);
            else if (DATATYPE.Contains("REAL") )
                    return typeof(Single);
            else if (DATATYPE.Contains("UNIQUEIDENTIFIER") )
                    return typeof(Guid);
            else
            {
                        return dataType.Contains("int")
                               ? typeof(int)
                               : // CHAR, CLOB, NCLOB, NCHAR, XMLTYPE, VARCHAR2, NCHAR, NTEXT
                           typeof(string);
            }
            
        }
/*
        private Type MapFromDBType(string dataType, int? dataLength, int? dataPrecision, int? dataScale)
        {
            switch (dataType.ToUpperInvariant())
            {
                case "DATE":
                case "DATETIME":
                case "DATETIME2":
                case "TIMESTAMP":
                case "TIMESTAMP WITH TIME ZONE":
                case "TIMESTAMP WITH LOCAL TIME ZONE":
                case "SMALLDATETIME":
                case "TIME":
                    return typeof (DateTime);

                case "NUMBER":
                case "LONG":
                case "BIGINT":
                    return typeof (long);

                case "SMALLINT":
                    return typeof (Int16);

                case "TINYINT":
                    return typeof (Byte);

                case "INT":
                case "INTERVAL YEAR TO MONTH":
                case "BINARY_INTEGER":
                case "INTEGER":
                    return typeof (int);

                case "BINARY_DOUBLE":
                case "NUMERIC":
                    return typeof (double);

                case "FLOAT":
                case "BINARY_FLOAT":
                    return typeof (float);

                case "BLOB":
                case "BFILE *":
                case "LONG RAW":
                case "BINARY":
                case "IMAGE":
                case "VARBINARY":
                    return typeof (byte[]);

                case "INTERVAL DAY TO SECOND":
                    return typeof (TimeSpan);

                case "BIT":
                case "BOOLEAN":
                    return typeof (Boolean);

                case "DECIMAL":
                case "MONEY":
                case "SMALLMONEY":
                    return typeof (decimal);

                case "REAL":
                    return typeof (Single);

                case "UNIQUEIDENTIFIER":
                    return typeof (Guid);

                default:
                    return dataType.Contains("int")
                               ? typeof (int)
                               : // CHAR, CLOB, NCLOB, NCHAR, XMLTYPE, VARCHAR2, NCHAR, NTEXT
                           typeof (string);
            }
        }
 */
    }
}