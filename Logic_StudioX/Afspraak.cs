﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;

namespace Logic_StudioX
{
    public class Afspraak
    {
        public int Id { get; private set; }
        public DateTime BeginTijd { get; private set; }
        public DateTime EindTijd { get; private set; }
        public string Opmerking { get; private set; }
        public int KlantId { get; private set; }
        public int StudioId { get; private set; }

        private IAfspraakDAL AfspraakDAL = Factory.CreateAfspraakDAL();

        public Afspraak(AfspraakStruct afspraakStruct)
        {
            Id = afspraakStruct.Id;
            BeginTijd = afspraakStruct.BeginTijd;
            EindTijd = afspraakStruct.EindTijd;
            Opmerking = afspraakStruct.Opmerking;
            KlantId = afspraakStruct.KlantId;
            StudioId = afspraakStruct.StudioId;
        }

        public void UpdateAfspraak(int id ,DateTime beginTijd, DateTime eindTijd, string opmerking)
        {
            if (beginTijd != BeginTijd)
            {
                BeginTijd = beginTijd;
            }

            if (eindTijd != EindTijd)
            {
                EindTijd = eindTijd;
            }

            if (opmerking != "")
            {
                Opmerking = opmerking;
            }
        }
    }
}
