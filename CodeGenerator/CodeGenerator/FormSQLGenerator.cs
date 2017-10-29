using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class FormSQLGenerator : Form
    {
        public FormSQLGenerator()
        {
            InitializeComponent();
        }

        private void btn_sql_insert_Click(object sender, EventArgs e)
        {
            string top = "create procedure sp_insert";
            string mid1 = "as begin";
            string bottom = "end\ngo";

            var values = Regex.Matches(tbx_parameters.Text, @"[^\s()]+(?=[^()]*\))");

            StringBuilder builder = new StringBuilder();

            builder.AppendLine(top);
            var list = values.Cast<Match>().Select(x => x.Value).ToList();
            builder.AppendLine(bottom);

            tbx_result.Text = builder.ToString();
        }
    }
}
