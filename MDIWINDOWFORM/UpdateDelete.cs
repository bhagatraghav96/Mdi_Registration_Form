using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MDIWINDOWFORM
{
   
        public partial class UpdateDelete : Form
        {
            string connectionString = "Data Source=BHAGAT_JI;Initial Catalog=WinCRUD;Integrated Security=True";
            private int recordid;
            public UpdateDelete()
            {
                InitializeComponent();
            }

            public UpdateDelete(string name)
            {
                InitializeComponent();
                FullNametxt.Text = name;
            LoadData();
            }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ADD1 WHERE FullName= @name", con);
                cmd.Parameters.AddWithValue("@name", FullNametxt.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    recordid = Convert.ToInt32(reader["ID"]);
                    Citytxt.Text = reader["City"].ToString();

                   string gender = reader["Gender"].ToString();
                    
                    
                    if (gender == "Male")
                    {
                        Maletxt.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        Femaletxt.Checked = true;
                    }

                    string subjects = reader["Language"].ToString();

                    string[] selectedSubjects = subjects.Split(',');

                    foreach (string subject in selectedSubjects)
                    {
                        if (subject == "Hindi")
                        {
                            Hinditxt.Checked = true;
                        }
                        else if (subject == "English")
                        {
                            Englishtxt.Checked = true;
                        }
                        else if (subject == "History")
                        {
                            Sanskrittxt.Checked = true;
                        }
                    }

                }

                reader.Close();
            }
        }



        private void Back_Click(object sender, EventArgs e)
            {
                this.Close();
            }

           
        private void Update_Click(object sender, EventArgs e)
        {

            string fullname = FullNametxt.Text;
            string city = Citytxt.Text;
            string gender = GetSelectGender();
            string language = GetMultipleSelectValue();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ADD1 SET FullName= @name, Gender = @gender , Language= @language, City = @city WHERE ID=@id" , con);
                cmd.Parameters.AddWithValue("@name", fullname);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@language", language);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@id", recordid);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Data inserted successfully!");
            ClearInputFields();
            Form3 form = new Form3();
            form.Show();
           
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            string fullname = FullNametxt.Text;
            string city = Citytxt.Text;
            string gender = GetSelectGender();
            string language = GetMultipleSelectValue();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ADD1 WHERE ID=@id", con);
               
                cmd.Parameters.AddWithValue("@id", recordid);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Data Deleted successfully!");
            ClearInputFields();

            Form3 form = new Form3();
            form.Show();
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
                SelectedSubject.Add("HIndi");
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
    }
}
