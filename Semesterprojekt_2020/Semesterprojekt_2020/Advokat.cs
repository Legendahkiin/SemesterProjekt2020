using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_2020
{
    class Advokat : Medarbejder
    {
        // string der beskriver advokatens kompetence(r)
        protected string Uddannelse { get; set; }

        // importer data fra SQL database
        public override void ImportData()
        {
            throw new NotImplementedException();
        }

    }
}
