using cashierSystem_v0.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashierSystem_v0
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            shownUsername.Text = Convert.ToString(Program.PuserID);
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            usersStore users = new();
            users.insert(username.Text, password.Text, role.Text,Convert.ToInt32(isActive.Checked));
        }
    }
}
