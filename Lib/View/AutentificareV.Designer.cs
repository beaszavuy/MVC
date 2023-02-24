namespace Lib.View
{
    partial class AutentificareV
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
            this.User = new System.Windows.Forms.Label();
            this.txtUserAutentificare = new System.Windows.Forms.TextBox();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParolaAutentificare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(192, 103);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(38, 20);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            // 
            // txtUserAutentificare
            // 
            this.txtUserAutentificare.Location = new System.Drawing.Point(144, 158);
            this.txtUserAutentificare.Name = "txtUserAutentificare";
            this.txtUserAutentificare.Size = new System.Drawing.Size(140, 27);
            this.txtUserAutentificare.TabIndex = 1;
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Location = new System.Drawing.Point(154, 310);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(116, 58);
            this.btnAutentificare.TabIndex = 2;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parola";
            // 
            // txtParolaAutentificare
            // 
            this.txtParolaAutentificare.Location = new System.Drawing.Point(144, 265);
            this.txtParolaAutentificare.Name = "txtParolaAutentificare";
            this.txtParolaAutentificare.PasswordChar = '*';
            this.txtParolaAutentificare.Size = new System.Drawing.Size(140, 27);
            this.txtParolaAutentificare.TabIndex = 4;
            // 
            // AutentificareV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.txtParolaAutentificare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.txtUserAutentificare);
            this.Controls.Add(this.User);
            this.Name = "AutentificareV";
            this.Text = "AutentificareV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label User;
        private TextBox txtUserAutentificare;
        private Button btnAutentificare;
        private Label label1;
        private TextBox txtParolaAutentificare;
    }
}