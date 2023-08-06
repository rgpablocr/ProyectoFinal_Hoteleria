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

        public ModalNotificacion(string mensaje, string titulo ,Primary tipoColor)
        {
            _titulo = titulo;
            _tipoColor = tipoColor;
            _mensaje = mensaje;

            InitializeComponent();
        }

        private void ModalError_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(_tipoColor, Primary.Grey900, Primary.Green100, Accent.Blue400, TextShade.WHITE);

            lblTitulo.Text = _titulo;
            lblMensaje.Text = _mensaje;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Grey900, Primary.Green100, Accent.Blue400, TextShade.WHITE);
            this.Close();
            
        }

        private void ModalNotificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Grey900, Primary.Green100, Accent.Blue400, TextShade.WHITE);
        }
    }
}
