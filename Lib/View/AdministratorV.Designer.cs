namespace Lib.View
{
    partial class AdministratorV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLegitimatie = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.cmbRolU = new System.Windows.Forms.ComboBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.btnAdaugareU = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFiltrareRol = new System.Windows.Forms.ComboBox();
            this.btnFiltrareRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "USER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "PAROLA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "ROL";
            // 
            // txtLegitimatie
            // 
            this.txtLegitimatie.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLegitimatie.ForeColor = System.Drawing.SystemColors.Info;
            this.txtLegitimatie.Location = new System.Drawing.Point(160, 64);
            this.txtLegitimatie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLegitimatie.Name = "txtLegitimatie";
            this.txtLegitimatie.Size = new System.Drawing.Size(135, 27);
            this.txtLegitimatie.TabIndex = 7;
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNume.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNume.Location = new System.Drawing.Point(160, 107);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(135, 27);
            this.txtNume.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUser.ForeColor = System.Drawing.SystemColors.Info;
            this.txtUser.Location = new System.Drawing.Point(160, 165);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(135, 27);
            this.txtUser.TabIndex = 9;
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtParola.ForeColor = System.Drawing.SystemColors.Info;
            this.txtParola.Location = new System.Drawing.Point(160, 224);
            this.txtParola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(135, 27);
            this.txtParola.TabIndex = 10;
            // 
            // cmbRolU
            // 
            this.cmbRolU.AutoCompleteCustomSource.AddRange(new string[] {
            "ANGAJAT",
            "ADMINISTRATOR"});
            this.cmbRolU.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbRolU.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbRolU.FormattingEnabled = true;
            this.cmbRolU.Items.AddRange(new object[] {
            "",
            "ANGAJAT",
            "ADMINISTRATOR"});
            this.cmbRolU.Location = new System.Drawing.Point(160, 279);
            this.cmbRolU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRolU.Name = "cmbRolU";
            this.cmbRolU.Size = new System.Drawing.Size(135, 28);
            this.cmbRolU.TabIndex = 11;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLista.Location = new System.Drawing.Point(54, 364);
            this.btnLista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(242, 55);
            this.btnLista.TabIndex = 12;
            this.btnLista.Text = "Afisare lista utilizatori";
            this.btnLista.UseVisualStyleBackColor = false;
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeconectare.Location = new System.Drawing.Point(54, 479);
            this.btnDeconectare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(242, 56);
            this.btnDeconectare.TabIndex = 13;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.UseVisualStyleBackColor = false;
            // 
            // btnAdaugareU
            // 
            this.btnAdaugareU.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdaugareU.Location = new System.Drawing.Point(360, 64);
            this.btnAdaugareU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdaugareU.Name = "btnAdaugareU";
            this.btnAdaugareU.Size = new System.Drawing.Size(141, 95);
            this.btnAdaugareU.TabIndex = 14;
            this.btnAdaugareU.Text = "Adaugare Utilizator";
            this.btnAdaugareU.UseVisualStyleBackColor = false;
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.RosyBrown;
            this.btnActualizare.Location = new System.Drawing.Point(360, 211);
            this.btnActualizare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(141, 99);
            this.btnActualizare.TabIndex = 15;
            this.btnActualizare.Text = "Actualizare Utilizator";
            this.btnActualizare.UseVisualStyleBackColor = false;
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.RosyBrown;
            this.btnStergere.Location = new System.Drawing.Point(360, 364);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(141, 105);
            this.btnStergere.TabIndex = 16;
            this.btnStergere.Text = "Stergere Utilizator";
            this.btnStergere.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nume,
            this.User,
            this.Parola,
            this.Rol});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(534, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(624, 509);
            this.dataGridView1.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 6;
            this.Nume.Name = "Nume";
            this.Nume.Width = 125;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.Width = 125;
            // 
            // Parola
            // 
            this.Parola.HeaderText = "Parola";
            this.Parola.MinimumWidth = 6;
            this.Parola.Name = "Parola";
            this.Parola.Width = 125;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.Width = 125;
            // 
            // cmbFiltrareRol
            // 
            this.cmbFiltrareRol.AutoCompleteCustomSource.AddRange(new string[] {
            "ANGAJAT",
            "ADMINISTRATOR"});
            this.cmbFiltrareRol.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbFiltrareRol.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbFiltrareRol.FormattingEnabled = true;
            this.cmbFiltrareRol.Items.AddRange(new object[] {
            "",
            "ANGAJAT",
            "ADMINISTRATOR"});
            this.cmbFiltrareRol.Location = new System.Drawing.Point(360, 539);
            this.cmbFiltrareRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltrareRol.Name = "cmbFiltrareRol";
            this.cmbFiltrareRol.Size = new System.Drawing.Size(135, 28);
            this.cmbFiltrareRol.TabIndex = 18;
            // 
            // btnFiltrareRol
            // 
            this.btnFiltrareRol.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFiltrareRol.Location = new System.Drawing.Point(360, 575);
            this.btnFiltrareRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrareRol.Name = "btnFiltrareRol";
            this.btnFiltrareRol.Size = new System.Drawing.Size(141, 105);
            this.btnFiltrareRol.TabIndex = 19;
            this.btnFiltrareRol.Text = "Sorteaza";
            this.btnFiltrareRol.UseVisualStyleBackColor = false;
            // 
            // AdministratorV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 708);
            this.Controls.Add(this.btnFiltrareRol);
            this.Controls.Add(this.cmbFiltrareRol);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnAdaugareU);
            this.Controls.Add(this.btnDeconectare);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.cmbRolU);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtLegitimatie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministratorV";
            this.Text = "AdministratorV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtLegitimatie;
        private TextBox txtNume;
        private TextBox txtUser;
        private TextBox txtParola;
        private ComboBox cmbRolU;
        private Button btnLista;
        private Button btnDeconectare;
        private Button btnAdaugareU;
        private Button btnActualizare;
        private Button btnStergere;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nume;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Parola;
        private DataGridViewTextBoxColumn Rol;
        private ComboBox cmbFiltrareRol;
        private Button btnFiltrareRol;
    }
}