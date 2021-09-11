using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEIdioma
    {
        public int Cod_Idioma { get; set; }
        public string Idioma { get; set; }
        public bool Por_Defecto { get; set; }

        public override string ToString()
        {
            return Idioma;
        }
    }

    public interface IIdiomaObserver
    {
        void UpdateLanguage(EEIdioma idioma);
    }
}
