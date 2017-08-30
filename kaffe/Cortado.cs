using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class Cortado : Kaffe, Imælk
    {
        /// <summary>
        /// Hvor meget mælk skal der i en Cortado (i ml)
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 25;
        }

        /// <summary>
        /// Prisen på Cortado
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 25;
        }
    }
}
