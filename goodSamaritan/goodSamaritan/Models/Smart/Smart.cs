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
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int SexExploitationId { get; set; }
        public SexExploitation SexExploitation { get; set; }

        public int MultiplePerpsId { get; set; }
        public MultiplePerps MultiplePerps { get; set; }

        public int DrugFacilitatedId { get; set; }
        public DrugFacilitated DrugFacilitated { get; set; }

        [Required]
        public int CityOfAssaultId { get; set; }
        public CityOfAssault CityOfAssault { get; set; }

        [Required]
        public int CityOfResidenceId { get; set; }
        public CityOfResidence CityOfResidence { get; set; }

        [Required]
        public int AccompanimentMinutes { get; set; }

        [Required]
        public int ReferringHospitalId { get; set; }
        public ReferringHospital ReferringHospital { get; set; }

        [Required]
        public int HospitalAttendedId { get; set; }
        public HospitalAttended HospitalAttended { get; set; }

        public int SocialWorkAttendanceId { get; set; }
        public SocialWorkAttendance SocialWorkAttendance { get; set; }

        public int PoliceAttendanceId { get; set; }
        public PoliceAttendance PoliceAttendance { get; set; }

        public int VictimServiceAttendanceId { get; set; }
        public VictimServicesAttendance VictimServicesAttendance { get; set; }

        public int MedicalOnlyId { get; set; }
        public MedicalOnly MedicalOnly { get; set; }

        public int EvidenceStoredId { get; set; }
        public EvidenceStored EvidenceStored { get; set; }

        public int HivMedsId { get; set; }
        public HivMeds HivMeds { get; set; }

        public int ReferredToCbvsId { get; set; }
        public ReferredToCbvs ReferredToCbvs { get; set; }

        public int PoliceReportedId { get; set; }
        public PoliceReported PoliceReported { get; set; }

        public int ThirdPartyReportId { get; set; }
        public ThirdPartyReport ThirdPartyReport { get; set; }

        public int BadDateReportId { get; set; }
        public BadDateReport BadDateReport { get; set; }

        [Required]
        public int NumberTransportsProvided { get; set; }

        [Required]
        public Boolean ReferredToNursePracticioner { get; set; }
    } 
}