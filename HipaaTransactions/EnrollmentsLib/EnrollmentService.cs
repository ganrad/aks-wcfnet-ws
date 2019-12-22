using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
*/

namespace EnrollmentsLib
{
    public class EnrollmentService : IEnrollment
    {
        public void HealthCheck()
        {
            System.Console.Write("All OK");
        }

        public EnrollmentType GetEnrollmentsById(string memberId)
        {
            if (memberId == null)
            {
                throw new ArgumentNullException("member Id: string, expected!");
            }

            System.Console.WriteLine("Request received for Member ID= {0}", memberId);
            EnrollmentType enrollment = getTestData();

            return enrollment;
        }

        private EnrollmentType getTestData()
        {
            System.Console.WriteLine("In method getTestData()...");

            EnrollmentType enrollment = new EnrollmentType();
            enrollment.MasterPolicyNumber = "170175";
            enrollment.PlanSponsorName = "Microsoft Corp.";
            enrollment.PlanSponsorId = "953630868";
            enrollment.InsurerName = "BCBS Microsoft";
            enrollment.InsurerId = "953761231";
            enrollment.InsuredBenefit = "Y";
            enrollment.InsRelnCode = "";
            enrollment.BenefitStatus = "Active";
            enrollment.SubscriberNumber = "055090001";
            enrollment.EntityIdentifierCode = "Insured";
            enrollment.EntityTypeQualifier = "Person";
            enrollment.LastOrgName = "Doe";
            enrollment.FirstName = "John";
            enrollment.IdentifierCode = "055090001";
            enrollment.GenderCode = "Male";
            enrollment.PhoneNumber = "7146790999";
            enrollment.Address = "1575 Riverside Parkway";
            enrollment.Street = "1575 Riverside Parkway";
            enrollment.City = "Redmond";
            enrollment.State = "Washington";
            enrollment.Zip = "981011";
            enrollment.HealthCoverage = "HD*030";

            return (enrollment);
        }
    }
}
