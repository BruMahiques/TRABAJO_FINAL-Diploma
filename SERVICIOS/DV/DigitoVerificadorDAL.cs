﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Collections;
using System.Data;
using EE;

namespace SERVICIOS.DV
{
    public class DigitoVerificadorDAL
    {
        public void ActualizarVertical(int dv)

        {
            Hashtable Parametros = new Hashtable();
            Parametros.Add("@Valor", dv);
            Acceso AccesoDB = new Acceso();
            AccesoDB.EscribirUsu("sp_ActualizarDvUsuario", Parametros);
        }

        public int ObtenerVertical()

        {
            Acceso AccesoDB = new Acceso();
            Hashtable Param = new Hashtable();
            DataSet Ds = new DataSet();

            Ds = AccesoDB.Leer("sp_ObtenerDigitoVerticalUsuario", null);

            int dvv = 0;

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in Ds.Tables[0].Rows)
                {
                    dvv = Convert.ToInt32(Item[1]);
                }
            }
            return dvv;
        }

    }
}
