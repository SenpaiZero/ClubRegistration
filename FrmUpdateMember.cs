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

namespace ClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        private int Age, Count;
        private long studentID;
        private string FirstName, MiddleName, LastName, Gender, Program;
        SqlConnection con;

        String sqlCon;

        private void studentCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM ClubMembers WHERE StudentID = @id";
            con.ConnectionString = sqlCon;
            using (con)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", studentCB.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        studentID = dr.GetInt64(1);
                        FirstName = dr.GetString(2);
                        MiddleName = dr.GetString(3);
                        LastName = dr.GetString(4);
                        Age = dr.GetInt32(5);
                        Gender = dr.GetString(6);
                        Program = dr.GetString(7);

                        fillData();
                        dr.Close();
                    }
                }
                con.Close();
            }
        }

        void fillData()
        {
            studentCB.Text = studentID.ToString();
            fNameTB.Text = FirstName;
            lNameTB.Text = LastName;
            mNameTB.Text = MiddleName;
            programCB.Text = Program;
            ageTB.Text = Age.ToString();
            genderCB.Text = Gender;
        }

        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

            string updateQuery = "UPDATE ClubMembers SET FirstName = @firstName, MiddleName = @middleName, LastName = @lastName, Age = @age, Gender = @gender, Program = @program WHERE StudentID = @id";

            con.ConnectionString = sqlCon;
            using (con)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@id", studentID);
                    cmd.Parameters.AddWithValue("@firstName", fNameTB.Text);
                    cmd.Parameters.AddWithValue("@middleName", mNameTB.Text);
                    cmd.Parameters.AddWithValue("@lastName", lNameTB.Text);
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(ageTB.Text)); // Assuming age is in text format
                    cmd.Parameters.AddWithValue("@gender", genderCB.Text);
                    cmd.Parameters.AddWithValue("@program", programCB.Text);

                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Success");
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            sqlCon = $@"Data Source=(LocalDB)\MSSQLLocalDB;
                        AttachDbFilename={System.Environment.CurrentDirectory}/ClubDB.mdf;
                        Initial Catalog=CrewConnectDB;
                        Integrated Security=True";
            con = new SqlConnection(sqlCon);

            String query = "SELECT * FROM ClubMembers";

            con.ConnectionString = sqlCon;
            using (con)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", studentCB.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        studentCB.Items.Add(dr.GetInt64(1));
                    }
                    dr.Close();
                }
                con.Close();
            }
        }
    }
}
