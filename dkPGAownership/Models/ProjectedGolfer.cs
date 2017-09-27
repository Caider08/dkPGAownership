﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dkPGAownership.Models
{
    public class ProjectedGolfer
    {
        public int ID { get; set; }

        public int GolferID { get; set; }

        public int DKtourneyID { get; set; }

        public string Name { get; set; }

        public int Tags { get; set; }

        public int Salary { get; set; }

        public int Start { get; set; }

        public int Sit { get; set; }

        public double Projection { get; set; }
    }
}