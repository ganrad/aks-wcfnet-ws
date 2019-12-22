using System;
// using System.Collections.Generic;
// using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
// using System.Text;

namespace EnrollmentsLib
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.health.samples")]
    public interface IEnrollment
    {
        [OperationContract]
        void HealthCheck();

        [OperationContract]
        EnrollmentType GetEnrollmentsById(string memberId);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "EnrollmentsLib.ContractType".
    [DataContract]
    public class EnrollmentType
    {

        [DataMember]
        public string MasterPolicyNumber
        {
            get;
            set;
        }

        [DataMember]
        public string PlanSponsorName
        {
            get;
            set;
        }

        [DataMember]
        public string PlanSponsorId
        {
            get;
            set;
        }

        [DataMember]
        public string InsurerName
        {
            get;
            set;
        }

        [DataMember]
        public string InsurerId
        {
            get;
            set;
        }

        // Insured benefits = Y or N (Y - Insured is a subscriber; N - Insured is adependent)
        [DataMember]
        public string InsuredBenefit
        {
            get;
            set;
        }

        // Insured relationship code - spouse or child
        [DataMember]
        public string InsRelnCode
        {
            get;
            set;
        }

        // 'Active' or 'In-Active'
        [DataMember]
        public string BenefitStatus
        {
            get;
            set;
        }

        [DataMember]
        public string SubscriberNumber
        {
            get;
            set;
        }

        // Entity Identifier Code - Insured or Subscriber
        [DataMember]
        public string EntityIdentifierCode
        {
            get;
            set;
        }

        // Entity type qualifier - Company or Person
        [DataMember]
        public string EntityTypeQualifier
        {
            get;
            set;
        }

        // Last name or Org. name
        [DataMember]
        public string LastOrgName
        {
            get;
            set;
        }

        // First name
        [DataMember]
        public string FirstName
        {
            get;
            set;
        }

        // ID Code - SSN
        [DataMember]
        public string IdentifierCode
        {
            get;
            set;
        }

        [DataMember]
        public string GenderCode
        {
            get;
            set;
        }

        [DataMember]
        public string PhoneNumber
        {
            get;
            set;
        }

        [DataMember]
        public string Address
        {
            get;
            set;
        }

        [DataMember]
        public string Street
        {
            get;
            set;
        }

        [DataMember]
        public string City
        {
            get;
            set;
        }

        [DataMember]
        public string State
        {
            get;
            set;
        }

        [DataMember]
        public string Zip
        {
            get;
            set;
        }

        // Health coverage code - HD*030, Audit or Compare
        [DataMember]
        public string HealthCoverage
        {
            get;
            set;
        }
    }
}
