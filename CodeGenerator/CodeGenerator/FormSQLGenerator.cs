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

        private void btn_generate_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < tbx_value.Lines.Length; i++)
            {
                builder.Append($"INSERT INTO [{tbx_table.Text}] ({tbx_fields.Text}) VALUES");
                builder.AppendLine($@"({tbx_value.Lines[i]});");
            }

            tbx_output.Text = builder.ToString();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbx_output.Text);
        }
    }
}
