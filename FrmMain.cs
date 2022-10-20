using Microsoft.Data.SqlClient;

namespace WFA221019
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new(Program.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new(
                cmdText: 
                "SELECT szemely.id, ev, nev " +
                "FROM szemely " +
                "INNER JOIN kituntetes " +
                "ON szemely.id = szemelyId " +
                "ORDER BY ev DESC, nev ASC;",
                connection: sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int rowIndex = dgvMain.Rows.Add(
                    sqlDataReader["id"],
                    sqlDataReader["ev"],
                    sqlDataReader["nev"]);
                if (sqlDataReader.GetInt32(1) % 2 == 0)
                    dgvMain.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }
    }
}