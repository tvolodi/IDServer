using IDCommon;
using IDServer.DbLayer;
using IDServer.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDServer
{
    public class InnoDeliveryHub : Hub
    {
        private IDDbContext dbContext;


        public InnoDeliveryHub(IDDbContext context)
        {
            dbContext = context;
        }


        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("someMessage", "anonymous", message);
        }

        public async Task SaveSupplierAsync(SupplierDTO supplierDTO)
        {
            Supplier supplier = Mappers.SupplierMapper.DTOToSupplier(supplierDTO);

            await dbContext.AddAsync(supplier);
            await dbContext.SaveChangesAsync();
        }


        public async Task<string> SendTestMessage(string messageText)
        {
            return $"Test message was {messageText}";
        }
    }
}
