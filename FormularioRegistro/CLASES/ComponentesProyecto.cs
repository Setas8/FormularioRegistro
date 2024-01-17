using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioRegistro.CLASES
{
    public class ComponentesProyecto
    {

        private string codigoProyecto;
        private string idEmpleado;
        private string puesto;
        private float porcentajeDedicacion;
        private decimal extras;

        public ComponentesProyecto() { }
        public ComponentesProyecto(string codigoProyecto, string idEmpleado, string puesto, float porcentajeDedicacion, decimal extras)
        {
            this.CodigoProyecto = codigoProyecto;
            this.IdEmpleado = idEmpleado;
            this.Puesto = puesto;
            this.PorcentajeDedicacion = porcentajeDedicacion;
            this.Extras = extras;
        }
        public ComponentesProyecto(string codigoProyecto, string idEmpleado)
        {
            this.CodigoProyecto = codigoProyecto;
            this.IdEmpleado = idEmpleado;
        }
        public string CodigoProyecto { get => codigoProyecto; set => codigoProyecto = value; }
        public string IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public float PorcentajeDedicacion { get => porcentajeDedicacion; set => porcentajeDedicacion = value; }
        public decimal Extras { get => extras; set => extras = value; }

        public void cambiarPorcentaje(float porcentaje)
        {
            this.porcentajeDedicacion = porcentaje;
        }
        public bool esJefe()
        {
            bool jefe = false;

            if (this.puesto.Equals("Jefe de proyecto", StringComparison.OrdinalIgnoreCase))
                jefe = true;

            return jefe;
        }
    }
}
