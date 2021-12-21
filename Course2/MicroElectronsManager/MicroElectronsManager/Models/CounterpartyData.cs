﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroElectronsManager.Models
{
    public class CounterpartyData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tin { get; set; }
        public string Address { get; set; }
        public string Bic { get; set; }
    }
}
