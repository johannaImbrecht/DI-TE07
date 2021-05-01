using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UtilidadesDashboard;

namespace DAL_Dashboard
{
    public class Almacenamiento
    {
           
        public Almacenamiento()
        {
            
        }

        public List<Empleado> listaEmpleados()
        {

            List<Empleado> misEmpleados = new List<Empleado>();
            Empleado nuevo = new Empleado();
            StreamReader archLeer = null;
            try
            {
                //archLeer = new StreamReader("..\\..\\..\\DAL_Dashboard\\1_datos_comerciales.csv");
                archLeer = new StreamReader("1_datos_comerciales.csv");
                String lineaTitulos = archLeer.ReadLine();
                String lineaDatos = archLeer.ReadLine();
                String[] contenidoTemp = null;
                while (lineaDatos != null)
                {
                    contenidoTemp = lineaDatos.Split(',');
                    int num = int.Parse(contenidoTemp[0]);
                    String nombre = contenidoTemp[1];
                    String apellidos = contenidoTemp[2];
                    String localidad = contenidoTemp[3];
                    int edad = int.Parse(contenidoTemp[4]);
                    nuevo = new Empleado(num, nombre, apellidos, localidad, edad);
                    misEmpleados.Add(nuevo);
                    lineaDatos = archLeer.ReadLine();
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                archLeer.Close();

            }
            return misEmpleados;
        } // fin lista de empleados 

        public Empleado getEmpleadoId(int id)
        {
            List<Empleado> misEmpleados = listaEmpleados();
            Empleado empleado = new Empleado();

            foreach (Empleado empleadoSel in misEmpleados)
            {
                if (empleadoSel.Numero_comercial == id)
                {
                    empleado = empleadoSel;
                }
            }
            return empleado;
        }

        private List<Facturacion> DatosFacturacion()
        {
            List<Facturacion> miFacturacion = new List<Facturacion>();
            Facturacion datos = null;
            StreamReader archivoFact = null;
            try { 
            //archivoFact = new StreamReader("..\\..\\..\\DAL_Dashboard\\2_facturacion_comercial.csv");
            archivoFact = new StreamReader("2_facturacion_comercial.csv");
            String lineaTitulos = archivoFact.ReadLine();
            String lineaDatos = archivoFact.ReadLine();
            
            while (lineaDatos != null && lineaDatos.Length >= 0)
            {
                String[] contenidoTem = lineaDatos.Split(',');
                //int[] arrayDatos = new int[contenidoTem.Length];
                int comercial = int.Parse(contenidoTem[0]);
                int empresa = int.Parse(contenidoTem[1]);
                int ene = int.Parse(contenidoTem[2]);
                int feb = int.Parse(contenidoTem[3]);
                int mar = int.Parse(contenidoTem[4]);
                int abr = int.Parse(contenidoTem[5]);
                int may = int.Parse(contenidoTem[6]);
                int jun = int.Parse(contenidoTem[7]);
                int jul = int.Parse(contenidoTem[8]);
                int ago = int.Parse(contenidoTem[9]);
                int sept = int.Parse(contenidoTem[10]);
                int oct = int.Parse(contenidoTem[11]);
                int nov = int.Parse(contenidoTem[12]);
                int dic = int.Parse(contenidoTem[13]);

                datos = new Facturacion(comercial, empresa, ene,
                    feb, mar, abr, may, jun, jul, ago, sept, oct,
                    nov, dic);
                miFacturacion.Add(datos);
                lineaDatos = archivoFact.ReadLine();
            }
        } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                archivoFact.Close();

            }
            return miFacturacion;            
        }

        public int facturacionAnualEmpresa(int idEmpresa)
        {
            int totalEmpresa = 0;
            List<Facturacion> miFacturacion = new List<Facturacion>();
            miFacturacion = DatosFacturacion();
            foreach (Facturacion factEmpresa in miFacturacion)
            {
                if(factEmpresa.NumEmpresa == idEmpresa)
                {
                    totalEmpresa += factEmpresa.Ene +
                                factEmpresa.Feb + factEmpresa.Mar +
                                factEmpresa.Abr + factEmpresa.May +
                                factEmpresa.Jun + factEmpresa.Jul +
                                factEmpresa.Ago + factEmpresa.Sept +
                                factEmpresa.Oct + factEmpresa.Nov +
                                factEmpresa.Dic;
                }
            }
            return totalEmpresa;
        } // fin metodo 

