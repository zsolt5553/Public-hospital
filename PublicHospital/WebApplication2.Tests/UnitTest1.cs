using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WebApplication2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime date = new DateTime();
            date.AddYears(2015);
            date.AddMonths(12);
            date.AddDays(12);
        //    DoctorServiceRef.Doctor ddd = new DoctorServiceRef.DoctorServiceClient().GetDoctor(1);
      //      AppointmentServiceRef.Doctor doc = new AppointmentServiceRef.Doctor();
      //      doc.id = ddd.id;
     //       var client = new AppointmentServiceRef.AppointmentServiceClient();
     //       string[] list = client.getAppointmentsByDocAndDate(date, ref doc);
        }
    }
}
