using System;
using System.Configuration;
using System.Data.SqlClient;
using pasLogger;
using System.Data;

namespace paSSQL
{
    public static class SQL
    {
        private static SqlConnection connection;
        private static string MyConnectionString;

        static SQL()
        {
            MyConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            connection = new SqlConnection(MyConnectionString);
        }
        // decimals
        public static float GetSQLDecimal(string AQuery)
        {
            float LResult = 0;
            try
            {
                SqlCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = (AQuery);
                SqlDataReader SR = cmd.ExecuteReader();
                if (SR.HasRows)
                {
                    SR.Read();
                    LResult = (float)SR.GetDecimal(0);
                }
                SR.Close();
                connection.Close();
                return LResult;                
            }   
            catch (Exception E)
            {
                Logger.Log(LogType.ltError, string.Format("Class SQL GetSQLDecimal: {0}", E.Message));
            }
            return LResult;
        }
        // datavieuw
        public static DataView GetSQLDataView(string AQuery)
        {
            DataView LResult = null;
            try
            {
                SqlCommand cmd;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = (AQuery);

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                LResult = ds.Tables[0].DefaultView;
                
                connection.Close();
                return LResult;
            }
            catch (Exception E)
            {
                Logger.Log(LogType.ltError, string.Format("Class SQL GetSQLDataVieuw: {0}", E.Message));
            }
            return LResult;
        }
        

        









        //public static /**/ InsertSQL(string AQuery)
        //{
        //    /**/LResult = null;
        //    try
        //    {
        //        SqlCommand cmd;
        //        connection.Open();
        //        cmd = connection.CreateCommand();
        //        cmd.CommandText = (AQuery);

        //        SqlDataAdapter adap = new SqlDataAdapter(cmd);
        //        DataSet ds = new DataSet();
        //        adap.Fill(ds);
        //        LResult = ds.Tables[0].DefaultView;

        //        connection.Close();
        //        return LResult;
        //    }
        //    catch (Exception E)
        //    {
        //        Logger.Log(LogType.ltError, string.Format("Class SQL GetSQLDecimal: {0}", E.Message));
        //    }
        //    return LResult;
        //}
    }
}
