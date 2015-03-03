using goodSamaritan.Models.Client;
using System;
using System.Collections.Generic;
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
    }
}