
using System.Windows.Forms;

namespace Lib.View
{
    public partial class AutentificareV : Form
    {
        public AutentificareV()
        {
            InitializeComponent();
        }
        public TextBox AccesUserView()
        {
            return this.txtUserAutentificare;
        }

        public TextBox AccesParolaView()
        {
            return this.txtParolaAutentificare;
        }

        public Button AccesBtnAutentificare()
        {
            return this.btnAutentificare;
        }
    }
}
