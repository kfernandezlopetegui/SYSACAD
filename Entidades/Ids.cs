using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ids
    {
        public Ids() { }

        public static int GenerarIdUnico()
        {
            DateTime now = DateTime.Now;
            int dayOfYear = now.DayOfYear;

            // Generar dos números aleatorios de dos dígitos
            Random random = new Random();
            int randomNumber1 = random.Next(10, 100);
            int randomNumber2 = random.Next(10, 100);

            // Combinar el día y los números aleatorios para formar el ID
            int idUnico = dayOfYear * 10000 + randomNumber1 * 100 + randomNumber2;

            return idUnico;
        }
    }
}
