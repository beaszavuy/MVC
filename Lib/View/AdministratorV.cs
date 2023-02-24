using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.View
{
    public partial class AdministratorV : Form
    {
        public AdministratorV()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        public Button AccesBtnAdaugareUtilizator()
        {
            return this.btnAdaugareU;
        }

        public Button AccesBtnActualizareUtilizator()
        {
            return this.btnActualizare;
        }

        public Button AccesBtnStergereUtilizator()
        {
            return this.btnStergere;
        }

        public Button AccesBtnAfisareListaUtilizatori()
        {
            return this.btnLista;
        }

        public Button AccesBtnDeconectare()
        {
            return this.btnDeconectare;
        }

        public Button AccesBtnFiltrareRol()
        {
            return this.btnFiltrareRol;
        }


        public TextBox AccesTxtLegitimatie()
        {
            return this.txtLegitimatie;
        }

        public TextBox AccesTxtNume()
        {
            return this.txtNume;
        }

        public TextBox AccesTxtUser()
        {
            return this.txtUser;
        }

        public TextBox AccesTxtParola()
        {
            return this.txtParola;
        }

        public ComboBox AccesCmbRol()
        {
            return this.cmbRolU;
        }

        public ComboBox AccesCmb()
        {
            return this.cmbFiltrareRol;
        }

        public DataGridView AccesGridUtilizatorView()
        {
            return this.dataGridView1;
        }
    }
}
