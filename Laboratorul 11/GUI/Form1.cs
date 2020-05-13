using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6_WCF_EF;

namespace GUI
{
    public partial class Form1 : Form
    {
        List<Post> posts = new List<Post>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
            posts = LoadPosts().ToList<Post>();
            dgp.DataSource = posts;
            dgp.Columns[0].Width = 0;
            if (dgp.Rows.Count > 0)
                dgc.DataSource = posts[0].Comments;
        }
        private static Lab6_WCF_EF.Post[] LoadPosts()
        {
            PostCommentClient pc = new PostCommentClient();
            Lab6_WCF_EF.Post[] p = pc.GetPosts();
            return p;
        }
    }
}
