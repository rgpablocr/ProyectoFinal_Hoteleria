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
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Grey900, Primary.Green100, Accent.Blue400, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            HotelBL hotelBL = new HotelBL();
            List<Hotel> hoteles = hotelBL.cargarHoteles();

            foreach (Hotel h in hoteles)
            {

                cbxBuscarHabitacion.Items.Add(h.CodHotel.ToString());
                
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            

          
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cardCliente.Visible = false;
            lvReservaciones.Visible = false;

            string cedula = txtBuscar.Text.ToString();

            if (String.IsNullOrWhiteSpace(cedula) || String.IsNullOrEmpty(cedula))
            {
                ModalNotificacion modal = new ModalNotificacion("El campo no puede estar vacío", "Error", Primary.Red900);
                modal.TopMost = true;
                modal.ShowDialog();
            }
            else
            {

                ClienteBL clienteBL = new ClienteBL();

                Cliente cliente = clienteBL.cargarClientePorID(cedula);

                if (cliente.Cedula != null && cliente.Nombre != null && cliente.Apellido1 != null  && cliente.Apellido2 != null 
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
                        item.SubItems.Add(r.FechaSalida.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(r.FechaSalida.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(r.CodHabitacion.ToString());
                        item.SubItems.Add(r.MetodoPago.ToString());
                        lvReservaciones.Items.Add(item);
                    }

                    cardCliente.Visible = true;
                    lvReservaciones.Visible = true;

                }
                else
                {
                    ModalNotificacion modal = new ModalNotificacion("El cliente no ha sido encontrado", "Notificación", Primary.Yellow700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                }

               
            }

           
        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                        item.SubItems.Add(h.PrecioFinal.ToString());
                        lvHabitaciones.Items.Add(item);
                        lvHabitaciones.Visible = true;
                    }

                }
                else
                {
                    ModalNotificacion modal = new ModalNotificacion("El hotel no tiene habitaciones", "Notificación", Primary.Yellow700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                }

            
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvHabitaciones.SelectedItems.Count > 0)
            {
                string t = lvHabitaciones.SelectedItems[0].Text;
                ModalNotificacion modal = new ModalNotificacion(t, "Error", Primary.Red900);
                modal.TopMost = true;
                modal.ShowDialog();
            }
            else
            {

            }


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            lvHabitaciones.Visible = false;

            string id = txtHabitaciones.Text.ToString();
            int a;

            if (String.IsNullOrWhiteSpace(id) || String.IsNullOrEmpty(id) || int.TryParse(id, out a) == false)
            {
                ModalNotificacion modal = new ModalNotificacion("El campo no puede estar vacío o no coincide el tipo de dato", "Error", Primary.Red900);
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
                    item.SubItems.Add(habitacion.PrecioFinal.ToString());
                    lvHabitaciones.Items.Add(item);
                    lvHabitaciones.Visible = true;

                }
                else
                {
                    ModalNotificacion modal = new ModalNotificacion("La habitación ingresada no existe", "Notificación", Primary.Yellow700);
                    modal.TopMost = true;
                    modal.ShowDialog();
                }


            }
        }
    }
}
