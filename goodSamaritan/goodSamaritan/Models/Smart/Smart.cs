using goodSamaritan.Models.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class Smart
    {
        [Required]
        public int SmartId { get; set; }

        // FK to Client
        [Required]
        [Display(Name="Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Display(Name = "Sex Exploitation")]
        public int SexExploitationId { get; set; }
        public SexExploitation SexExploitation { get; set; }

        [Display(Name = "Multiple Perpetrators")]
        public int MultiplePerpsId { get; set; }
        public MultiplePerps MultiplePerps { get; set; }

        [Display(Name = "Drug Facilidated")]
        public int DrugFacilitatedId { get; set; }
        public DrugFacilitated DrugFacilitated { get; set; }

        [Required]
        [Display(Name = "City of Assault")]
        public int CityOfAssaultId { get; set; }
        public CityOfAssault CityOfAssault { get; set; }

        [Required]
        [Display(Name = "City of Residence")]
        public int CityOfResidenceId { get; set; }
        public CityOfResidence CityOfResidence { get; set; }

        [Required]
        [Range(0,50)]
        [Display(Name = "Accompaniment Minutes")]
        public int AccompanimentMinutes { get; set; }

        [Required]
        [Display(Name = "Referring Hospital")]
        public int ReferringHospitalId { get; set; }
        public ReferringHospital ReferringHospital { get; set; }

        [Required]
        [Display(Name = "HospitalAttended")]
        public int HospitalAttendedId { get; set; }
        public HospitalAttended HospitalAttended { get; set; }

        [Display(Name = "Social Work Attendance")]
        public int SocialWorkAttendanceId { get; set; }
        public SocialWorkAttendance SocialWorkAttendance { get; set; }

        [Display(Name = "Police Attendance")]
        public int PoliceAttendanceId { get; set; }
        public PoliceAttendance PoliceAttendance { get; set; }

        [Display(Name = "Victim Service Attendance")]
        public int VictimServicesAttendanceId { get; set; }
        public VictimServicesAttendance VictimServicesAttendance { get; set; }

        [Display(Name = "Medical Only")]
        public int MedicalOnlyId { get; set; }
        public MedicalOnly MedicalOnly { get; set; }

        [Display(Name = "Evidence Stored")]
        public int EvidenceStoredId { get; set; }
        public EvidenceStored EvidenceStored { get; set; }

        [Display(Name = "HIV Meds")]
        public int HivMedsId { get; set; }
        public HivMeds HivMeds { get; set; }

        [Display(Name = "Referred To CBVS")]
        public int ReferredToCbvsId { get; set; }
        public ReferredToCbvs ReferredToCbvs { get; set; }

        [Display(Name = "Police Reported")]
        public int PoliceReportedId { get; set; }
        public PoliceReported PoliceReported { get; set; }

        [Display(Name = "Third Party Report")]
        public int ThirdPartyReportId { get; set; }
        public ThirdPartyReport ThirdPartyReport { get; set; }

        [Display(Name = "Bad Date Report")]
        public int BadDateReportId { get; set; }
        public BadDateReport BadDateReport { get; set; }

        [Required]
        [Range(0,50)]
        [Display(Name = "Number Transports Provided")]
        public int NumberTransportsProvided { get; set; }

        [Required]
        [Display(Name = "Referred to Nurse Practioner")]
        public Boolean ReferredToNursePracticioner { get; set; }
    } 
}