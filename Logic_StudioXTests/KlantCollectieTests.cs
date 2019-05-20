using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic_StudioX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace Logic_StudioX.Tests
{
    public enum Gender
    {
        // LET OP, deze enum wordt ook gebruikt in de logic laag.
        // Belangrijk dat de volgorde van de set het zelfde blijft in elke laag.
        // Dit omdat er gecast wordt
        Onbekend,
        Man,
        Vrouw
    }
    [TestClass()]
    public class KlantCollectieTests
    {
        
    }
}