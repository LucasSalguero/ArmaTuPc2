using ArmaTuPc.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmaTuPc2.FE
{
    public partial class frmInicio : Form
    {
        private PCsArmada Productos = new PCsArmada();
        private List<Procesador> procesadores;
        private List<Componentes> placamadre;
        private List<Componentes> memoria;
        private List<Componentes> almacenamiento;
        private List<Componentes> gpu;
        private List<Componentes> fuente;
        private List<Componentes> gabinete;
        private GestorComponentes gestorcomponentes;

        public frmInicio()
        {
            InitializeComponent();
            gestorcomponentes = new GestorComponentes();
            CargarComponentes();
            dgvPC.DataSource = Productos.ListaPC;
        }

        private void CargarComponentes()
        {
            // Carga de datos de cada componente
            procesadores = gestorcomponentes.CargarProcesadores();
            cboTipo.DataSource = procesadores;
            cboTipo.DisplayMember = "Marca";

            memoria = gestorcomponentes.CargarMemoria();
            cboMemoria.DataSource = memoria;


            almacenamiento = gestorcomponentes.CargarMemoria();
            cboAlmacenamiento.DataSource = almacenamiento;


            gpu = gestorcomponentes.CargarGPU();
            cboGpu.DataSource = gpu;


            fuente = gestorcomponentes.CargarFuente();
            cboFuente.DataSource = fuente;


            gabinete = gestorcomponentes.CargarGabinete();
            cboGabinete.DataSource = gabinete;

            // Todos los combobox en indice -1 para que a la hora de iniciar el 
            // programa no inicie con un componente

            cboModelo.SelectedIndex = -1;
            cboMemoria.SelectedIndex = -1;
            cboAlmacenamiento.SelectedIndex = -1;
            cboGpu.SelectedIndex = -1;
            cboFuente.SelectedIndex = -1;
            cboGabinete.SelectedIndex = -1;
            cboPlaca.SelectedIndex = -1;

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // el Modelo del procesador se carga segun el tipo
            Procesador procesadorElegido = (Procesador)cboTipo.SelectedItem;
            cboModelo.DataSource = procesadorElegido.Modelos;
            cboModelo.DisplayMember = "Nombre";

            // placa madre se carga segun el Modelo del procesador
            placamadre = gestorcomponentes.CargarPlacaMadre(procesadorElegido.Marca);
            cboPlaca.DataSource = placamadre;
            cboPlaca.DisplayMember = "Nombre";
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            PC pcArmada = new PC
            {
                Procesador = (Componentes)cboModelo.SelectedItem,
                PlacaMadre = (Componentes)cboPlaca.SelectedItem,
                RAM = (Componentes)cboMemoria.SelectedItem,
                Almacenamiento = (Componentes)cboAlmacenamiento.SelectedItem,
                GPU = (Componentes)cboGpu.SelectedItem,
                FuentePoder = (Componentes)cboFuente.SelectedItem,
                Gabinete = (Componentes)cboGabinete.SelectedItem
            };
            // Insertar la PC armada en la lista
            Productos.Insert(pcArmada);
            dgvPC.DataSource = null;
            dgvPC.DataSource = Productos.ListaPC;
            MessageBox.Show("PC armada agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // limpiar combobox
            cboModelo.SelectedIndex = -1;
            cboMemoria.SelectedIndex = -1;
            cboAlmacenamiento.SelectedIndex = -1;
            cboGpu.SelectedIndex = -1;
            cboFuente.SelectedIndex = -1;
            cboGabinete.SelectedIndex = -1;
            cboPlaca.SelectedIndex = -1;
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPC.CurrentRow != null && dgvPC.CurrentRow.Index >= 0)
            {
                int indiceFila = dgvPC.CurrentRow.Index;

                if (!dgvPC.Rows[indiceFila].IsNewRow)
                {
                    Productos.ListaPC.Rows.RemoveAt(indiceFila);
                    Productos.ListaPC.WriteXml("PcsArmada.xml");
                    dgvPC.Refresh();
                    MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
