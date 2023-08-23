using BusinessLogic;
using DataAccess;
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
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        private UsuarioBL usuarioBL = new UsuarioBL();
        private int intentos = 0;
        private bool exito = false;
        public FormLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;

            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Grey900, Primary.Green100, Accent.Blue700, TextShade.WHITE);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (intentos < 3)
            {
                try
                {
                    string usuario = txtUsuario.Text.ToString();
                    string password = txtContrasennia.Text.ToString();
                   
                    if (String.IsNullOrWhiteSpace(usuario) || String.IsNullOrEmpty(usuario) || String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(password))
                    {
                        ModalNotificacion modal = new ModalNotificacion("Los campos no pueden estar vacíos", "Error", Primary.Yellow600, Accent.Yellow700);
                        modal.TopMost = true;
                        modal.ShowDialog();
                    }
                    else
                    {
                        string llave = usuarioBL.obtenerKey(usuario);
                        int usuarioLogin = usuarioBL.loginUsuario(usuario, password, llave);

                        if (usuarioLogin == 0)
                        {

                            ModalNotificacion modal = new ModalNotificacion("Datos incorrectos", "Error", Primary.Yellow600, Accent.Yellow700);
                            modal.TopMost = true;
                            modal.ShowDialog();
                        }
                        else
                        {

                            exito = true;
                            this.Close();
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
            else
            {
                ModalNotificacion modal = new ModalNotificacion("Sistema bloqueado, 3 intentos fallidos", "Error", Primary.Red600, Accent.Red700);
                modal.TopMost = true;
                modal.ShowDialog();
                this.Close();
            }

            txtContrasennia.Text = "";
            txtUsuario.Text = "";
            intentos++;
            
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exito)
            {
                Application.Exit();
            }

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
