using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicProject
{
    public partial class FormArticles : Form
    {
        public FormArticles()
        {
            InitializeComponent();
        }

        private void treeViewArticles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Історія музики":
                    webBrowserArticles.Navigate(Path.Combine(Application.StartupPath, "htmlArticles", "history.html"));
                    break;
                case "Види музичних жанрів":
                    webBrowserArticles.Navigate(Path.Combine(Application.StartupPath, "htmlArticles", "genres.html"));
                    break;
                case "Відомі композитори":
                    webBrowserArticles.Navigate(Path.Combine(Application.StartupPath, "htmlArticles", "composers.html"));
                    break;
                case "Сучасна музична індустрія":
                    webBrowserArticles.Navigate(Path.Combine(Application.StartupPath, "htmlArticles", "industry.html"));
                    break;
                case "Як створюється музика":
                    webBrowserArticles.Navigate(Path.Combine(Application.StartupPath, "htmlArticles", "create_music.html"));
                    break;
                default:
                    webBrowserArticles.DocumentText = "<h2>Оберіть статтю зі списку</h2>";
                    break;
            }

        }
    }
}
