using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LindaUni
{
    public partial class FrmLogin : Form
    {
        public FrmSplash SplashForm { get; set; }
        public List<User> UserList { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Check Login correct
            //Okay

            User thisuser = UserList.Where(a => a.UserName == txtUserName.Text).First();
            //Check password.
            try
            {
                if (thisuser.checklogin(txtPassword.Text))
                {
                    FrmMain mainform = new FrmMain();
                    mainform.SplashForm = SplashForm;
                    mainform.LoggedInUser = thisuser;
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Incorrect, please try again");
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("User does not exist");
            }

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmNewUser myNewUserForm = new FrmNewUser();
            myNewUserForm.UserList = UserList;
            myNewUserForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SplashForm.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Ok - Lets get all the users
            UserList = new List<User>();
            try
            {
                using (var reader = new StreamReader(".\\users.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    UserList = csv.GetRecords<User>().ToList();
                }
            }
            catch
            {
                //Obviously no users
            }
        }
    }
}
