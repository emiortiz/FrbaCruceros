using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Clases;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ModificarTramos : Frame
    {
        private ModificacionRecorrido padre;
        private Recorrido recorrido;
        private List<Tramo> tramos;
        private List<Tramo> tramosAAgregar = new List<Tramo>();
        private List<Tramo> tramosAQuitar = new List<Tramo>();
        private int inhabilitado;

        public ModificarTramos(ModificacionRecorrido _padre, Recorrido _recorrido)
        {
            InitializeComponent();
            padre = _padre;
            recorrido = _recorrido;
            tramos = recorrido.Tramos;
            Titulo.Text = "Modificar tramos de: " + recorrido.Id;
            foreach (Tramo t in tramos)
            {
                agregarAlDataGrid(t);
            }
            recalcularTotal();
            inhabilitado = recorrido.Inhabilitado;
            cbInhabilitado.Checked = (recorrido.Inhabilitado == 1);
        }

        //--Agrego un tramo al recorrido que aun no ha sido persistido
        public void addNonPersistedTramo(Tramo nuevoTramo)
        {
            if (this.nohayUnTramoConElMismoPuertoDeInicioYDeDestino(nuevoTramo))
            {
                int id = Database.persistirTramo(nuevoTramo);
                nuevoTramo.Id = id;
                if (!tramosAAgregar.Any(t => t.Id == id))
                {
                    tramosAAgregar.Add(nuevoTramo);
                }
                //addId(nuevoTramo);
                tramos.Add(nuevoTramo);
                agregarAlDataGrid(nuevoTramo);
                recalcularTotal();
            }
        }

        //--Agrego un tramo al recorrido que ya habia sido persistido con anterioridad
        public void addPersistedTramo(Tramo nuevoTramo)
        {
            if (this.nohayUnTramoConElMismoPuertoDeInicioYDeDestino(nuevoTramo))
            {
                tramos.Add(nuevoTramo);
                if (!tramosAAgregar.Any(t => t.Id == nuevoTramo.Id))
                {
                    tramosAAgregar.Add(nuevoTramo);
                }
                agregarAlDataGrid(nuevoTramo);
                recalcularTotal();
            }
        }

        //--Verifico que no haya un tramo con las mismas ccas ya agregado
        private bool nohayUnTramoConElMismoPuertoDeInicioYDeDestino(Tramo nuevoTramo)
        {
            return !this.tramos.Any(t =>
            {
                return t.PuertoInicio.Id == nuevoTramo.PuertoInicio.Id && t.PuertoDestino.Id == nuevoTramo.PuertoDestino.Id;
            });
        }

        //--Agrego una id temporal a los tramos sin persistir para poder referenciarlos desde el dataGridView
        private void addId(Tramo tramo)
        {
            if (tramos.Count() > 0)
            {
                int max = tramos.Max(t => t.Id);
                tramo.Id = max + 1;
            }
            else
            {
                tramo.Id = 1;
            }

        }

        //--Sumo todos los precios de todos los tramos
        private void recalcularTotal()
        {
            int total = tramos.Sum(t => t.Precio);
            lblPrecio.Text = "Precio total: " + total.ToString();
        }

        //--Cargo los tramos en el dataGridView
        private void agregarAlDataGrid(Tramo tramo)
        {
            Puerto puertoInicio = tramo.PuertoInicio;
            Puerto puertoDestino = tramo.PuertoDestino;
            int precio = tramo.Precio;
            DGVTramos.Rows.Add(puertoInicio.Nombre, puertoDestino.Nombre, precio, tramo.Id, "Quitar");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            new AltaTramo(this).ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            new SeleccionarTramo(this).ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.ModificarTramos_FormClosed(sender, new FormClosedEventArgs(CloseReason.UserClosing));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DGVTramos.Rows.Count >= 1)
            {
                this.quitarTramos();
                this.agregarTramos();
                this.actualizarOrdenDeTramos();
                actualizarInhabilitacion();
                ventanaInformarExito("Su recorrido ha sido modificado.");
                actualizarRecorridos();
            }
            else
            {
                ventanaInformarError("El recorrido debe poseer minimamente un tramo, tu otra alternativa es darlo de baja.");
            }
        }

        private void actualizarOrdenDeTramos()
        {
            Database.actualizarOrdenDeTramosDelRecorrido(this.recorrido.Id);
        }

        private void actualizarInhabilitacion()
        {
            if (inhabilitado != recorrido.Inhabilitado)
            {
                recorrido.Inhabilitado = inhabilitado;
                Database.actualizarInhabilitacionDeRecorrido(recorrido.Id, inhabilitado);
            }
        }

        private void actualizarRecorridos()
        {
            recorrido.reload();
            tramosAAgregar.Clear();
            tramosAQuitar.Clear();
            List<Recorrido> recorridos = padre.Recorridos;
            recorridos.ForEach(r =>
            {
                if (r.Id == recorrido.Id)
                {
                    r = recorrido;
                }
            });
            padre.Recorridos = recorridos;
        }

        private void quitarTramos()
        {
            if (this.tramosAQuitar.Count() > 0)
            {
                Database.eliminarRecorridoTramo(recorrido.Id, tramosAQuitar);
            }
        }

        private void agregarTramos()
        {
            if (this.tramosAAgregar.Count() > 0)
            {
                int idRecorrido = recorrido.Id;
                Database.persistirRecorridoTramo(idRecorrido, tramosAAgregar);
            }
        }

        private void ModificarTramos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void DGVTramos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int idTramo = Int32.Parse(this.DGVTramos[3, e.RowIndex].Value.ToString());
                if (!tramosAQuitar.Any(t => t.Id == idTramo))
                {
                    Tramo tr = tramos.Where(t => t.Id == idTramo).First();
                    tramosAQuitar.Add(tr); ;
                }
                tramos = tramos.Where(t => t.Id != idTramo).ToList();

                this.DGVTramos.Rows.RemoveAt(e.RowIndex);
                recalcularTotal();
            }
        }

        private void cbInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            inhabilitado = (cbInhabilitado.Checked ? 1 : 0);
        }
    }
}