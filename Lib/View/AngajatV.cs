using System;
using System.Windows.Forms;

namespace Lib.View
{
    public partial class AngajatV : Form
    {
        public AngajatV()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        public Button AccesBtnAdaugareCar()
        {
            return this.btnAdaugareCart;
        }

        public Button AccesBtnActualizareCar()
        {
            return this.btnActualizareCart;
        }

        public Button AccesBtnStergereCar()
        {
            return this.btnStergereCart;
        }

        public Button AccesBtnListaCar()
        {
            return this.btnListaCart;
        }

        public Button AccesBtnCautareCarTitlu()
        {
            return this.btnCautareDupaTitlu;
        }

        public Button AccesBtnFiltrareCar()
        {
            return this.btnFiltrare;
        }

        public Button AccesBtnDeconectare()
        {
            return this.btnDeconectare2;
        }

        public Button AccesBtnSortare()
        {
            return this.btnSortare;
        }
        public TextBox AccesTxtCodCar()
        {
            return this.txtCod;
        }

        public TextBox AccesTxtDomeniuCar()
        {
            return this.txtDomeniu;
        }
        public TextBox AccesTxtEdituraCar()
        {
            return this.txtEditura;
        }
        public TextBox AccesTxtAutorCar()
        {
            return this.txtAutor;
        }
        public TextBox AccesTxtTitluCar()
        {
            return this.txtTitlu;
        }
        public ComboBox AccesCmbtDisponibilitateCar()
        {
            return this.txtDisponibilitate;
        }

     

        public TextBox AccesTxtPretCar()
        {
            return this.txtPret;
        }

    

        public TextBox AccesTxtCautareCarTitlu()
        {
            return this.txtCautareTitlu;
        }

        public ComboBox AccesCmbCriteriuFiltrareCar()
        {
            return this.cmbCriteriu;
        }
        public ComboBox AccesCmbSortare()
        {
            return this.cmbSortare;
        }

        public TextBox AccesTxtFiltrareCar()
        {
            return this.txtFiltrare;
        }

        public DataGridView AccesGridCarteView()
        {
            return this.dataGridView1;
        }

    }
}
