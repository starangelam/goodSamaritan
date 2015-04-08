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
        [Display(Name="Fiscal Year")]
        public virtual Year FiscalYear { get; set; }
        public int YearId { get; set; }

        [Required]
        [Range(1,12)]
        public int Month { get; set; }

        [Required]
        [Range(1,31)]
        public int Day { get; set; }

        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [MaxLength(8)]
        [RegularExpression(@"\d{2}-\d{5}", ErrorMessage = "Police File Number must be in 99-99999 format. e.g. 12-12345")]
        [Display(Name="Police File Number")]
        public string PoliceFileNumber { get; set; }

        [Range(0, 2147483647)]
        public int? CourtFileNumber { get; set; }

        [Required]
        [Range(0, 2147483647)]
        public int SWCFileNumber { get; set; }

        public virtual RiskLevel RiskLevel { get; set; }
        public int RiskLevelId { get; set; }
        
        [Required]
        public virtual Crisis Crisis { get; set; }
        public int CrisisId { get; set; }

        // TODO Add "Default values: 
        //      'File' if SWC selected
        //      'N/A' if SWC is blanks
        [Required]
        public virtual Service Service { get; set; }
        public int ServiceId { get; set; }

        [Required]
        public virtual Program Program { get; set; }
        public int ProgramId { get; set; }

        [Required]
        [StringLength(64, MinimumLength=2)]
        public string AssessmentAssgndTo { get; set; }

        public virtual RiskStatus RiskStatus { get; set; }
        public int RiskStatusId { get; set; }

        public virtual AssignedWorker AssignedWorkder { get; set; }
        public int AssignedWorkerId { get; set; }

        [Required]
        public virtual ReferralSource ReferralSource { get; set; }
        public int ReferralSourceId { get; set; }

        [Required]
        public virtual ReferralContact ReferralContact { get; set; }
        public int ReferralContactId { get; set; }

        [Required]
        public virtual Incident Incident { get; set; }
        public int IncidentId { get; set; }

        [Required]
        [MaxLength(64), MinLength(4)]
        [RegularExpression(@"[a-zA-Z]{2,}, [a-zA-z]{2,}[a-zA-Z ]*", ErrorMessage="Name must be in surname, first name format. e.g. Smith, Bob")]
        public string AbuserSFName { get; set; }

        [Required]
        public virtual AbuserRelationship AbuserRelationship { get; set; }
        public int AbuserRelationshipId { get; set; }

        [Required]
        public virtual VictimOfIncident VictimOfIncident { get; set; }
        public int VictimOfIncidentId { get; set; }

        public virtual FamilyViolenceFile FamilyViolenceFile { get; set; }
        public int FamilyViolenceFileId { get; set; }

        [Required]
        [MaxLength(1)]
        [RegularExpression(@"[MFT]{1}", ErrorMessage = "Please enter either 'M' for Male, 'F' for Female, or 'T' for Transgender")]
        public string Gender { get; set; }

        [Required]
        public virtual Ethnicity Ethnicity { get; set; }
        public int EthnicityId { get; set; }
        
        [Required]
        public virtual Age Age { get; set; }
        public int AgeId { get; set; }

        public virtual RepeatClient RepeatClient { get; set; }
        public int RepeatClientId { get; set; }

        public virtual DuplicateFile DuplicateFile { get; set; }
        public int DuplicateFileId { get; set; }

        [Required]
        [Range(0,30)]
        public int NumChildrenZeroToSix { get; set; }

        [Required]
        [Range(0, 30)]
        public int NumChildrenSevenToTwelve { get; set; }

        [Required]
        public virtual StatusOfFile StatusOfFile { get; set; }
        public int StatusOfFileId { get; set; }

        public DateTime? DateLastTransferred { get; set; }

        public DateTime? DateClosed { get; set; }
        
        public DateTime? DateReOpened { get; set; }
    }
}