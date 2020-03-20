using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public static class DbHelper
    {
        //创建数据库连接

        private delegate SqlConnection SqlCon();

        //private static SqlCon myCon = dataInfo => new SqlConnection(dataInfo);
        private static readonly SqlCon MyCon = () =>
        {
            string dataInfo = ConfigurationManager.ConnectionStrings[$"sqlCon"].ConnectionString;
            return new SqlConnection(dataInfo);
        };

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="sqlcmd">T-Sql语句</param>
        /// <returns>返回数据集</returns>
        public static DataSet GetDataSet(string sqlcmd)
        {
            // var myConnection = myCon("server=MECHREVO\\SQLEXPRESS;database=No9Home;uid=sa;pwd=admin");
            var myConnection = MyCon();

            try
            {
                myConnection.Open();
                SqlDataAdapter mAdapter = new SqlDataAdapter(sqlcmd, myConnection);
                DataSet dataSet = new DataSet();
                mAdapter.Fill(dataSet);
                myConnection.Close();
                return dataSet;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                myConnection.Close();
                throw;
            }
        }

        public static int GetUpData(string sqlcmd)
        {
            var myConnection = MyCon();

            try
            {
                myConnection.Open();
                var resault = new SqlCommand(sqlcmd,myConnection);
                return resault.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}