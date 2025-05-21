
namespace GakumasLauncher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button_launch = new Button();
            button_update = new Button();
            textBox_date = new TextBox();
            textBox_viewer_id = new TextBox();
            textBox_open_id = new TextBox();
            textBox_pf_access_token = new TextBox();
            textBox_exe_path = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button_launch
            // 
            button_launch.Location = new Point(340, 78);
            button_launch.Name = "button_launch";
            button_launch.Size = new Size(167, 93);
            button_launch.TabIndex = 0;
            button_launch.TabStop = false;
            button_launch.Text = "Launch";
            button_launch.UseVisualStyleBackColor = true;
            button_launch.Click += button_launch_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(340, 12);
            button_update.Name = "button_update";
            button_update.Size = new Size(167, 60);
            button_update.TabIndex = 1;
            button_update.TabStop = false;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // textBox_date
            // 
            textBox_date.BackColor = Color.White;
            textBox_date.Location = new Point(133, 12);
            textBox_date.Name = "textBox_date";
            textBox_date.ReadOnly = true;
            textBox_date.Size = new Size(201, 27);
            textBox_date.TabIndex = 2;
            textBox_date.TabStop = false;
            // 
            // textBox_viewer_id
            // 
            textBox_viewer_id.BackColor = Color.White;
            textBox_viewer_id.Location = new Point(133, 45);
            textBox_viewer_id.Name = "textBox_viewer_id";
            textBox_viewer_id.PasswordChar = '*';
            textBox_viewer_id.ReadOnly = true;
            textBox_viewer_id.Size = new Size(201, 27);
            textBox_viewer_id.TabIndex = 3;
            textBox_viewer_id.TabStop = false;
            textBox_viewer_id.Enter += textBox_args_Enter;
            textBox_viewer_id.Leave += textBox_args_Leave;
            // 
            // textBox_open_id
            // 
            textBox_open_id.BackColor = Color.White;
            textBox_open_id.Location = new Point(133, 78);
            textBox_open_id.Name = "textBox_open_id";
            textBox_open_id.PasswordChar = '*';
            textBox_open_id.ReadOnly = true;
            textBox_open_id.Size = new Size(201, 27);
            textBox_open_id.TabIndex = 4;
            textBox_open_id.TabStop = false;
            textBox_open_id.Enter += textBox_args_Enter;
            textBox_open_id.Leave += textBox_args_Leave;
            // 
            // textBox_pf_access_token
            // 
            textBox_pf_access_token.BackColor = Color.White;
            textBox_pf_access_token.Location = new Point(133, 111);
            textBox_pf_access_token.Name = "textBox_pf_access_token";
            textBox_pf_access_token.PasswordChar = '*';
            textBox_pf_access_token.ReadOnly = true;
            textBox_pf_access_token.Size = new Size(201, 27);
            textBox_pf_access_token.TabIndex = 5;
            textBox_pf_access_token.TabStop = false;
            textBox_pf_access_token.Enter += textBox_args_Enter;
            textBox_pf_access_token.Leave += textBox_args_Leave;
            // 
            // textBox_exe_path
            // 
            textBox_exe_path.BackColor = Color.White;
            textBox_exe_path.Location = new Point(133, 144);
            textBox_exe_path.Name = "textBox_exe_path";
            textBox_exe_path.ReadOnly = true;
            textBox_exe_path.Size = new Size(201, 27);
            textBox_exe_path.TabIndex = 6;
            textBox_exe_path.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 15);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 7;
            label1.Text = "log date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 48);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 8;
            label2.Text = "viewer_id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 81);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 9;
            label3.Text = "open_id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 114);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 10;
            label4.Text = "pf_access_token";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 147);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 11;
            label5.Text = "path";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 180);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_exe_path);
            Controls.Add(textBox_pf_access_token);
            Controls.Add(textBox_open_id);
            Controls.Add(textBox_viewer_id);
            Controls.Add(textBox_date);
            Controls.Add(button_update);
            Controls.Add(button_launch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gakumas Launcher";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button button_launch;
        private Button button_update;
        private TextBox textBox_date;
        private TextBox textBox_viewer_id;
        private TextBox textBox_open_id;
        private TextBox textBox_pf_access_token;
        private TextBox textBox_exe_path;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
