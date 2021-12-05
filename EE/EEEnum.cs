using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEEnum
    {
       
            public int Cod_Enum { get; set; }
            public string Descripcion { get; set; }
            

            public override string ToString()
            {
                return Cod_Enum + "-" + Descripcion;
            }
        

        
    }
}
