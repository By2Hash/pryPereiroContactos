using System.Windows.Forms;

namespace pryPereiroContactos
{
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
            this.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            mtbNumero.Text = "";
        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumero.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        string vNombre = "";
        string vNumero = "";
        int vContador = 0;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            vContador++;
            vNombre = txtNombre.Text;
            vNumero = mtbNumero.Text;

            string vResultado = vContador + "----" + vNombre + "----" + vNumero;
            ltbNombres.Items.Add(vResultado);
        }

        private void ltbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeComponent();

            // Cambiar la fuente del ListBox
            ltbNombres.Font = new Font("Arial", 14, FontStyle.Bold);
        }
    }
}
