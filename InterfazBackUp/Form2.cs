using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazBackUp
{
    public partial class aviso : Form
    {
        String mensaje;
        Image imagen;
        public aviso(String mensaje)
        {
            this.mensaje = mensaje;
            InitializeComponent();
            labelAviso.Text = mensaje;

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
