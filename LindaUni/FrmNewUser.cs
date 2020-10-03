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
    public partial class FrmNewUser : Form
    {
        public FrmLogin LoginForm { get; set; }
        public List<User> UserList { get; set; }
        public FrmNewUser()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           if(txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK);
                txtPassword.Text = "";
                txtPassword2.Text = "";
                return;
            }

            //TODO: Check for other user Failures

            User myNewUser = new User(txtUserName.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, dateDOB.Value, comboUseType.Text);
            UserList.Add(myNewUser);
            using(var writer = new StreamWriter(".\\users.csv"))
            using(var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(UserList);
            }
          
            this.Close();
        }

        private void FrmNewUser_Load(object sender, EventArgs e)
        {

        }

        private void comboUseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
