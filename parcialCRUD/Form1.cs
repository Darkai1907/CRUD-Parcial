using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcialCRUD
{
    public partial class Form1 : Form
    {
        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n = dtgvtablas.Rows.Add();

            dtgvtablas.Rows[n].Cells[0].Value = txtnombre.Text;
            dtgvtablas.Rows[n].Cells[1].Value = txtDescripcion.Text;
            dtgvtablas.Rows[n].Cells[2].Value = txtExistencia.Text;
            dtgvtablas.Rows[n].Cells[3].Value = txtFechaVencimiento.Text;
            dtgvtablas.Rows[n].Cells[4].Value = txtFechaCreacion.Text;
            dtgvtablas.Rows[n].Cells[5].Value = txtmarca.Text;
            dtgvtablas.Rows[n].Cells[6].Value = txtCategoria.Text;
            dtgvtablas.Rows[n].Cells[7].Value = txtEstado.Text;

            txtnombre.Text = "";
            txtDescripcion.Text = "";
            txtExistencia.Text = "";
            txtFechaVencimiento.Text = "";
            txtFechaCreacion.Text = "";
            txtmarca.Text = "";
            txtCategoria.Text = "";
            txtEstado.Text = "";



        }

        private void dtgvtablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dtgvtablas.Rows.RemoveAt(n);
        }
    }
}
