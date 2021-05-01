using System;
using System.Collections.Generic;
using System.Text;

namespace UtilidadesDashboard
{
    public class Facturacion
    {
        int numComercial, numEmpresa, ene, feb, mar,
            abr, may, jun, jul, ago, sept, oct, nov, dic;

        public Facturacion (int numComercial, int numEmpresa, int ene,
                            int feb, int mar, int abr, int may, int jun, 
                            int jul, int ago, int sept, int oct, int nov,
                            int dic)
        {
            this.NumComercial1 = numComercial;
            this.NumEmpresa = numEmpresa;
            this.Ene = ene;
            this.Feb = feb;
            this.Mar = mar;
            this.Abr = abr;
            this.May = may;
            this.Jun = jun;
            this.Jul = jul;
            this.Ago = ago;
            this.Sept = sept;
            this.Oct = oct;
            this.Nov = nov;
            this.Dic = dic;
        }

        public Facturacion(int numEmpresa, int ene,
                            int feb, int mar, int abr, int may, int jun,
                            int jul, int ago, int sept, int oct, int nov,
                            int dic)
        {
            this.NumEmpresa = numEmpresa;
            this.Ene = ene;
            this.Feb = feb;
            this.Mar = mar;
            this.Abr = abr;
            this.May = may;
            this.Jun = jun;
            this.Jul = jul;
            this.Ago = ago;
            this.Sept = sept;
            this.Oct = oct;
            this.Nov = nov;
            this.Dic = dic;
        }

        public int NumComercial1 { get => numComercial; set => numComercial = value; }
        public int NumEmpresa { get => numEmpresa; set => numEmpresa = value; }
        public int Ene { get => ene; set => ene = value; }
        public int Feb { get => feb; set => feb = value; }
        public int Mar { get => mar; set => mar = value; }
        public int Abr { get => abr; set => abr = value; }
        public int May { get => may; set => may = value; }
        public int Jun { get => jun; set => jun = value; }
        public int Jul { get => jul; set => jul = value; }
        public int Ago { get => ago; set => ago = value; }
        public int Sept { get => sept; set => sept = value; }
        public int Oct { get => oct; set => oct = value; }
        public int Nov { get => nov; set => nov = value; }
        public int Dic { get => dic; set => dic = value; }
       
    }
}
