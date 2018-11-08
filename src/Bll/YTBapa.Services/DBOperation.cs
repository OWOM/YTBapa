using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace YTBapa.Services
{
    class DBOperation
    {
        private static string connectionString = "Data Source=.;Initial Catalog=MySchools;User ID=sa;Password=sa;";

        // ConfigurationManager.ConnectionStrings["BookShopPlus"].ConnectionString;
        private static SqlConnection _conn;
        /// <summary>
        /// 连接对象
        /// </summary>
        public static SqlConnection Conn
        {
            get
            {
                if (_conn == null)
                {
                    _conn = new SqlConnection(connectionString);
                    _conn.Open();
                }
                else if (_conn.State == ConnectionState.Broken)
                {
                    _conn.Close();
                    _conn.Open();
                }
                else if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                return _conn;

            }

        }


        /// <summary>
        /// 关闭连接
        /// </summary>
        public static void CloseConnection()
        {
            if (Conn == null) return;

            if (Conn.State == ConnectionState.Broken || Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="type">执行类型（默认是sql）</param>
        /// <param name="param">参数</param>
        /// <returns>返回单个值  int </returns>
        public static int ExecuteNonQuery(string sql, SqlParameter[] param = null, CommandType type = CommandType.Text)
        {
            //创建执行对象
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Conn);
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);//设置参数
                }
                cmd.CommandType = type;//sql按照指定类型去解析

                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// 返回单个值
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="type">执行类型（默认是sql）</param>
        /// <param name="param">参数</param>
        /// <returns>返回受影响的行数  int </returns>
        public static int ExecuteScalar(string sql, SqlParameter[] param = null, CommandType type = CommandType.Text)
        {
            //创建执行对象
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Conn);
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);//设置参数
                }
                cmd.CommandType = type;//sql按照指定类型去解析

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }


        /// <summary>
        /// 查询(需手动关闭 请调用 CloseConnection())
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="type">执行类型（默认是sql）</param>
        /// <param name="param">参数</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string sql, SqlParameter[] param = null, CommandType type = CommandType.Text)
        {
            //创建执行对象
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Conn);
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);//设置参数
                }
                cmd.CommandType = type;//sql按照指定类型去解析
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
