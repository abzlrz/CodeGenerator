using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class FormCSGenerator : Form
    {
        public FormCSGenerator()
        {
            InitializeComponent();
        }
        private void GenerateScript(string p)
        {
            try
            {
                if (CheckInputs())
                {
                    StringBuilder sb = new StringBuilder();

                    int length = tbx_parameters.Lines.Length;

                    for (int i = 0; i < length; i++)
                    {
                        sb.AppendLine($"{p}.Parameters.AddWithValue(\"{tbx_parameters.Lines[i]}\", {tbx_controls.Lines[i]});");
                    }

                    tbx_result.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CheckInputs()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tbx_parameters.Text) ||
                string.IsNullOrEmpty(tbx_controls.Text))
                result = false;

            return result;
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            GenerateScript("adapter.cmd");
        }
        private void btn_generate_cmd_Click(object sender, EventArgs e)
        {
            GenerateScript("cmd");
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            tbx_parameters.ResetText();
            tbx_controls.ResetText();
            tbx_result.ResetText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbx_result.Text);
        }

        private void btn_insertupdate_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("public bool InsertUpdate()");
            builder.AppendLine("{");
            builder.AppendLine("\tusing(var cmd = new MySqlCommand())");
            builder.AppendLine("\t{");
            builder.AppendLine("\t\tcmd.Connection = new MySqlConnection();");
            builder.AppendLine("\t\tcmd.CommandType = CommandType.Text;");
            builder.AppendLine("\t\tcmd.CommandText = \"\";");
            builder.AppendLine("");

            for (int i = 0; i < tbx_result.Lines.Length; i++)
            {
                builder.AppendLine("\t\t" + tbx_result.Lines[i]);
            }

            builder.AppendLine("\t\tcmd.Connection.Open();");
            builder.AppendLine("\t\tvar rows = cmd.ExecuteNonQuery();");
            builder.AppendLine("\t\tcmd.Connection.Close();");
            builder.AppendLine("");
            builder.AppendLine("\t\treturn rows > 0;");
            builder.AppendLine("\t}");
            builder.AppendLine("}");

            string result = builder.ToString();
            Clipboard.SetText(result);
        }
    }
}
