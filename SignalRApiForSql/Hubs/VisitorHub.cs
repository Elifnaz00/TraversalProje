using Microsoft.AspNetCore.SignalR;
using SignalRApiForSql.Model;
using System.Threading.Tasks;

namespace SignalRApiForSql.Hubs
{
    public class VisitorHub:Hub
    {
        private readonly VisitorService visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            this.visitorService = visitorService;
        }

        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("ReceiveVisitorList", visitorService.GetVisitorChartList());
        }
    }
}
