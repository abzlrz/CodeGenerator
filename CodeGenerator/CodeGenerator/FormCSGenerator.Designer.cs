namespace CodeGenerator
{
    partial class FormCSGenerator
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
            this.tbx_parameters = new System.Windows.Forms.TextBox();
            this.tbx_controls = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_parameter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_result = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_cmd = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_adapter_cmd = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_insertupdate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
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
            this.tbx_parameters.Size = new System.Drawing.Size(257, 155);
            this.tbx_parameters.TabIndex = 0;
            // 
            // tbx_controls
            // 
            this.tbx_controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(165)))));
            this.tbx_controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_controls.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_controls.ForeColor = System.Drawing.Color.White;
            this.tbx_controls.Location = new System.Drawing.Point(7, 30);
            this.tbx_controls.Multiline = true;
            this.tbx_controls.Name = "tbx_controls";
            this.tbx_controls.Size = new System.Drawing.Size(259, 155);
            this.tbx_controls.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btn_insertupdate);
            this.panel2.Controls.Add(this.btn_parameter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 39);
            this.panel2.TabIndex = 6;
            // 
            // btn_parameter
            // 
            this.btn_parameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_parameter.FlatAppearance.BorderSize = 0;
            this.btn_parameter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parameter.ForeColor = System.Drawing.Color.White;
            this.btn_parameter.Location = new System.Drawing.Point(470, 3);
            this.btn_parameter.Name = "btn_parameter";
            this.btn_parameter.Size = new System.Drawing.Size(86, 28);
            this.btn_parameter.TabIndex = 11;
            this.btn_parameter.Text = "Parameter only";
            this.btn_parameter.UseVisualStyleBackColor = false;
            this.btn_parameter.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.tbx_controls);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(283, 12);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 0);
            this.panel3.Size = new System.Drawing.Size(273, 185);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Controls";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.tbx_parameters);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(7, 7, 7, 0);
            this.panel4.Size = new System.Drawing.Size(271, 185);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parameters";
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
            this.panel5.Controls.Add(this.btn_cmd);
            this.panel5.Controls.Add(this.btn_reset);
            this.panel5.Controls.Add(this.btn_adapter_cmd);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(520, 39);
            this.panel5.TabIndex = 7;
            // 
            // btn_cmd
            // 
            this.btn_cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_cmd.FlatAppearance.BorderSize = 0;
            this.btn_cmd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cmd.ForeColor = System.Drawing.Color.White;
            this.btn_cmd.Location = new System.Drawing.Point(214, 0);
            this.btn_cmd.Name = "btn_cmd";
            this.btn_cmd.Size = new System.Drawing.Size(86, 28);
            this.btn_cmd.TabIndex = 10;
            this.btn_cmd.Text = "cmd";
            this.btn_cmd.UseVisualStyleBackColor = false;
            this.btn_cmd.Click += new System.EventHandler(this.btn_generate_cmd_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(306, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(86, 28);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_adapter_cmd
            // 
            this.btn_adapter_cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_adapter_cmd.FlatAppearance.BorderSize = 0;
            this.btn_adapter_cmd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_adapter_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adapter_cmd.ForeColor = System.Drawing.Color.White;
            this.btn_adapter_cmd.Location = new System.Drawing.Point(122, 0);
            this.btn_adapter_cmd.Name = "btn_adapter_cmd";
            this.btn_adapter_cmd.Size = new System.Drawing.Size(86, 28);
            this.btn_adapter_cmd.TabIndex = 8;
            this.btn_adapter_cmd.Text = "adapter.cmd";
            this.btn_adapter_cmd.UseVisualStyleBackColor = false;
            this.btn_adapter_cmd.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(12);
            this.panel7.Size = new System.Drawing.Size(568, 438);
            this.panel7.TabIndex = 9;
            // 
            // btn_insertupdate
            // 
            this.btn_insertupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_insertupdate.FlatAppearance.BorderSize = 0;
            this.btn_insertupdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_insertupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertupdate.ForeColor = System.Drawing.Color.White;
            this.btn_insertupdate.Location = new System.Drawing.Point(307, 3);
            this.btn_insertupdate.Name = "btn_insertupdate";
            this.btn_insertupdate.Size = new System.Drawing.Size(157, 28);
            this.btn_insertupdate.TabIndex = 13;
            this.btn_insertupdate.Text = "Copy as Complete method";
            this.btn_insertupdate.UseVisualStyleBackColor = false;
            this.btn_insertupdate.Click += new System.EventHandler(this.btn_insertupdate_Click);
            // 
            // FormCSGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(568, 477);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCSGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# SQL Parameter Generator";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_parameters;
        private System.Windows.Forms.TextBox tbx_controls;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_parameter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tbx_result;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_cmd;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_adapter_cmd;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_insertupdate;
    }
}

