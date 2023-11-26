using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPedirInforme
    {
        public event Action OnPedirInforme;
        public void MensajeError();
    }
}
