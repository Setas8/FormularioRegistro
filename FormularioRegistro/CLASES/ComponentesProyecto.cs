using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioRegistro.CLASES
{
    public class ComponentesProyecto
    {

        private int codigoProyecto;
        private int idEmpleado;
        private string puesto;
        private float porcentajeDedicacion;
        private decimal extras;

        public ComponentesProyecto() { }
        public ComponentesProyecto(int codigoProyecto, int idEmpleado, string puesto, float porcentajeDedicacion, decimal extras)
        {
            this.codigoProyecto = codigoProyecto;
            this.IdEmpleado = idEmpleado;
            this.Puesto = puesto;
            this.PorcentajeDedicacion = porcentajeDedicacion;
            this.Extras = extras;
        }
        public ComponentesProyecto(int codigoProyecto, int idEmpleado)
        {
            this.codigoProyecto = codigoProyecto;
            this.IdEmpleado = idEmpleado;
        }
        public int CodigoProyecto { get => codigoProyecto; set => codigoProyecto = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public float PorcentajeDedicacion { get => porcentajeDedicacion; set => porcentajeDedicacion = value; }
        public decimal Extras { get => extras; set => extras = value; }

        public void cambiarPorcentaje(float porcentaje)
        {
            this.porcentajeDedicacion = porcentaje;
        }
        public bool esJefe(string jefePro)
        {
            bool jefe = false;

            if (jefePro.Equals("Jefe de proyecto", StringComparison.OrdinalIgnoreCase))
                jefe = true;

            return jefe;
        }
    }
}
