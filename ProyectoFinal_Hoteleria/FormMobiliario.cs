using BusinessLogic;
using MaterialSkin;
using Model;
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
    public partial class FormMobiliario : MaterialSkin.Controls.MaterialForm
    {

        private MobiliarioBL mobiliarioBL = new MobiliarioBL();
        private HabitacionBL habitacionBL = new HabitacionBL();
        private int codHabitacionNueva = 0;


        public FormMobiliario(List<MobiliarioHabitacion> mobiliarioHabitaciones, int habitacion)
        {
            InitializeComponent();

            lvMobiliario.Items.Clear();
            foreach (MobiliarioHabitacion h in mobiliarioHabitaciones)
            {
                ListViewItem item = new ListViewItem(h.Codigo.ToString());
                item.SubItems.Add(h.CodHabitacion.ToString());
                item.SubItems.Add(h.CodMobiliario.ToString());
                item.SubItems.Add(h.Descripcion.ToString());
                item.SubItems.Add(h.Precio.ToString());
                lvMobiliario.Items.Add(item);
                lvMobiliario.Visible = true;
            }

            lblCodHabitacion.Text = habitacion.ToString();

        }

            private void FormMobiliario_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvHabitacionesTraslado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHabitacionesTraslado.SelectedItems.Count > 0)
            {

                codHabitacionNueva = int.Parse(lvHabitacionesTraslado.SelectedItems[0].Text);
                int codigo = int.Parse( txtCodigo.Text);
                int codMobiliario = int.Parse(txtCodMobiliario.Text);

                int status = mobiliarioBL.cambiarMobililarioHabitacion(codigo, codHabitacionNueva, codMobiliario);

                int codHabitacionActual = int.Parse(txtCodHabitacion.Text);

                habitacionBL.actualizarPrecioHabitacion(codHabitacionNueva);
                habitacionBL.actualizarPrecioHabitacion(codHabitacionActual);


                if (status > 0)
                {
                    ModalNotificacion modal = new ModalNotificacion("Se ha trasladado el mobiliario " + txtDescripcion.Text.ToString() + " a la habitación " + codHabitacionNueva.ToString() , "Notificación", Primary.Green600, Accent.Green700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                    
                }
                else
                {
                    ModalNotificacion modal = new ModalNotificacion("Ha ocurrido un error al trasladar el mobiliario", "Notificación", Primary.Red900, Accent.Red700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                }

                this.Close();


            }
        }

        private void lvMobiliario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvMobiliario.SelectedItems.Count > 0)
            {
                int id = int.Parse(lvMobiliario.SelectedItems[0].Text);

                MobiliarioHabitacion mobiliarioHabitacion = mobiliarioBL.cargarMobililarioPorId(id);

                txtCodigo.Text = mobiliarioHabitacion.Codigo.ToString();
                txtCodHabitacion.Text = mobiliarioHabitacion.CodHabitacion.ToString();
                txtCodMobiliario.Text = mobiliarioHabitacion.CodMobiliario.ToString();
                txtDescripcion.Text = mobiliarioHabitacion.Descripcion.ToString();
                txtPrecio.Text = mobiliarioHabitacion.Precio.ToString();

                List<Habitacion> habitaciones = habitacionBL.cargarHabitaciones(int.Parse(txtCodHabitacion.Text));
                lvHabitacionesTraslado.Items.Clear();

                foreach (Habitacion h in habitaciones)
                {
                    ListViewItem item = new ListViewItem(h.CodHabitacion.ToString());
                    item.SubItems.Add(h.CodHotel.ToString());
                    lvHabitacionesTraslado.Items.Add(item);
                    lvHabitacionesTraslado.Visible = true;
                }

            }
            
        }

        private void lblCodHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarHabitacion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
