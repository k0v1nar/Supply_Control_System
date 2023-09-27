using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SpecialFormLibrary
{
    public class SqlModule
    {
        private SqlConnection _sqlConnection; // Поле соединения с сервером

        public SqlModule(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public int ExeChangeTable(string command)
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, _sqlConnection);
                int countString = sqlCommand.ExecuteNonQuery();
                _sqlConnection.Close();
                return countString;
            }
            catch
            {
                _sqlConnection.Close();
                return -1;
            }
        }

        public string ExeGetValue(string command)
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand(command, _sqlConnection);
            object result = sqlCommand.ExecuteScalar();
            if (result == null)
            {
                _sqlConnection.Close();
                return "-1";
            }
            string value = result.ToString();
            _sqlConnection.Close();
            return value;
        }

        public DataTable ExeGetTable(string command)
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand(command, _sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.CurrentCulture;
            adapter.Fill(table);
            _sqlConnection.Close();
            return table;
        }

        public ConnectionState GetState()
        {
            return _sqlConnection.State;
        }

        public string GetInfo()
        {
            return _sqlConnection.ConnectionString;
        }
    }
}
