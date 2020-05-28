using System;
using System.Windows.Forms;
using SegundoParcial;

namespace Parcial2
{
    public partial class fmrPrincipalUsuario : Form
    {
        private Usuario pUsuario;
        public fmrPrincipalUsuario(Usuario u)
        {
            InitializeComponent();
            pUsuario = u;
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            string adress = txtDireccion.Text;
            if (adress.Equals(""))
            {
                MessageBox.Show("Llene los espacios en blanco");
            }
            else
            {
                try
                {

                    string sql = $"INSERT INTO ADDRESS(iduser,adress) VALUES(" +
                                 $"'{pUsuario.iduser}'," +
                                 $"'{adress}')";
                    Conexion.realizarAccion(sql);
                    MessageBox.Show("Dirección agregada!");
                    poblar();
                    Limpiar();
                    cargarUsuarios();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void Limpiar()
        {
            txtDireccion.Text = "";
            txtNuevaDireccion.Text = "";
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            string adress = comboEliminarDireccion.Text;
            try
            {

                string sql = $"DELETE FROM ADDRESS WHERE ADRESS = '{adress}' ";
                Conexion.realizarAccion(sql);
                MessageBox.Show("Dirección eliminada!");
                poblar();
                Limpiar();
                cargarUsuarios();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error!");
            }
        }

        private void poblar()
        {
            comboDireccion.DataSource = null;
            comboDireccion.DataSource = adress.getadress();

            comboEliminarDireccion.DataSource = null;
            comboEliminarDireccion.DataSource = adress.getadress();

        }

        private void btnEditarDireccion_Click(object sender, EventArgs e)
        {
            string direccion = comboDireccion.Text;
            string nuevaDireccion = txtNuevaDireccion.Text;
            if (nuevaDireccion.Equals(""))
            {
                MessageBox.Show("Error, usted ha dejado espacios en blanco");
            }
            else
            {
                try
                {

                    string sql = $"UPDATE ADDRESS SET adress = '{nuevaDireccion}' " +
                                 $"WHERE adress ='{direccion}' ";
                    Conexion.realizarAccion(sql);
                    MessageBox.Show("Dirección editada!");
                    poblar();
                    Limpiar();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error!");
                }
            }

            poblar();
            Limpiar();
            cargarUsuarios();
        }

        private void fmrPrincipalUsuario_Load(object sender, EventArgs e)
        {
            poblar();
            cargarUsuarios();

        }

        private void cargarUsuarios()
        {
            var dt = Conexion.realizarConsulta($"SELECT *FROM ADDRESS");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
    }
}