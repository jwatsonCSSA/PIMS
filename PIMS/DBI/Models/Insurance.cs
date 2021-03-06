﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Insurance
    {
        private int _unassigned = -1;

        public int insuranceId { get; set; }
        public string insuranceCarrier { get; set; }
        public string accountNumber { get; set; }
        public string groupNumber { get; set; }
        public int patientId { get; set; }
        public string name { get; set; }

        public Insurance()
        {
            insuranceId = _unassigned;
            insuranceCarrier = string.Empty;
            accountNumber = string.Empty;
            groupNumber = string.Empty;
            patientId = _unassigned;
        }

        public Insurance(string carrier, string accountNumber, string groupNumber, int patientId, int insuranceId)
        {
            insuranceCarrier = carrier;
            this.accountNumber = accountNumber;
            this.groupNumber = groupNumber;
            this.patientId = patientId;
            this.insuranceId = insuranceId;
        }
    }
}
