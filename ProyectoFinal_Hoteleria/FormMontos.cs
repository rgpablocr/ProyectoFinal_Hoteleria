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
    public partial class FormMontos : MaterialSkin.Controls.MaterialForm
    {

        private ReservacionBL reservacionBL = new ReservacionBL();
        private HotelBL hotelBL = new HotelBL();
        private HabitacionBL habitacionBL = new HabitacionBL();
        private ClienteBL clienteBL = new ClienteBL();

        private string _codReservacion;
        public FormMontos(string codReservacion)
        {

            InitializeComponent();
            _codReservacion = codReservacion;

        }

        private void FormMontos_Load(object sender, EventArgs e)
        {
            try
            {
                Reservacion reservacion = reservacionBL.cargarReservacionesPorId(_codReservacion);
                string codHotel = habitacionBL.cargarHotelPorHabitacion(reservacion.CodHabitacion).CodHotel;
                Hotel hotel = hotelBL.cargarHotelPorId(codHotel);
                Habitacion habitacion = habitacionBL.cargarHabitacionPorId(reservacion.CodHabitacion.ToString());

                lblNombreHotel.Text = hotel.Nombre.ToString();
                lblDireccionHotel.Text = hotel.Direccion.ToString();
                lblTelefonoHotel.Text = hotel.Telefono.ToString();

                Cliente cliente = clienteBL.cargarClientePorID(reservacion.Cedula);

                lblCedula.Text = cliente.Cedula.ToString();
                lblCorreo.Text = cliente.Email.ToString();
                lblTelefono.Text = cliente.Telefono.ToString();
                lblNombre.Text = cliente.Nombre.ToString() + " " + cliente.Apellido1.ToString() + " " + cliente.Apellido2.ToString();

                txtCodHabitacion.Text = habitacion.CodHabitacion.ToString();
                txtCodHotel.Text = habitacion.CodHotel.ToString();
                txtPrecioFinal.Text = "₡ " + habitacion.PrecioFinal.ToString();
                cbxSoleado.Checked = habitacion.Soleada == "Sí" ? true : false;
                cbxNevera.Checked = habitacion.Nevera == "Sí" ? true : false;
                cbxLavado.Checked = habitacion.Lavado == "Sí" ? true : false;

                lvReservaciones.Items.Clear();

                ListViewItem item = new ListViewItem(reservacion.CodReservacion.ToString());
                item.SubItems.Add(reservacion.Cedula.ToString());
                item.SubItems.Add(reservacion.FechaLlegada.ToString("dd/MM/yyyy"));
                item.SubItems.Add(reservacion.FechaSalida.ToString("dd/MM/yyyy"));
                item.SubItems.Add(reservacion.CodHabitacion.ToString());
                item.SubItems.Add(reservacion.MetodoPago.ToString());
                lvReservaciones.Items.Add(item);

                lblUnitario.Text = "₡ " + habitacion.PrecioFinal.ToString();
                lblTotal.Text = "₡ " + reservacion.Cancelado.ToString();

            }
            catch (Exception ex)
            {

                ModalNotificacion modal = new ModalNotificacion(ex.ToString(), "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
