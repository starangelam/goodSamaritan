using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Client
    {
        public int ClientId { get; set; }

        // From Lookup Tables
        public Year FiscalYear { get; set; }
        public int YearId { get; set; }

        [Range(1,12)]
        public int Month { get; set; }
        [Range(1,31)]
        public int Day { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string PoliceFileNumber { get; set; }
        public int CourtFileNumber { get; set; }
        public int SWCFileNumber { get; set; }

        // From Lookup Tables
        public RiskLevel RiskLevel { get; set; }
        public int RiskLevelId { get; set; }
        
        // From Lookup Tables
        public Crisis Crisis { get; set; }
        public int CrisisId { get; set; }

        // From Lookup Tables
        public Service Service { get; set; }
        public int ServiceId { get; set; }

        // From Lookup Tables
        public Program Program { get; set; }
        public int ProgramId { get; set; }

        public string AssessmentAssgndTo { get; set; }

        // From Lookup Tables
        public RiskStatus RiskStatus { get; set; }
        public int RiskStatusId { get; set; }

        // From Lookup Tables
        public AssignedWorker AssignedWorkder { get; set; }
        public int AssignedWorkerId { get; set; }

        // From Lookup Tables
        public ReferralSource ReferralSource { get; set; }
        public int ReferralSourceId { get; set; }

        // From Lookup Tables
        public ReferralContact ReferralContact { get; set; }
        public int ReferralContactId { get; set; }

        // From Lookup Tables
        public Incident Incident { get; set; }
        public int IncidentId { get; set; }

        public string AbuserSFName { get; set; }

        // From Lookup Tables
        public AbuserRelationship AbuserRelationship { get; set; }
        public int AbuserRelationshipId { get; set; }

        // From Lookup Tables
        public VictimOfIncident VictimOfIncident{ get; set; }
        public int VictimOfIncidentId { get; set; }

        // From Lookup Tables
        public FamilyViolenceFile FamilyViolenceFile { get; set; }
        public int FamilyViolenceFileId { get; set; }

        public char Gender { get; set; }

        // From Lookup Tables
        public Ethnicity Ethnicity { get; set; }
        public int EthnicityId { get; set; }

        public Age Age { get; set; }
        public int AgeId { get; set; }

        public RepeatClient RepeatClient { get; set; }
        public int RepeatClientId { get; set; }

        public DuplicateFile DuplicateFile { get; set; }
        public int DuplicateFileId { get; set; }

        public int NumChildrenZeroToSix { get; set; }

        public int NumChildrenSevenToTwelve { get; set; }

        // From Lookup Tables
        public StatusOfFile StatusOfFile { get; set; }
        public int StatusOfFileId { get; set; }

        public DateTime DateLastTransferred { get; set; }
        public DateTime DateClosed { get; set; }
        public DateTime DateReOpened { get; set; }
    }
}