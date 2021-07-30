using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLExample
{
    public partial class DashBoard : Form
    {
        List<Person> people = new List<Person>();
        public DashBoard()
        {
            InitializeComponent();
            peopleFoundLIstBox.DataSource = people;
            peopleFoundLIstBox.DisplayMember = "";
        }

        private void seatchButon_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.GetPeople(lastNameTextBox.Text);
        }
    }
}
+