using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_2020
{
    class Sekretær : Medarbejder
    {
        protected int SkriveHastighed { get; set; }

        // importer data fra SQL database
        public override void ImportData()
        {
            throw new NotImplementedException();
        }

    }
}
