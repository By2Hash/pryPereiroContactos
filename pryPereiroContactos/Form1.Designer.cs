namespace pryPereiroContactos
{
    partial class frmContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactos));
            panel1 = new Panel();
            btnLimpiar = new Button();
            txtNombre = new TextBox();
            btnCargar = new Button();
            mtbNumero = new MaskedTextBox();
            lblTelefono = new Label();
            lblContactos = new Label();
            panel2 = new Panel();
            ltbNombres = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnCargar);
            panel1.Controls.Add(mtbNumero);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(lblContactos);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 207);
            panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14F);
            btnLimpiar.Location = new Point(23, 147);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 41);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 30);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 23);
            txtNombre.TabIndex = 7;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnCargar
            // 
            btnCargar.Enabled = false;
            btnCargar.Font = new Font("Segoe UI", 14F);
            btnCargar.Location = new Point(234, 147);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(97, 41);
            btnCargar.TabIndex = 6;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // mtbNumero
            // 
            mtbNumero.BackColor = SystemColors.Window;
            mtbNumero.Enabled = false;
            mtbNumero.ForeColor = SystemColors.Desktop;
            mtbNumero.Location = new Point(253, 94);
            mtbNumero.Mask = "000-000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(78, 23);
            mtbNumero.TabIndex = 5;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14F);
            lblTelefono.Location = new Point(23, 89);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(88, 25);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "&Telefono:";
            // 
            // lblContactos
            // 
            lblContactos.AutoSize = true;
            lblContactos.Font = new Font("Segoe UI", 14F);
            lblContactos.Location = new Point(23, 25);
            lblContactos.Name = "lblContactos";
            lblContactos.Size = new Size(100, 25);
            lblContactos.TabIndex = 2;
            lblContactos.Text = "&Contactos:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(ltbNombres);
            panel2.Location = new Point(12, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 214);
            panel2.TabIndex = 1;
            // 
            // ltbNombres
            // 
            ltbNombres.BorderStyle = BorderStyle.FixedSingle;
            ltbNombres.FormattingEnabled = true;
            ltbNombres.ItemHeight = 15;
            ltbNombres.Items.AddRange(new object[] { "" });
            ltbNombres.Location = new Point(23, 15);
            ltbNombres.Name = "ltbNombres";
            ltbNombres.Size = new Size(308, 182);
            ltbNombres.TabIndex = 0;
            ltbNombres.SelectedIndexChanged += ltbNombres_SelectedIndexChanged;
            // 
            // frmContactos
            // 
            AcceptButton = btnCargar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 470);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contactos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNombre;
        private Button btnCargar;
        private MaskedTextBox mtbNumero;
        private Label lblTelefono;
        private Label lblContactos;
        private Panel panel2;
        private ListBox ltbNombres;
        private Button btnLimpiar;
    }
}
