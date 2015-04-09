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
        public int YearId { get; set; }
        public virtual Year FiscalYear { get; set; }

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
        [Display(Name="Court File Number")]
        public int? CourtFileNumber { get; set; }

        [Required]
        [Range(0, 2147483647)]
        [Display(Name="SWC File Number")]
        public int SWCFileNumber { get; set; }

        [Display(Name="Risk Level")]
        public int RiskLevelId { get; set; }
        public virtual RiskLevel RiskLevel { get; set; }
        
        [Required]
        public int CrisisId { get; set; }
        public virtual Crisis Crisis { get; set; }

        // TODO Add "Default values: 
        //      'File' if SWC selected
        //      'N/A' if SWC is blanks
        [Required]
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [Required]
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }

        [Required]
        [StringLength(64, MinimumLength=2)]
        [Display(Name = "Risk Assessment Assigned To")]
        public string AssessmentAssgndTo { get; set; }

        [Display(Name="Risk Status")]
        public int RiskStatusId { get; set; }
        public virtual RiskStatus RiskStatus { get; set; }

        [Display(Name="Assigned Worker")]
        public int AssignedWorkerId { get; set; }
        public virtual AssignedWorker AssignedWorkder { get; set; }

        [Required]
        [Display(Name="Referral Source")]
        public int ReferralSourceId { get; set; }
        public virtual ReferralSource ReferralSource { get; set; }

        [Required]
        [Display(Name = "Referral Contact")]
        public int ReferralContactId { get; set; }
        public virtual ReferralContact ReferralContact { get; set; }

        [Required]
        public int IncidentId { get; set; }
        public virtual Incident Incident { get; set; }

        [Required]
        [MaxLength(64), MinLength(4)]
        [RegularExpression(@"[a-zA-Z]{2,}, [a-zA-z]{2,}[a-zA-Z ]*", ErrorMessage="Name must be in surname, first name format. e.g. Smith, Bob")]
        [Display(Name="Abuser Surname, First Name")]
        public string AbuserSFName { get; set; }

        [Required]
        [Display(Name="Abuser Relationship")]
        public int AbuserRelationshipId { get; set; }
        public virtual AbuserRelationship AbuserRelationship { get; set; }

        [Required]
        [Display(Name="Victim Of Incident")]
        public int VictimOfIncidentId { get; set; }
        public virtual VictimOfIncident VictimOfIncident { get; set; }

        [Display(Name="Family Violence File")]
        public int FamilyViolenceFileId { get; set; }
        public virtual FamilyViolenceFile FamilyViolenceFile { get; set; }

        [Required]
        [MaxLength(1)]
        [RegularExpression(@"[MFT]{1}", ErrorMessage = "Please enter either 'M' for Male, 'F' for Female, or 'T' for Transgender")]
        public string Gender { get; set; }

        [Required]
        public int EthnicityId { get; set; }
        public virtual Ethnicity Ethnicity { get; set; }
        
        [Required]
        public int AgeId { get; set; }
        public virtual Age Age { get; set; }

        [Display(Name="Repeat Client (current fiscal year only)")]
        public int RepeatClientId { get; set; }
        public virtual RepeatClient RepeatClient { get; set; }

        [Display(Name="Duplicate File (current fiscal year only)")]
        public int DuplicateFileId { get; set; }
        public virtual DuplicateFile DuplicateFile { get; set; }

        [Required]
        [Range(0,30)]
        [Display(Name="Number of Children 0-6")]
        public int NumChildrenZeroToSix { get; set; }

        [Required]
        [Range(0, 30)]
        [Display(Name = "Number of Children 7-12")]
        public int NumChildrenSevenToTwelve { get; set; }

        [Required]
        [Display(Name="Status Of File")]
        public int StatusOfFileId { get; set; }
        public virtual StatusOfFile StatusOfFile { get; set; }

        [Display(Name="Date Last Transferred")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateLastTransferred { get; set; }

        [Display(Name="Date Closed")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateClosed { get; set; }
        
        [Display(Name="Date ReOpened")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateReOpened { get; set; }
    }
}