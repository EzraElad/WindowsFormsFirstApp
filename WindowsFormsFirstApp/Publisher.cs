using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsFirstApp.DAL;
using WindowsFormsFirstApp.Model;

namespace WindowsFormsFirstApp
{
    public partial class Publisher : Form
    {
        private readonly IConfigHandler _configHandler;

        public Publisher(IConfigHandler configHandler)
        {
            _configHandler = configHandler;
            InitializeComponent();
        }

        QaUser qaUser = new QaUser();
        ProdUser prodUser = new ProdUser();

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void qa_username_label_Click(object sender, EventArgs e)
        {

        }

        private void Publisher_Load(object sender, EventArgs e)
        {

        }


        private void qa_cred_btn_Click(object sender, EventArgs e)
        {
            // Gets the values from the input fields
            qaUser.Username = qa_username_tb.Text;
            qaUser.Password = qa_password_tb.Text;
            qa_current_username.Text = qaUser.Username;
            qa_current_password.Text = qaUser.Password;
            _configHandler.AddQaUserToJson(qaUser);
        }

    }
}
