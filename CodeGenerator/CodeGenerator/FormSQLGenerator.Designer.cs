namespace CodeGenerator
{
    partial class FormSQLGenerator
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbx_parameters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_result = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_sql_insertupdate = new System.Windows.Forms.Button();
            this.btn_sql_update = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sql_insert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(12);
            this.panel7.Size = new System.Drawing.Size(568, 438);
            this.panel7.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.tbx_parameters);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(7, 7, 7, 0);
            this.panel4.Size = new System.Drawing.Size(544, 185);
            this.panel4.TabIndex = 2;
            // 
            // tbx_parameters
            // 
            this.tbx_parameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(165)))));
            this.tbx_parameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_parameters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_parameters.ForeColor = System.Drawing.Color.White;
            this.tbx_parameters.Location = new System.Drawing.Point(7, 30);
            this.tbx_parameters.Multiline = true;
            this.tbx_parameters.Name = "tbx_parameters";
            this.tbx_parameters.Size = new System.Drawing.Size(530, 155);
            this.tbx_parameters.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Table) => (fields)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tbx_result);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 197);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12);
            this.panel1.Size = new System.Drawing.Size(544, 229);
            this.panel1.TabIndex = 1;
            // 
            // tbx_result
            // 
            this.tbx_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbx_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_result.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_result.ForeColor = System.Drawing.Color.White;
            this.tbx_result.Location = new System.Drawing.Point(12, 51);
            this.tbx_result.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_result.Name = "tbx_result";
            this.tbx_result.ReadOnly = true;
            this.tbx_result.Size = new System.Drawing.Size(520, 166);
            this.tbx_result.TabIndex = 6;
            this.tbx_result.Text = "";
            this.tbx_result.WordWrap = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_sql_insertupdate);
            this.panel5.Controls.Add(this.btn_sql_update);
            this.panel5.Controls.Add(this.btn_reset);
            this.panel5.Controls.Add(this.btn_sql_insert);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(520, 39);
            this.panel5.TabIndex = 7;
            // 
            // btn_sql_insertupdate
            // 
            this.btn_sql_insertupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_sql_insertupdate.FlatAppearance.BorderSize = 0;
            this.btn_sql_insertupdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sql_insertupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sql_insertupdate.ForeColor = System.Drawing.Color.White;
            this.btn_sql_insertupdate.Location = new System.Drawing.Point(262, 0);
            this.btn_sql_insertupdate.Name = "btn_sql_insertupdate";
            this.btn_sql_insertupdate.Size = new System.Drawing.Size(120, 28);
            this.btn_sql_insertupdate.TabIndex = 11;
            this.btn_sql_insertupdate.Text = "SQL Insert Update";
            this.btn_sql_insertupdate.UseVisualStyleBackColor = false;
            // 
            // btn_sql_update
            // 
            this.btn_sql_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_sql_update.FlatAppearance.BorderSize = 0;
            this.btn_sql_update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sql_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sql_update.ForeColor = System.Drawing.Color.White;
            this.btn_sql_update.Location = new System.Drawing.Point(136, 0);
            this.btn_sql_update.Name = "btn_sql_update";
            this.btn_sql_update.Size = new System.Drawing.Size(120, 28);
            this.btn_sql_update.TabIndex = 10;
            this.btn_sql_update.Text = "SQL Update";
            this.btn_sql_update.UseVisualStyleBackColor = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(388, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(120, 28);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // btn_sql_insert
            // 
            this.btn_sql_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_sql_insert.FlatAppearance.BorderSize = 0;
            this.btn_sql_insert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sql_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sql_insert.ForeColor = System.Drawing.Color.White;
            this.btn_sql_insert.Location = new System.Drawing.Point(10, 0);
            this.btn_sql_insert.Name = "btn_sql_insert";
            this.btn_sql_insert.Size = new System.Drawing.Size(120, 28);
            this.btn_sql_insert.TabIndex = 8;
            this.btn_sql_insert.Text = "SQL Insert";
            this.btn_sql_insert.UseVisualStyleBackColor = false;
            this.btn_sql_insert.Click += new System.EventHandler(this.btn_sql_insert_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 39);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(470, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormSQLGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(568, 477);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Name = "FormSQLGenerator";
            this.Text = "SQL Generator";
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbx_parameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tbx_result;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_sql_insertupdate;
        private System.Windows.Forms.Button btn_sql_update;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_sql_insert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}