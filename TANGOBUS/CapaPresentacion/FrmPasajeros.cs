using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmPasajeros : Form
    {
        readonly E_Pasajeros ObjEntidad = new E_Pasajeros();
        readonly N_Pasajeros ObjNegocios = new N_Pasajeros();

        public FrmPasajeros()
        {
            InitializeComponent();
        }


        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Tango Bus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Tango Bus", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimpiarCajas()
        {
            txtCodigo.Text = "";
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtDni.Text = "";
            txtNacionalidad.Text = "";
            txtMayor.Text = "";
            txtAscenso.Text = "";
            txtGrupo.Text = "";
            txtTelefonos.Text = "";
            txtFecha.Text = "";
            txtDestino.Text = "";
        }

        

       

      

        

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Trim() != ""| txtApellidos.Text.Trim() != "" )
            {
                if (Program.evento == 0)
                {
                    try
                    {
                        ObjEntidad.Apellidos = txtApellidos.Text.ToUpper();
                        ObjEntidad.Nombres = txtNombres.Text.ToUpper();
                        ObjEntidad.Dni = txtDni.Text.ToUpper();
                        ObjEntidad.Nacionalidad = txtNacionalidad.Text.ToUpper();
                        ObjEntidad.Mayor = txtMayor.Text.ToUpper();
                        ObjEntidad.Ascenso = txtAscenso.Text.ToUpper();
                        ObjEntidad.Telefonos = txtTelefonos.Text.ToUpper();
                        ObjEntidad.Fecha = txtFecha.Text.ToUpper();
                        ObjEntidad.Destino = txtDestino.Text.ToUpper();
                        ObjEntidad.Grupo = txtGrupo.Text.ToUpper();


                        ObjNegocios.InsertarRegistros(ObjEntidad);
                        MensajeConfirmacion("Se Inserto Correctamente");
                        Program.evento = 0;
                        LimpiarCajas();
                        Close();
                    }
                    catch (Exception)
                    {
                        MensajeError("No se Pudo Insertar el Registro");
                    }
                }
                else
                {
                    try
                    {
                        ObjEntidad.IdPasajeros = Convert.ToInt32(txtCodigo.Text.ToUpper());
                        ObjEntidad.Apellidos = txtApellidos.Text.ToUpper();
                        ObjEntidad.Nombres = txtNombres.Text.ToUpper();
                        ObjEntidad.Dni = txtDni.Text.ToUpper();
                        ObjEntidad.Nacionalidad = txtNacionalidad.Text.ToUpper();
                        ObjEntidad.Mayor = txtMayor.Text.ToUpper();
                        ObjEntidad.Ascenso = txtAscenso.Text.ToUpper();
                        ObjEntidad.Telefonos = txtTelefonos.Text.ToUpper();
                        ObjEntidad.Fecha = txtFecha.Text.ToUpper();
                        ObjEntidad.Destino = txtDestino.Text.ToUpper();
                        ObjEntidad.Grupo = txtGrupo.Text.ToUpper();

                        ObjNegocios.EditarRegistros(ObjEntidad);

                        MensajeConfirmacion("Se Modifico Correctamente");
                        Program.evento = 0;
                        LimpiarCajas();
                        Close();
                    }
                    catch (Exception)
                    {
                        MensajeError("No se Pudo Editar el Registro");
                    }
                }
           }
           else
           {
                MensajeError("Llene los Campos Correspondientes para Guardar el Registro"); 
           }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void PbCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPasajeros_Load(object sender, EventArgs e)
        {

        }






    }
}
