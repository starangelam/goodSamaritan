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
        public int SmartId { get; set; }

        // FK to Client
        [Required]
        public Client Client { get; set; }
        public int ClientId { get; set; }

        [Required]
        public SexExploitation SexExploitation { get; set; }
        public int SexExploitationId { get; set; }

        [Required]
        public MultiplePerps MultiplePerps { get; set; }
        public int MultiplePerpsId { get; set; }

        [Required]
        public DrugFacilitated DrugFacilitated { get; set; }
        public int DrugFacilitatedId { get; set; }

        [Required]
        public CityOfAssault CityOfAssault { get; set; }
        public int CityOfAssaultId { get; set; }

        [Required]
        public CityOfResidence CityOfResidence { get; set; }
        public int CityOfResidenceId { get; set; }

        [Required]
        public int AccompanimentMinutes { get; set; }

        [Required]
        public ReferringHospital ReferringHospital { get; set; }
        public int ReferringHospitalId { get; set; }

        [Required]
        public HospitalAttended HospitalAttended { get; set; }
        public int HospitalAttendedId { get; set; }

        [Required]
        public SocialWorkAttendance SocialWorkAttendance { get; set; }
        public int SocailWorkAttendanceId { get; set; }

        [Required]
        public PoliceAttendance PoliceAttendance { get; set; }
        public int PoliceAttendanceId { get; set; }

        [Required]
        public VictimServicesAttendance VictimServicesAttendance { get; set; }
        public int VictimServiceAttendanceId { get; set; }

        [Required]
        public MedicalOnly MedicalOnly { get; set; }
        public int MedicalOnlyId { get; set; }

        [Required]
        public EvidenceStored EvidenceStored { get; set; }
        public int EvidenceStoredId { get; set; }

        [Required]
        public HivMeds HivMeds { get; set; }
        public int HivMedsId { get; set; }

        [Required]
        public ReferredToCbvs ReferredToCbvs { get; set; }
        public int ReferredToCbvsId { get; set; }

        [Required]
        public PoliceReported PoliceReported { get; set; }
        public int PoliceReportedId { get; set; }

        [Required]
        public ThirdPartyReport ThirdPartyReport { get; set; }
        public int ThirdPartyReportId { get; set; }

        [Required]
        public BadDateReport BadDateReport { get; set; }
        public int BadDateReportId { get; set; }

        [Required]
        public int NumberTransportsProvided { get; set; }

        [Required]
        public Boolean ReferredToNursePracticioner { get; set; }
    }
}