﻿namespace NMG.Core.Util
{
    public class StringConstants
    {
        public static string ORACLE_CONN_STR_TEMPLATE = "Data Source=XE;User Id=Sample; Password=password;";

        public static string SQL_CONN_STR_TEMPLATE =
            "Data Source=localhost;Initial Catalog=Sample;Integrated Security=SSPI;";

        public static string POSTGRESQL_CONN_STR_TEMPLATE =
            "server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=password;";

        public static string MYSQL_CONN_STR_TEMPLATE =
            "Server=localhost;Port=3306;Database=letrunghieu;Uid=root;Pwd=a;";

        public static string SQLITE_CONN_STR_TEMPLATE =
            "Data Source=local.db;Version=3;New=False;Compress=True;";
    }
}