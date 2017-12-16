using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Contact cont = new Contact();
            cont.FirstName = firstNameBox.Text;
            cont.LastName = lastNameBox.Text;
            cont.PhoneNum = phoneNumBox.Text;

            contactListBox.Items.Add(cont.ToString());
        }
    }
}
