namespace LoginPanel
{
    partial class MainLogin
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
            this.components = new System.ComponentModel.Container();
            this.UserText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PassText = new System.Windows.Forms.TextBox();
            this.TokenText = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Háttér = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.Button();
            this.ConfirmRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Háttér)).BeginInit();
            this.SuspendLayout();
            // 
            // UserText
            // 
            this.UserText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.UserText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UserText.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.UserText.ForeColor = System.Drawing.Color.Gray;
            this.UserText.Location = new System.Drawing.Point(68, 12);
            this.UserText.Multiline = true;
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(161, 20);
            this.UserText.TabIndex = 0;
            this.UserText.Enter += new System.EventHandler(this.UserText_Enter);
            this.UserText.Leave += new System.EventHandler(this.UserText_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PassText
            // 
            this.PassText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PassText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassText.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.PassText.ForeColor = System.Drawing.Color.Gray;
            this.PassText.Location = new System.Drawing.Point(68, 38);
            this.PassText.Multiline = true;
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(161, 20);
            this.PassText.TabIndex = 2;
            this.PassText.Enter += new System.EventHandler(this.PassText_Enter);
            this.PassText.Leave += new System.EventHandler(this.PassText_Leave);
            // 
            // TokenText
            // 
            this.TokenText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TokenText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TokenText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TokenText.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.TokenText.ForeColor = System.Drawing.Color.Gray;
            this.TokenText.Location = new System.Drawing.Point(68, 64);
            this.TokenText.Multiline = true;
            this.TokenText.Name = "TokenText";
            this.TokenText.Size = new System.Drawing.Size(161, 20);
            this.TokenText.TabIndex = 3;
            this.TokenText.Enter += new System.EventHandler(this.TokenText_Enter);
            this.TokenText.Leave += new System.EventHandler(this.TokenText_Leave);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Register.FlatAppearance.BorderSize = 0;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold);
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Register.Location = new System.Drawing.Point(86, 144);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(124, 23);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.Silver;
            this.Exit.Location = new System.Drawing.Point(86, 173);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(124, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Háttér
            // 
            this.Háttér.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Háttér.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Háttér.Location = new System.Drawing.Point(5, 4);
            this.Háttér.Name = "Háttér";
            this.Háttér.Size = new System.Drawing.Size(287, 200);
            this.Háttér.TabIndex = 7;
            this.Háttér.TabStop = false;
            this.Háttér.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Háttér_MouseDown);
            this.Háttér.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Háttér_MouseMove);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.ForeColor = System.Drawing.Color.Silver;
            this.Login.Location = new System.Drawing.Point(86, 115);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(124, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // ConfirmRegister
            // 
            this.ConfirmRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ConfirmRegister.FlatAppearance.BorderSize = 0;
            this.ConfirmRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmRegister.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmRegister.ForeColor = System.Drawing.Color.Silver;
            this.ConfirmRegister.Location = new System.Drawing.Point(86, 144);
            this.ConfirmRegister.Name = "ConfirmRegister";
            this.ConfirmRegister.Size = new System.Drawing.Size(124, 23);
            this.ConfirmRegister.TabIndex = 8;
            this.ConfirmRegister.Text = "Confirm Register";
            this.ConfirmRegister.UseVisualStyleBackColor = false;
            this.ConfirmRegister.Click += new System.EventHandler(this.ConfirmRegister_Click);
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(297, 208);
            this.Controls.Add(this.ConfirmRegister);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.TokenText);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.Háttér);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainLogin";
            this.Text = "LoginPanel";
            //this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainLogin_MouseDown);
            //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Háttér)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox TokenText;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox Háttér;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button ConfirmRegister;
    }
}