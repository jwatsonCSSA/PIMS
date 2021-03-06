﻿using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class ChargesComparer : ICompare<Charges>
    {
        public void Compare(Charges charge1, Charges charge2)
        {
            Assert.That(charge1.chargeId, Is.EqualTo(charge2.chargeId));
            Assert.That(charge1.description, Is.EqualTo(charge2.description));
            Assert.That(charge1.amountTotal, Is.EqualTo(charge2.amountTotal));
            Assert.That(charge1.dateCharged, Is.EqualTo(charge2.dateCharged));
            Assert.That(charge1.dateDue, Is.EqualTo(charge2.dateDue));
            Assert.That(charge1.procedureId, Is.EqualTo(charge2.procedureId));
            Assert.That(charge1.officeStaffId, Is.EqualTo(charge2.officeStaffId));
            Assert.That(charge1.patientId, Is.EqualTo(charge2.patientId));
        }
    }
}
