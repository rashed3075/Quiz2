using Library.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbId.Text);
            dynamic result1 = BookController.GetAllBook2(id);
            if (result1 != null)
            {
                dgView1.DataSource = result1;
            }
            else
            {
                MessageBox.Show("No Books found");
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result2 = BookController.GetAllBook1();
            dgView2.DataSource = result2;
        }

       
    }
}
