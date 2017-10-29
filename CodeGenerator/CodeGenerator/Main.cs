using System;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class Main : Form
    {
        private FormCSGenerator cs = new FormCSGenerator();
        private FormSQLGenerator sql_insert = new FormSQLGenerator();

        public Main()
        {
            InitializeComponent();
        }

        private void CSGenerator_Click(object sender, EventArgs e)
        {
            cs.MdiParent = this;
            cs.Show();
        }

        private void SQLInsertGenerator_Click(object sender, EventArgs e)
        {
            sql_insert.MdiParent = this;
            sql_insert.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
