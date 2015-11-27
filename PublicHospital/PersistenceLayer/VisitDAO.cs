using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace PersistenceLayer
{
    public class VisitDAO
    {
        public VisitBDO GetVisit(int id)
        {
            VisitBDO VisitBDO = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var VisitObj = (from v in PHEntities.Visit
                                      where v.Ap_Id == id
                                      select v).FirstOrDefault();
                if (VisitObj != null)
                    VisitBDO = new VisitBDO()
                    {
                        id = VisitObj.Ap_Id,
                        patientProblem = VisitObj.patientProblem,
                        symptom = VisitObj.symptom,
                        advice = VisitObj.advice
                    };
            }
            return VisitBDO;
        }

        public List<VisitBDO> GetAllVisits()
        {
            List<VisitBDO> Visits = null;
            VisitBDO VisitBDO = null;
            using (var PHEntities = new PublicHospitalEntities())
            {
                var listInDb = (from d in PHEntities.Visit
                                select d).ToList();
                if (listInDb != null)
                {
                    Visits = new List<VisitBDO>();
                    VisitBDO = new VisitBDO();
                    foreach (Visit VisitObj in listInDb)
                    {
                        if (VisitObj != null)
                        {
                            VisitBDO = new VisitBDO()
                            {
                                id = VisitObj.Ap_Id,
                                patientProblem = VisitObj.patientProblem,
                                symptom = VisitObj.symptom,
                                advice = VisitObj.advice

                            };
                            Visits.Add(VisitBDO);
                        }
                    }
                }
            }
            return Visits;
        }

        public bool InsertVisit(ref VisitBDO VisitBDO,
            ref string massage)
        {
            massage = "Visit inserted successfully";
            var ret = true;
            using (var PHEntities = new PublicHospitalEntities())
            {
                PHEntities.Visit.Add(new Visit
                {
                    Ap_Id = VisitBDO.id,
                    advice = VisitBDO.advice,
                    symptom = VisitBDO.symptom,
                    patientProblem = VisitBDO.patientProblem
                });
                var num = PHEntities.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    massage = "Visit was not inserted";
                }
            }
            return ret;
        }

        public bool UpdateVisit(ref VisitBDO VisitBDO)
        {
            var ret = true;
            using (var PHEntites = new PublicHospitalEntities())
            {
                var VisitId = VisitBDO.id;
                var VisitInDb = (from a
                                 in PHEntites.Visit
                                       where a.Ap_Id == VisitId
                                       select a).FirstOrDefault();
                if (VisitInDb == null)
                {
                    throw new Exception("No Visit with id " +
                                        VisitBDO.id);
                }
                VisitInDb.Ap_Id = VisitBDO.id;
                VisitInDb.advice = VisitBDO.advice;
                VisitInDb.symptom = VisitBDO.symptom;
                VisitInDb.patientProblem = VisitBDO.patientProblem;
                //without username and pass
                PHEntites.Visit.Attach(VisitInDb);
                PHEntites.Entry(VisitInDb).State = System.Data.Entity.EntityState.Modified;
                var num = PHEntites.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                }
            }
            return ret;
        }
    }
}
}
