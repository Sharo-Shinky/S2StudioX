﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public interface IStudioDAL
    {
        void Update(StudioStruct studioStruct);

        void UpdateGebruikersNaam(); //UPDATE OP BASIS VAN ID of "string gebruikersnaam"??

        void UpdateWachtwoord(string wachtwoord);
    }
}
