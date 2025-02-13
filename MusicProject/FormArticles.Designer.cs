namespace MusicProject
{
    partial class FormArticles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Історія музики");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Види музичних жанрів");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Відомі композитори");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Сучасна музична індустрія");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Як створюється музика");
            this.treeViewArticles = new System.Windows.Forms.TreeView();
            this.webBrowserArticles = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeViewArticles
            // 
            this.treeViewArticles.BackColor = System.Drawing.Color.RosyBrown;
            this.treeViewArticles.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewArticles.Location = new System.Drawing.Point(0, 0);
            this.treeViewArticles.Name = "treeViewArticles";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Історія музики";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Види музичних жанрів";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Відомі композитори";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Сучасна музична індустрія";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Як створюється музика";
            this.treeViewArticles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeViewArticles.Size = new System.Drawing.Size(320, 1001);
            this.treeViewArticles.TabIndex = 0;
            this.treeViewArticles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewArticles_AfterSelect);
            // 
            // webBrowserArticles
            // 
            this.webBrowserArticles.Location = new System.Drawing.Point(326, 8);
            this.webBrowserArticles.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserArticles.Name = "webBrowserArticles";
            this.webBrowserArticles.Size = new System.Drawing.Size(1359, 981);
            this.webBrowserArticles.TabIndex = 1;
            // 
            // FormArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusicProject.Properties.Resources.bg_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1697, 1001);
            this.Controls.Add(this.webBrowserArticles);
            this.Controls.Add(this.treeViewArticles);
            this.Name = "FormArticles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статті";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewArticles;
        private System.Windows.Forms.WebBrowser webBrowserArticles;
    }
}