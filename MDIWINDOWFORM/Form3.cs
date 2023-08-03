
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MDIWINDOWFORM
{
    public partial class Form3 : Form
    {
        string connectionString = "Data Source=BHAGAT_JI;Initial Catalog=WinCRUD;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ADD1", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string fullname = FullNametxt.Text;
            string city = Citytxt.Text;
            string gender = GetSelectGender();
            string language = GetMultipleSelectValue();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ADD1 (FullName, Gender, Language, City) VALUES (@name, @gender, @language, @city)", con);
                cmd.Parameters.AddWithValue("@name", fullname);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@language", language);
                cmd.Parameters.AddWithValue("@city", city);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data inserted successfully!");
            ClearInputFields();
            LoadData();
        }

        private string GetSelectGender()
        {
            if (Maletxt.Checked)
            {
                return "Male";
            }
            else if (Femaletxt.Checked)
            {
                return "Female";
            }
            else
            {
                return string.Empty;
            }
        }

        private string GetMultipleSelectValue()
        {
            List<String> SelectedSubject = new List<String>();
            if (Englishtxt.Checked)
            {
                SelectedSubject.Add("English");
            }
            if (Hinditxt.Checked)
            {
                SelectedSubject.Add("Hindi");
            }
            if (Sanskrittxt.Checked)
            {
                SelectedSubject.Add("Sanskrit");
            }

            return string.Join(" ", SelectedSubject);
        }

        private void ClearInputFields()
        {
            FullNametxt.Clear();
            Citytxt.Clear();
            Maletxt.Checked = false;
            Femaletxt.Checked = false;
            Hinditxt.Checked = false;
            Englishtxt.Checked = false;
            Sanskrittxt.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve the selected row
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve the desired value from the selected row (in this case, the name)
                string name = selectedRow.Cells["FullName"].Value.ToString();

                UpdateDelete updatedelete = new UpdateDelete(name);
                updatedelete.Show();
            }
        }
    }
}


//private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//{
//    int columnIndex = 1;

//    if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
//    {
//        DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
//        if (selectedRow != null)
//        {
//            DataGridViewCell selectedCell = selectedRow.Cells[columnIndex];
//            if (selectedCell.Value != null)
//            {
//                string cellValue = selectedCell.Value[].ToString();

//                UpdateDelete updatedelete = new UpdateDelete(cellValue);
//                updatedelete.Show();
//            }
//            else
//            {
//                MessageBox.Show("Null Value");
//            }
//        }
//    }
//}


