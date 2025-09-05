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
            this.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumero.Text != "")
            {
                btnCargar.Enabled = true;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}