        public int facturacionAnualEmpleado(int idEmpleado)
        {
            int totalEmpleado = 0;
            List<Facturacion> miFacturacion = new List<Facturacion>();
            miFacturacion = DatosFacturacion();
            foreach (Facturacion factEmpleado in miFacturacion)
            {
                if (factEmpleado.NumComercial1 == idEmpleado)
                {
                    totalEmpleado += factEmpleado.Ene +
                                factEmpleado.Feb + factEmpleado.Mar +
                                factEmpleado.Abr + factEmpleado.May +
                                factEmpleado.Jun + factEmpleado.Jul +
                                factEmpleado.Ago + factEmpleado.Sept +
                                factEmpleado.Oct + factEmpleado.Nov +
                                factEmpleado.Dic;
                }
            }
            return totalEmpleado;
        } // fin metodo 

        public List<Facturacion> facturacionMensualEmpresa(int idEmpresa)
        {
            List<Facturacion> miFacturacion = new List<Facturacion>();
            miFacturacion = DatosFacturacion();
            List<Facturacion> facturacionMensualEmpresa = new List<Facturacion>();
            Facturacion resumenfactEmpresa = null;
            int ene = 0, feb = 0, mar = 0,
               abr = 0, may = 0, jun = 0,
               jul = 0, ago = 0, sept = 0,
               oct = 0, nov = 0, dic = 0;
            foreach (Facturacion factEmpresa in miFacturacion)
            {
                if (factEmpresa.NumEmpresa == idEmpresa)
                {
                    ene += factEmpresa.Ene;
                    feb += factEmpresa.Feb;
                    mar += factEmpresa.Mar;
                    abr += factEmpresa.Abr;
                    may += factEmpresa.May;
                    jun += factEmpresa.Jun;
                    jul += factEmpresa.Jul;
                    ago += factEmpresa.Ago;
                    sept += factEmpresa.Sept;
                    oct += factEmpresa.Oct;
                    nov += factEmpresa.Nov;
                    dic += factEmpresa.Dic;
                }
                
            }
            resumenfactEmpresa = new Facturacion(idEmpresa, ene, feb, mar,
                    abr, may, jun, jul, ago, sept, oct, nov, dic);
            facturacionMensualEmpresa.Add(resumenfactEmpresa);
            return facturacionMensualEmpresa;
        } // fin metodo 

        public List<Facturacion> facturacionMensualEmpleado(int idEmpleado)
        {
            List<Facturacion> miFacturacion = new List<Facturacion>();
            miFacturacion = DatosFacturacion();
            List<Facturacion> facturacionMensualEmpleado = new List<Facturacion>();
            Facturacion resumenfactEmpleado = null;
            int ene = 0, feb = 0, mar = 0,
               abr = 0, may = 0, jun = 0,
               jul = 0, ago = 0, sept = 0,
               oct = 0, nov = 0, dic = 0;

            foreach (Facturacion factEmpresa in miFacturacion)
            {
                if (factEmpresa.NumComercial1 == idEmpleado)
                {
                    ene += factEmpresa.Ene;
                    feb += factEmpresa.Feb;
                    mar += factEmpresa.Mar;
                    abr += factEmpresa.Abr;
                    may += factEmpresa.May;
                    jun += factEmpresa.Jun;
                    jul += factEmpresa.Jul;
                    ago += factEmpresa.Ago;
                    sept += factEmpresa.Sept;
                    oct += factEmpresa.Oct;
                    nov += factEmpresa.Nov;
                    dic += factEmpresa.Dic;
                }

            }
            resumenfactEmpleado = new Facturacion(idEmpleado, ene, feb, mar,
                    abr, may, jun, jul, ago, sept, oct, nov, dic);
            facturacionMensualEmpleado.Add(resumenfactEmpleado);
            return facturacionMensualEmpleado;
        } // fin metodo 

    }//fin clase 
} // fin namespace
