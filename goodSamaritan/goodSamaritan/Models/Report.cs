using goodSamaritan.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class Report
    {
        private ClientContext ctx = new ClientContext();
        private List<Client> assignedClients;
        private List<Client> assignedClientsWithStatus;

        public Report(int workerId, int statusId)
        {
            assignedClients = (from c in ctx.Clients
                               where c.AssignedWorkder.AssignedWorkerId == workerId
                               select c).ToList();

            assignedClientsWithStatus = assignedClients
                    .Where(s => s.StatusOfFileId == statusId)
                    .ToList();
        }

        public int TotalCases
        {
            get
            {
                return assignedClients.Count;
            }
        }

        public int TotalOpenCases
        {
            get
            {
                int openStatusId = ctx.StatusesOfFiles
                    .Where(s => s.Status == "Open")
                    .FirstOrDefault().StatusOfFileId;
                List<Client> client = assignedClients
                    .Where(s => s.StatusOfFileId == openStatusId)
                    .ToList();
                return client.Count;
            }
        }
        public int TotalClosedCases
        {
            get
            {
                int closedStatusId = ctx.StatusesOfFiles
                    .Where(s => s.Status == "Closed")
                    .FirstOrDefault().StatusOfFileId;
                return assignedClients
                    .Where(s => s.StatusOfFileId == closedStatusId)
                    .ToList().Count;
            }
        }
        public int TotalReopenedCases
        {
            get
            {
                return assignedClients
                    .Where(s => s.StatusOfFile != null && s.StatusOfFile.Status == "Reopened")
                    .ToList().Count;
            }
        }
        public int TotalNoStatusCases { get { return 0; } }

        public int TotalSelectedCases
        {
            get
            {
                return assignedClientsWithStatus.Count;
            }
        }

        public List<Client> SelectedCases
        {
            get
            {
                return assignedClientsWithStatus;
            }
        }
    }
}