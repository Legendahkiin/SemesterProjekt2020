using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_2020
{
    abstract class Medarbejder
    {
        // info om medarbejder
        protected string Navn { get; set; }
        protected string Email { get; set; }
        protected string TlfNr { get; set; }
        protected string Adresse { get; set; }
        protected int MedarbejderID { get; set; }

        // importer data fra SQL database
        public abstract void ImportData();

    }
}
