﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dkPGAownership.Models
{
    public class Golfer
    {
        public int ID { get; set; }

        public int DKTourneyID { get; set; }

        public int Playerid { get; set; }

        public int Salary { get; set; }

        public string Name { get; set; }

        public string GameInfo { get; set; }

        public int YearCreated { get; set; }

        private double _exposure;

        public double Exposure
        {
            get
            {
                return _exposure;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    _exposure = 0;
                    return;
                }

                _exposure = value;
            }
        }

        public string Website { get; set; }


        public Golfer()
        {
            Exposure = 0;
        }
    }
}
