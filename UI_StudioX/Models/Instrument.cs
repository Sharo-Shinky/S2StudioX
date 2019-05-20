using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interface_StudioX;

namespace UI_StudioX.Models
{
    public class Instrument
    {
        [Key]
        public int Id { get;  set; }
        public string Naam { get;  set; }
        //public int StudioId { get;  set; }
        //public int AfspraakId { get;  set; }
    }
}
