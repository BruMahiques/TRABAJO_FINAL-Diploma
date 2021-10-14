using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using Datos;
using System.Collections;
using System.Data;

namespace MPP
{
    public class MPPPerfilPatente
    {
        public IList<EEPerfilPatente> ObtenerPatentes()
        {
            List<EEPerfilPatente> ListaPatentes = new List<EEPerfilPatente>();

            Acceso AccesoDB = new Acceso();
            DataSet DS = new DataSet();
            DS = AccesoDB.Leer("sp_ListaPermisos", null);

            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in DS.Tables[0].Rows)
                {
                    EEPerfilPatente oPatente = new EEPerfilPatente();

                    oPatente.Id = Convert.ToInt32(Item[0]);
                    oPatente.Permiso = (EEPerfilTipoPermiso)Enum.Parse(typeof(EEPerfilTipoPermiso), Convert.ToString(Item[1]));
                    oPatente.Descripcion = Item[2].ToString().Trim();

                    ListaPatentes.Add(oPatente);
                }

                return ListaPatentes;
            }
            else
            {
                return null;
            }
        }
    }
}
