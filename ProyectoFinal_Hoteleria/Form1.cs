using BusinessLogic;
using DataAccess;
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
    public partial class Form : MaterialSkin.Controls.MaterialForm
    {
        public Form()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;

            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Grey900, Primary.Green100, Accent.Blue700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            HotelBL hotelBL = new HotelBL();
            List<Hotel> hoteles = hotelBL.cargarHoteles();

            foreach (Hotel h in hoteles)
            {
                cbxBuscarHabitacion.Items.Add(h.CodHotel.ToString());
                cbxHotelMobiliario.Items.Add(h.CodHotel.ToString());
            }

            cargarEstadisticas();
        }

        private void cargarEstadisticas()
        {
            ClienteBL clienteBL = new ClienteBL();
            HabitacionBL habitacionBL = new HabitacionBL();
            ReservacionBL reservacionBL = new ReservacionBL();

            int numeroClientes = clienteBL.cargarNumeroClientes();
            int numeroReservaciones = reservacionBL.cargarNumeroReservaciones();
            int numeroHabitaciones = habitacionBL.cargarNumeroHabitaciones();

            lblNumeroClientes.Text = numeroClientes.ToString();
            lblNumeroHabitaciones.Text = numeroHabitaciones.ToString();
            lblNumeroReservaciones.Text = numeroReservaciones.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

            cardCliente.Visible = false;
            lvReservaciones.Visible = false;

            string cedula = txtBuscar.Text.ToString();

            if (String.IsNullOrWhiteSpace(cedula) || String.IsNullOrEmpty(cedula))
            {
                ModalNotificacion modal = new ModalNotificacion("El campo no puede estar vacío", "Error", Primary.Yellow600, Accent.Yellow700);
                modal.TopMost = true;
                modal.ShowDialog();

            }
            else
            {

                ClienteBL clienteBL = new ClienteBL();

                Cliente cliente = clienteBL.cargarClientePorID(cedula);

                if (cliente.Cedula != null && cliente.Nombre != null && cliente.Apellido1 != null && cliente.Apellido2 != null
                    && cliente.Telefono != null && cliente.Direccion != null && cliente.Email != null)
                {
                    txtCedula.Text = cliente.Cedula.ToString();
                    txtNombre.Text = cliente.Nombre.ToString();
                    txtPrimerApellido.Text = cliente.Apellido1.ToString();
                    txtSegundoApellido.Text = cliente.Apellido2.ToString();
                    txtTelefono.Text = cliente.Telefono.ToString();
                    txtEmail.Text = cliente.Email.ToString();
                    txtDireccion.Text = cliente.Direccion.ToString();

                    ReservacionBL reservacionBL = new ReservacionBL();

                    List<Reservacion> reservaciones = reservacionBL.cargarReservacionesPorCliente(cedula);

                    lvReservaciones.Items.Clear();

                    foreach (Reservacion r in reservaciones)
                    {
                        ListViewItem item = new ListViewItem(r.CodReservacion.ToString());
                        item.SubItems.Add(r.Cedula.ToString());
                        item.SubItems.Add(r.FechaLlegada.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(r.FechaSalida.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(r.CodHabitacion.ToString());
                        item.SubItems.Add(r.MetodoPago.ToString());
                        item.SubItems.Add("₡ " + r.Cancelado.ToString());
                        lvReservaciones.Items.Add(item);
                    }

                    cardCliente.Visible = true;
                    lvReservaciones.Visible = true;
                }
                else
                {
                    ModalNotificacion modal = new ModalNotificacion("El cliente no ha sido encontrado", "Notificación", Primary.Yellow600, Accent.Yellow700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                }
            }

            txtBuscar.Text = "";

            }
            catch (Exception ex )
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }
        //PANTALLA MOBILIARIO
        private void btnBucarMobiliario_Click(object sender, EventArgs e)
        {
            try { 
            lvlHabitacionesMobiliario.Visible = false;

            string id = txtHabitacionMobiliario.Text.ToString();
            int a;

            if (String.IsNullOrWhiteSpace(id) || String.IsNullOrEmpty(id) || int.TryParse(id, out a) == false)
            {
                ModalNotificacion modal = new ModalNotificacion("El campo no puede estar vacío o no coincide el tipo de dato", "Error", Primary.Yellow600, Accent.Yellow700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
            else
            {

                HabitacionBL habitacionBL = new HabitacionBL();

                Habitacion habitacion = habitacionBL.cargarHabitacionPorId(id);

                if (habitacion.CodHabitacion != null && habitacion.CodHotel != null && habitacion.Soleada != null && habitacion.Lavado != null
                    && habitacion.Nevera != null && habitacion.Categoria != null && habitacion.PrecioFinal != null)
                {

                    lvlHabitacionesMobiliario.Items.Clear();

                    ListViewItem item = new ListViewItem(habitacion.CodHabitacion.ToString());
                    item.SubItems.Add(habitacion.CodHotel.ToString());
                    item.SubItems.Add(habitacion.Soleada.ToString());
                    item.SubItems.Add(habitacion.Lavado.ToString());
                    item.SubItems.Add(habitacion.Nevera.ToString());
                    item.SubItems.Add(habitacion.Categoria.ToString());
                    item.SubItems.Add(habitacion.PrecioFinal.ToString());
                    lvlHabitacionesMobiliario.Items.Add(item);
                    lvlHabitacionesMobiliario.Visible = true;

                }
                else
                {
                    ModalNotificacion modal = new ModalNotificacion("La habitación ingresada no existe", "Notificación", Primary.Yellow600, Accent.Yellow700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                }
            }

            txtHabitacionMobiliario.Text = "";
            }
            catch (Exception ex)
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }

        private void cbxHotelMobiliario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            lvlHabitacionesMobiliario.Visible = false;

            string id = cbxHotelMobiliario.SelectedItem.ToString();

            HabitacionBL habitacionBL = new HabitacionBL();

            List<Habitacion> habitaciones = habitacionBL.cargarHabitacionPorHotel(id);

            if (habitaciones.Count > 0)
            {
                lvlHabitacionesMobiliario.Items.Clear();
                foreach (Habitacion h in habitaciones)
                {
                    ListViewItem item = new ListViewItem(h.CodHabitacion.ToString());
                    item.SubItems.Add(h.CodHotel.ToString());
                    item.SubItems.Add(h.Soleada.ToString());
                    item.SubItems.Add(h.Lavado.ToString());
                    item.SubItems.Add(h.Nevera.ToString());
                    item.SubItems.Add(h.Categoria.ToString());
                    item.SubItems.Add(h.PrecioFinal.ToString());
                    lvlHabitacionesMobiliario.Items.Add(item);
                    lvlHabitacionesMobiliario.Visible = true;
                }

            }
            else
            {
                ModalNotificacion modal = new ModalNotificacion("El hotel no tiene habitaciones", "Notificación", Primary.Yellow600, Accent.Yellow700);
                modal.TopMost = true;
                modal.ShowDialog();
            }

            }
            catch (Exception ex)
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }

        private void lvlHabitacionesMobiliario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (lvlHabitacionesMobiliario.SelectedItems.Count > 0)
            {
                int codhabitacion = int.Parse(lvlHabitacionesMobiliario.SelectedItems[0].Text);

                MobiliarioBL mobiliarioBL = new MobiliarioBL();

                List<MobiliarioHabitacion> mobiliarioHabitaciones = mobiliarioBL.cargarMobililarioPorHabitacion(codhabitacion);

                if (mobiliarioHabitaciones.Count > 0)
                {
                    lvMobiliario.Items.Clear();
                    foreach (MobiliarioHabitacion h in mobiliarioHabitaciones)
                    {
                        ListViewItem item = new ListViewItem(h.Codigo.ToString());
                        item.SubItems.Add(h.CodHabitacion.ToString());
                        item.SubItems.Add(h.CodMobiliario.ToString());
                        item.SubItems.Add(h.Descripcion.ToString());
                        item.SubItems.Add(  h.Precio.ToString() );  
                        lvMobiliario.Items.Add(item);
                        lvMobiliario.Visible = true;
                    }
                }
                else
                {
                    ModalNotificacion modal = new ModalNotificacion("La habitación no tiene mobiliario", "Notificación", Primary.Yellow600, Accent.Yellow700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                }

            }

            }
            catch (Exception ex)
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }

        private void lvReservaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (lvReservaciones.SelectedItems.Count > 0)
            {
                string codreservacion = lvReservaciones.SelectedItems[0].Text;
                FormMontos formMontos = new FormMontos(codreservacion);
                formMontos.TopMost = true;
                formMontos.ShowDialog();

            }

            }
            catch (Exception ex)
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }

        private void cbxBuscarHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            { 
              lvHabitaciones.Visible = false;

                string id = cbxBuscarHabitacion.SelectedItem.ToString();

                HabitacionBL habitacionBL = new HabitacionBL();

                List<Habitacion> habitaciones = habitacionBL.cargarHabitacionPorHotel(id);

                if (habitaciones.Count > 0)
                {
                    lvHabitaciones.Items.Clear();
                    foreach (Habitacion h in habitaciones)
                    {
                        ListViewItem item = new ListViewItem(h.CodHabitacion.ToString());
                        item.SubItems.Add(h.CodHotel.ToString());
                        item.SubItems.Add(h.Soleada.ToString());
                        item.SubItems.Add(h.Lavado.ToString());
                        item.SubItems.Add(h.Nevera.ToString());
                        item.SubItems.Add(h.Categoria.ToString());
                        item.SubItems.Add("₡ " + h.PrecioFinal.ToString());
                        lvHabitaciones.Items.Add(item);
                        lvHabitaciones.Visible = true;
                    }

                }
                else
                {
                    ModalNotificacion modal = new ModalNotificacion("El hotel no tiene habitaciones", "Notificación", Primary.Yellow600, Accent.Yellow700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }

        private void lvHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            { 
            if (lvHabitaciones.SelectedItems.Count > 0)
            {
                string id = lvHabitaciones.SelectedItems[0].Text;

                HabitacionBL habitacionBL = new HabitacionBL();
                Habitacion habitacion = habitacionBL.cargarHabitacionPorId(id);

                txtCodHabitacion.Text = habitacion.CodHabitacion.ToString();
                txtCodHotel.Text = habitacion.CodHabitacion.ToString();
                txtPrecioFinal.Text = "₡ " + habitacion.PrecioFinal.ToString();
                cbxSoleado.Checked = habitacion.Soleada == "Sí" ? true : false;
                cbxNevera.Checked = habitacion.Nevera == "Sí" ? true : false;
                cbxLavado.Checked = habitacion.Lavado == "Sí" ? true : false;

                cardDatosHabitacion.Visible = true;
            }
            }
            catch (Exception ex)
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }

        private void btnBuscarHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
            lvHabitaciones.Visible = false;

            string id = txtHabitaciones.Text.ToString();
            int a;

            if (String.IsNullOrWhiteSpace(id) || String.IsNullOrEmpty(id) || int.TryParse(id, out a) == false)
            {
                ModalNotificacion modal = new ModalNotificacion("El campo no puede estar vacío o no coincide el tipo de dato", "Error", Primary.Yellow600, Accent.Yellow700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
            else
            {

                HabitacionBL habitacionBL = new HabitacionBL();

                Habitacion habitacion = habitacionBL.cargarHabitacionPorId(id);

                if (habitacion.CodHabitacion != null && habitacion.CodHotel != null && habitacion.Soleada != null && habitacion.Lavado != null
                    && habitacion.Nevera != null && habitacion.Categoria != null && habitacion.PrecioFinal != null)
                {

                    lvHabitaciones.Items.Clear();

                    ListViewItem item = new ListViewItem(habitacion.CodHabitacion.ToString());
                    item.SubItems.Add(habitacion.CodHotel.ToString());
                    item.SubItems.Add(habitacion.Soleada.ToString());
                    item.SubItems.Add(habitacion.Lavado.ToString());
                    item.SubItems.Add(habitacion.Nevera.ToString());
                    item.SubItems.Add(habitacion.Categoria.ToString());
                    item.SubItems.Add("₡ " + habitacion.PrecioFinal.ToString());
                    lvHabitaciones.Items.Add(item);
                    lvHabitaciones.Visible = true;

                }
                else
                {
                    ModalNotificacion modal = new ModalNotificacion("La habitación ingresada no existe", "Notificación", Primary.Yellow600, Accent.Yellow700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                }
            }

            txtHabitaciones.Text = "";
            }
            catch (Exception ex)
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }

        private void btnEditarMobiliario_Click(object sender, EventArgs e)
        {
            try
            {
 
            int habitacion = int.Parse(txtCodHabitacion.Text);

            MobiliarioBL mobiliarioBL = new MobiliarioBL();
            List<MobiliarioHabitacion> mobiliarioHabitaciones = mobiliarioBL.cargarMobililarioPorHabitacion(habitacion);
            if (mobiliarioHabitaciones.Count > 0)
            {

                FormMobiliario formMobiliario = new FormMobiliario(mobiliarioHabitaciones, habitacion);
                formMobiliario.TopMost = true;
                formMobiliario.ShowDialog();
            }
            else
            {
                ModalNotificacion modal = new ModalNotificacion("La habitación no tiene mobiliario", "Notificación", Primary.Yellow600, Accent.Yellow700);
                modal.TopMost = true;
                modal.ShowDialog();

            }

            }
            catch (Exception ex)
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }
    }
}
