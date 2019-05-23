using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Enums;

namespace UI_StudioX.Models
{
    public class Klant
    {
        [Key]
        public int Id { get; private set; }
        public string VoorNaam { get; private set; }
        public string AchterNaam { get; private set; }
        public Gender Geslacht { get; private set; }
        public DateTime GeboorteDatum { get; private set; }
        public string TelefoonNummer { get; private set; }
        public string EmailAdres { get; private set; }
        public string Straat { get; private set; }
        public int HuisNummer { get; private set; }
        public string PostCode { get; private set; }
        public string WoonPlaats { get; private set; }
        public string Gebruikersnaam { get; }
        public string Wachtwoord { get; private set; }
        [Key]
        public int StudioId { get; private set; }
    }
}
