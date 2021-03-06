﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class VisitBDO
    {
        public int id { get; set; }
        public string patientProblem { get; set; }
        public string symptom { get; set; }
        public string advice { get; set; }
        public byte[] rowVersion { get; set; }

        public VisitBDO() { }

        public VisitBDO(int id, string patientProblem, string symptom, string advice)
        {
            this.id = id;
            this.patientProblem = patientProblem;
            this.symptom = symptom;
            this.advice = advice;
        }
    }
}
