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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void RegistrationClicked(object sender, EventArgs e)
        {
            var book = new
            {
                Id = Convert.ToInt32(tbId.Text),
                Name = tbName.Text,
                Author = tbAuthor.Text,
                Edition = tbEdition.Text
            };
            var result = BookController.AddFood(book);
            if (result)
            {
                MessageBox.Show("Book Added");
            }
            else
            {
                MessageBox.Show("Book Couldnt't Added");
            }
        }

        
    }
}
