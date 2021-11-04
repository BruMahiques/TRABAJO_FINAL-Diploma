using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using System.Data;
using System.Collections;
using Datos;


namespace MPP
{
    public class MPPPerfilFamilia
    {
        public IList<EEPerfilFamilia> ObtenerFamilias()
        {
            List<EEPerfilFamilia> ListaFamilias = new List<EEPerfilFamilia>();

            Acceso AccesoDB = new Acceso();
            DataSet DS = new DataSet();
            DS = AccesoDB.Leer("sp_ListaFamilias", null);

            if (DS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Item in DS.Tables[0].Rows)
                {
                    EEPerfilFamilia oFamilia = new EEPerfilFamilia();

                    oFamilia.Id = Convert.ToInt32(Item[0]);
                    oFamilia.Descripcion = Item[1].ToString().Trim();

                    ListaFamilias.Add(oFamilia);
                }

                return ListaFamilias;
            }
            else
            {
                return null;
            }
        }

        public void GuardarFamilia(EEPerfilFamilia Fam)

        {
            Acceso nAcceso = new Acceso();
            string ConsultaDel = "sp_BorrarFamilia"; // Primero borro la Familia
            Hashtable ParametrosDel = new Hashtable();
            ParametrosDel.Add("Id", Fam.Id);
            nAcceso.EscribirUsu(ConsultaDel, ParametrosDel);

            string ConsultaAdd = "sp_GuardarFamilia"; // Luego guardo la familia actualizada
            Hashtable ParametrosAdd = new Hashtable();
            ParametrosAdd.Add("Cod_Padre", Fam.Id);

            foreach (var item in Fam.Hijos)
            {

                ParametrosAdd.Add("Cod_Hijo", item.Id);
                nAcceso.EscribirUsu(ConsultaAdd, ParametrosAdd);
                ParametrosAdd.Remove("Cod_Hijo");
            }
        }
    }
}
