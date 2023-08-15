using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Hoteleria
{
    public partial class ModalNotificacion : MaterialSkin.Controls.MaterialForm
    {
        private string _titulo = null;
        private string _mensaje = null;
        private Primary _tipoColor;
        private Accent _acentoColor;

        public ModalNotificacion(string mensaje, string titulo ,Primary tipoColor, Accent acentoColor)
        {
            _titulo = titulo;
            _tipoColor = tipoColor;
            _mensaje = mensaje;
            _acentoColor = acentoColor;

            InitializeComponent();
            lblTitulo.Text = _titulo;
            lblMensaje.Text = _mensaje;
        }

        private void ModalError_Load(object sender, EventArgs e)
        {

            SkinManager.ColorScheme = new ColorScheme(Primary.Grey50, _tipoColor, _tipoColor, _acentoColor, TextShade.BLACK);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ModalNotificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Grey900, Primary.Green100, Accent.Blue400, TextShade.WHITE);
        }
    }
}
