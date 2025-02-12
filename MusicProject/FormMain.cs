using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormArticles();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormGallery();
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormMedia();
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormReference();
            form.Show();
        }
    }
}
