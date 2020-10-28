using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham
{
    public class dbConnect
    {
        //public static string conq = Decrypt(ConfigurationManager.ConnectionStrings["ketnoi"].ConnectionString, "myname");
        public static string conq = ConfigurationManager.ConnectionStrings["ketnoi"].ConnectionString;
        public static SqlConnection conn = new SqlConnection(conq);
        public void disconnect()
        {
            if ((conn != null) && (conn.State == ConnectionState.Open))
                conn.Close();
        }
        public static string Decrypt(string encrypt, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;
                    byte[] data = Convert.FromBase64String(encrypt);
                    return Encoding.UTF8.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
        public static string Encrypt(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;
                    byte[] data = Encoding.UTF8.GetBytes(source);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
        public DataTable GetData(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable GetData(string procName, SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
                cmd.Parameters.AddRange(para);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public int ExecuteSQL(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }

        public int ExecuteSQL(string procName, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            if (para != null)
                cmd.Parameters.AddRange(para);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
    }
}
