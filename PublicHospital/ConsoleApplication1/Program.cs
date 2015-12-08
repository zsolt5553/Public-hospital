using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            DateTime.TryParse("2015-12-12 15:00:00.000", out date);
            //DoctorServiceRef.Doctor ddd = new DoctorServiceRef.DoctorServiceClient().GetDoctor(2);
            //AppointmentServiceRef.Doctor doc = new AppointmentServiceRef.Doctor();
            //doc.id = ddd.id;
            var client = new AppointmentServiceRef.AppointmentServiceClient();
            string[] list = client.getAppointmentsByDocAndDate(date, 2);
        }
    }
}
