using System;
using System.Collections.Generic;
using System.Text;
using DAL_Dashboard;
using UtilidadesDashboard;

namespace BLL_Dashboard
{
    public class Controlador
    {
        private Almacenamiento almacenamiento = new Almacenamiento(); 
        public Controlador()
        {
           
        }

        public List<Empleado> getEmpleados()
        {
            List<Empleado> misEmpleados = new List<Empleado>();
            misEmpleados = almacenamiento.listaEmpleados();
            return misEmpleados;
        }

        public Empleado empleadoId(int id)
        {
            Empleado empleado = almacenamiento.getEmpleadoId(id);
            return empleado;
        }

        public List<Facturacion> getFacturacionMensualEmpleado(int idEmpleado)
        {
            List<Facturacion> factMens = new List<Facturacion>();
            factMens = almacenamiento.facturacionMensualEmpleado(idEmpleado); ;
            return factMens;
        }
        public List<Facturacion> getFacturacionMensual(int idEmpresa)
        {
            List<Facturacion> factMens = new List<Facturacion>();
            factMens = almacenamiento.facturacionMensualEmpresa(idEmpresa);
            return factMens;
        }


        public int GetFacturacionsAnual(int idEmpresa)
        {
            int totalFacturacion = almacenamiento.facturacionAnualEmpresa(idEmpresa);
            return totalFacturacion;
        }

        public int GetFacturacionsAnualEmpleado(int idEmpleado)
        {
            int totalFacturacion = almacenamiento.facturacionAnualEmpleado(idEmpleado);
            return totalFacturacion;
        }
    }
}
