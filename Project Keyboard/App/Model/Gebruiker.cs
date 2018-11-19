using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    class Gebruiker
    {
        public int Id { get; set; }
        public string gebruikersnaam { get; set; }
        public string voornaam { get; set; }
        public string achternaam { get; set; }
    }
}
