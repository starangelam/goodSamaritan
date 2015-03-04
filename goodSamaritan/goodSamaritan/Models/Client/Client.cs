using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Client
    {
        [Required]
        public int ClientId { get; set; }

        [Required]
        public Year FiscalYear { get; set; }
        public int YearId { get; set; }

        [Required]
        [Range(1,12)]
        public int Month { get; set; }
        [Required]
        [Range(1,31)]
        public int Day { get; set; }

        [Required]
        public string Surname { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string PoliceFileNumber { get; set; }

        // Should NOT be required (for some reason is)
        public int CourtFileNumber { get; set; }

        [Required]
        public int SWCFileNumber { get; set; }

        // From Lookup Tables
        public RiskLevel RiskLevel { get; set; }
        public int RiskLevelId { get; set; }
        
        
        [Required]
        public Crisis Crisis { get; set; }
        public int CrisisId { get; set; }

        // Add "Default values: 
        //      'File' if SWC selected
        //      'N/A' if SWC is blanks
        [Required]
        public Service Service { get; set; }
        public int ServiceId { get; set; }

        [Required]
        public Program Program { get; set; }
        public int ProgramId { get; set; }

        [Required]
        [MaxLength(64),MinLength(2)]
        public string AssessmentAssgndTo { get; set; }

        public RiskStatus RiskStatus { get; set; }
        public int RiskStatusId { get; set; }

        public AssignedWorker AssignedWorkder { get; set; }
        public int AssignedWorkerId { get; set; }

        [Required]
        public ReferralSource ReferralSource { get; set; }
        public int ReferralSourceId { get; set; }

        [Required]
        public ReferralContact ReferralContact { get; set; }
        public int ReferralContactId { get; set; }

        [Required]
        public Incident Incident { get; set; }
        public int IncidentId { get; set; }

        // TODO:    Add Regex-validation
        //          to match format "Smith, Bob"
        [Required]
        [MaxLength(64), MinLength(4)]
        public string AbuserSFName { get; set; }

        [Required]
        public AbuserRelationship AbuserRelationship { get; set; }
        public int AbuserRelationshipId { get; set; }

        [Required]
        public VictimOfIncident VictimOfIncident{ get; set; }
        public int VictimOfIncidentId { get; set; }

        public FamilyViolenceFile FamilyViolenceFile { get; set; }
        public int FamilyViolenceFileId { get; set; }

        // TODO:    Add VALIDATION:
        //          Must be 'M', 'F', or 'T'
        [Required]
        public char Gender { get; set; }

        [Required]
        public Ethnicity Ethnicity { get; set; }
        public int EthnicityId { get; set; }
        
        [Required]
        public Age Age { get; set; }
        public int AgeId { get; set; }

        public RepeatClient RepeatClient { get; set; }
        public int RepeatClientId { get; set; }

        public DuplicateFile DuplicateFile { get; set; }
        public int DuplicateFileId { get; set; }

        // TODO:    CustomValidation; Must be >= 0
        [Required]
        public int NumChildrenZeroToSix { get; set; }

        // TODO:    CustomValidation; Must be >= 0
        [Required]
        public int NumChildrenSevenToTwelve { get; set; }

        [Required]
        public StatusOfFile StatusOfFile { get; set; }
        public int StatusOfFileId { get; set; }

        [Required]
        public DateTime DateLastTransferred { get; set; }
        [Required]
        public DateTime DateClosed { get; set; }
        
        public DateTime DateReOpened { get; set; }
    }
}