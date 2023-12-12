using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, Count;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            FrmUpdateMember upd = new FrmUpdateMember();
            upd.Show();
        }

        private long StudentID;

        private void registerBtn_Click(object sender, EventArgs e)
        {
            StudentID = Convert.ToInt64(studentIdTB.Text);
            Age = Convert.ToInt32(ageTB.Text);
            FirstName = fNameTB.Text;
            MiddleName = mNameTB.Text;
            LastName = lNameTB.Text;
            Gender = genderCB.Text;
            Program = programCB.Text;

            clubRegistrationQuery.RegisterStudent(
                RegistrationID(),
                StudentID, FirstName, MiddleName, LastName,
                Age, Gender, Program);

            RefreshListOfClubMembers();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery= new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }
        public FrmClubRegistration()
        {
            InitializeComponent();
        }
        void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList(); 
            clubMemberGrid.DataSource = clubRegistrationQuery.bindingSource;
        }
        int RegistrationID()
        {
            Count++;
            return Count;
        }
    }
}
