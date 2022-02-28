using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FridgeDB
{
    public partial class Form1 : Form
    {
        String connectionString;
        SqlConnection Connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FridgeDB.Properties.Settings.FoodConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFoodTable();
        }

        private void PopulateFoodTable()
        {
            using (Connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FoodType", Connection))
            {
                DataTable foodTable = new DataTable();
                adapter.Fill(foodTable);

                ListFood.DisplayMember = "FoodTypeName";
                ListFood.ValueMember = "Id";
                ListFood.DataSource = foodTable;
            }
        }

        private void ListFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFoodNames();
        }

        private void PopulateFoodNames()
        {
            string query = "SELECT Food.Name FROM FoodType INNER JOIN Food.TypeId = FoodType.Id WHERE FoodType.Id = @TypeId";
            using (Connection = new SqlConnection (connectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", ListFood.SelectedValue);
                DataTable FoodNameTable = new DataTable();
                adapter.Fill(FoodNameTable);

                listFoodNames.DisplayMember = "Name";
                listFoodNames.ValueMember = "Id";
                listFoodNames.DataSource = FoodNameTable;
            }
        }
    }
}
