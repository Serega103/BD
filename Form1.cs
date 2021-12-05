using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace bd
{
    
    public partial class Form1 : Form
    {
        public static string connectStr = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = CompanyDB.mdb";
        private OleDbConnection myConnection;
        private SqlConnection sqlConnection = null;
        private SqlCommand sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectStr);
            myConnection.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyDBDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.companyDBDataSet.Заказы);
            sqlConnection = new SqlConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\sous\bd\bd\CompanyDB.mdb");

            sqlConnection.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Delet] FROM Заказы", sqlConnection);
         }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
