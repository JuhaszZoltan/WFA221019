using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA221019
{
    public partial class FrmReszletek : Form
    {
        public int SzemelyId { get; set; }

        public FrmReszletek(int szemelyId)
        {
            InitializeComponent();
            SzemelyId = szemelyId;
        }

        private void FrmReszletek_Load(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new(Program.ConnectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new(
                cmdText: "SELECT nev " +
                "FROM szemely " +
                $"WHERE id = {SzemelyId};",
                connection:sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            lblNev.Text = $"{sqlDataReader["nev"]}";
            sqlDataReader.Close();

            sqlCommand = new(
                cmdText: "SELECT megnevezes " +
                "FROM foglalkozas " +
                $"WHERE szemelyId = {SzemelyId};",
                connection: sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            lblFoglalkozasok.Text = string.Empty;
            while (sqlDataReader.Read())
                lblFoglalkozasok.Text += $"[*] {sqlDataReader["megnevezes"]}\n";
            sqlDataReader.Close();

            sqlCommand = new(
                cmdText: "SELECT ev " +
                "FROM kituntetes " +
                $"WHERE szemelyId = {SzemelyId} " +
                $"ORDER BY ev ASC;",
                connection: sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            lblEvszamok.Text = string.Empty;
            while (sqlDataReader.Read())
                lblEvszamok.Text += $"{sqlDataReader["ev"]}, ";
            lblEvszamok.Text = lblEvszamok.Text.TrimEnd(' ').TrimEnd(',');
        }
    }
}
