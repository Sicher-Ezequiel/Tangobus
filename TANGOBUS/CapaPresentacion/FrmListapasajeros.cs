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
    public partial class FrmListapasajeros : Form
    {
        readonly E_Pasajeros ObjEntidad = new E_Pasajeros();
        readonly N_Pasajeros ObjNegocio = new N_Pasajeros();

        public FrmListapasajeros()
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

        public void AccionesTabla()
        {
            dataListado.Columns[0].Visible = false;


            dataListado.Columns[1].HeaderText = "Apellidos";
            dataListado.Columns[2].HeaderText = "Nombres";
            dataListado.Columns[3].HeaderText = "Dni";
            dataListado.Columns[4].HeaderText = "Ascenso";
            dataListado.Columns[5].HeaderText = "Telefonos";
            dataListado.Columns[6].HeaderText = "Nacionalidad";
            dataListado.Columns[7].HeaderText = "Mayor";
            dataListado.Columns[8].HeaderText = "Fecha";
            dataListado.Columns[9].HeaderText = "Destino";
            dataListado.Columns[10].HeaderText = "Grupo";
        }

        public void MostrarRegistro()
        {
            dataListado.DataSource = N_Pasajeros.MostrarRegistros();
            AccionesTabla();

            for (int i = 0; i < dataListado.RowCount; i++)
            {
                dataListado.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }
        }
        public void BuscarRegistro()
        {
            dataListado.DataSource = N_Pasajeros.BuscarRegistros(txtBuscar.Text);

        }

        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();

        }

        private void FrmPasajeros_Load(object sender, EventArgs e)
        {
            MostrarRegistro();

        }
        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistro();
        }


        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void FrmPasajeros_Load_1(object sender, EventArgs e)
        {
            MostrarRegistro();

        
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistro();
        }
        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            FrmPasajeros nuevoregistro = new FrmPasajeros();

            nuevoregistro.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            nuevoregistro.ShowDialog();
            nuevoregistro.Dispose();
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            FrmPasajeros editarregistros = new FrmPasajeros();
            editarregistros.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            if (dataListado.SelectedRows.Count > 0)
            {
                Program.evento = 1;
                editarregistros.txtCodigo.Text = dataListado.CurrentRow.Cells[0].Value.ToString();
                editarregistros.txtApellidos.Text = dataListado.CurrentRow.Cells[1].Value.ToString();
                editarregistros.txtNombres.Text = dataListado.CurrentRow.Cells[2].Value.ToString();
                editarregistros.txtDni.Text = dataListado.CurrentRow.Cells[3].Value.ToString();
                editarregistros.txtAscenso.Text = dataListado.CurrentRow.Cells[4].Value.ToString();
                editarregistros.txtTelefonos.Text = dataListado.CurrentRow.Cells[5].Value.ToString();
                editarregistros.txtNacionalidad.Text = dataListado.CurrentRow.Cells[6].Value.ToString();
                editarregistros.txtMayor.Text = dataListado.CurrentRow.Cells[7].Value.ToString();
                editarregistros.txtFecha.Text = dataListado.CurrentRow.Cells[8].Value.ToString();
                editarregistros.txtDestino.Text = dataListado.CurrentRow.Cells[9].Value.ToString();
                editarregistros.txtGrupo.Text = dataListado.CurrentRow.Cells[10].Value.ToString();

                editarregistros.ShowDialog();
            }
            else
            {
                MensajeError("Seleccione la Fila a Editar ");
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataListado.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea Eliminar el Registro?", "Tango Bus", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    ObjEntidad.IdPasajeros = Convert.ToInt32(dataListado.CurrentRow.Cells[0].Value.ToString());

                    ObjNegocio.EliminarRegistros(ObjEntidad);

                    MensajeConfirmacion("Se Eliminó Correctamente");
                    MostrarRegistro();
                }
            }
            else
            {
                MensajeError("Seleccione el Registro a ELiminar");
            }
        }



        int lx, ly;
        int sw, sh;

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

   
        }

        private void PbRestau_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            PbRestau.Visible = false;
            PbMaximizar.Visible = true;
        }

        private void PbMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            PbMaximizar.Visible = false;
            PbRestau.Visible = true;
        }

    }
}

    
       