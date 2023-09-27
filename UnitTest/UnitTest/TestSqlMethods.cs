using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecialFormLibrary;
using System.Data;

namespace UnitTest
{
    [TestClass]
    public class TestSqlMethods
    {
        static private string connectionString = @"Data Source = DESKTOP-KAQULM4; Initial catalog = Project; Integrated Security = True";

        [TestMethod]
        public void TestCreatingSqlConnention()
        {
            SqlModule sqlModule = new SqlModule(connectionString);
            Assert.AreEqual(connectionString, sqlModule.GetInfo());
        }

        [TestMethod]
        public void TestSelectIdQuery()
        {
            SqlModule sqlModule = new SqlModule(connectionString);
            string id = sqlModule.ExeGetValue($"SELECT TOP 1 _id FROM Type_Accounts");
            Assert.AreEqual("0", id);
        }

        [TestMethod]
        public void TestGetRowQuery()
        {
            SqlModule sqlModule = new SqlModule(connectionString);
            DataTable table = sqlModule.ExeGetTable($"SELECT TOP 1 * FROM Type_Accounts");
            bool isIdTrue = table.Rows[0][0].ToString() == "0";
            bool isTypeTrue = table.Rows[0][1].ToString() == "Admin";
            Assert.IsTrue(isIdTrue && isTypeTrue);
        }

        [TestMethod]
        public void TestGetTableQuery()
        {
            SqlModule sqlModule = new SqlModule(connectionString);
            DataTable table = sqlModule.ExeGetTable($"SELECT * FROM Type_Accounts");
            bool isCountRowsTrue = table.Rows.Count == 4;
            bool isCountColumnsTrue = table.Columns.Count == 2;
            Assert.IsTrue(isCountRowsTrue && isCountColumnsTrue);
        }

        [TestMethod]
        public void TestInsertQuery()
        {
            SqlModule sqlModule = new SqlModule(connectionString);
            string lastString = sqlModule.ExeGetValue($"SELECT TOP 1 _type FROM Type_Accounts ORDER BY _id DESC");
            sqlModule.ExeChangeTable($"INSERT INTO Type_Accounts (_type) VALUES ('new')");
            string newString = sqlModule.ExeGetValue($"SELECT TOP 1 _type FROM Type_Accounts ORDER BY _id DESC");
            Assert.AreNotEqual(lastString, newString);
        }

        [TestMethod]
        public void TestUpdateQuery()
        {
            SqlModule sqlModule = new SqlModule(connectionString);
            sqlModule.ExeChangeTable($"UPDATE Type_Accounts SET _type = 'new2' WHERE _id = 4");
            string newString = sqlModule.ExeGetValue($"SELECT TOP 1 _type FROM Type_Accounts ORDER BY _id DESC");
            Assert.AreEqual(newString, "new2");
        }

        [TestMethod]
        public void TestDeleteQuery()
        {
            SqlModule sqlModule = new SqlModule(connectionString);
            int countBefore = int.Parse(sqlModule.ExeGetValue($"SELECT COUNT(_id) FROM Type_Accounts"));
            sqlModule.ExeChangeTable($"DELETE FROM Type_Accounts WHERE _id = 4");
            sqlModule.ExeChangeTable("DBCC CHECKIDENT('Type_Accounts', RESEED, 3); ");
            int countAfter = int.Parse(sqlModule.ExeGetValue($"SELECT COUNT(_id) FROM Type_Accounts"));
            Assert.AreEqual(countBefore - 1, countAfter);
        }
    }
}
