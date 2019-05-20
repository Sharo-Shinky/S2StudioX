﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_StudioX
{
    public interface IKlantCollectie
    {
        void Add(IKlant klant);

        void Remove(int id);

        List<IKlant> GetAll();
    }
}
