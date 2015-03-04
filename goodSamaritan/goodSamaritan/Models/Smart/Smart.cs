using goodSamaritan.Models.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class Smart
    {
        public int SmartId { get; set; }

        // FK to Client
        public Client Client { get; set; }
        public int ClientId { get; set; }

        public SexExploitation SexExploitation { get; set; }
        public int SexExploitationId { get; set; }

        public MultiplePerps MultiplePerps { get; set; }
        public int MultiplePerpsId { get; set; }

        public DrugFacilitated DrugFacilitated { get; set; }
        public int DrugFacilitatedId { get; set; }

        public CityOfAssault CityOfAssault { get; set; }
        public int CityOfAssaultId { get; set; }

        public CityOfResidence CityOfResidence { get; set; }
        public int CityOfResidenceId { get; set; }

        public int AccompanimentMinutes { get; set; }

        public ReferringHospital ReferringHospital { get; set; }
        public int ReferringHospitalId { get; set; }

        public HospitalAttended HospitalAttended { get; set; }
        public int HospitalAttendedId { get; set; }

        public SocialWorkAttendance SocialWorkAttendance { get; set; }
        public int SocailWorkAttendanceId { get; set; }

        public PoliceAttendance PoliceAttendance { get; set; }
        public int PoliceAttendanceId { get; set; }

        public VictimServicesAttendance VictimServicesAttendance { get; set; }
        public int VictimServiceAttendanceId { get; set; }

        public MedicalOnly MedicalOnly { get; set; }
        public int MedicalOnlyId { get; set; }

        public EvidenceStored EvidenceStored { get; set; }
        public int EvidenceStoredId { get; set; }

        public HivMeds HivMeds { get; set; }
        public int HivMedsId { get; set; }

        public ReferredToCbvs ReferredToCbvs { get; set; }
        public int ReferredToCbvsId { get; set; }

        public PoliceReported PoliceReported { get; set; }
        public int PoliceReportedId { get; set; }

        public ThirdPartyReport ThirdPartyReport { get; set; }
        public int ThirdPartyReportId { get; set; }

        public BadDateReport BadDateReport { get; set; }
        public int BadDateReportId { get; set; }

        public int NumberTransportsProvided { get; set; }

        public Boolean ReferredToNursePracticioner { get; set; }
    }
}