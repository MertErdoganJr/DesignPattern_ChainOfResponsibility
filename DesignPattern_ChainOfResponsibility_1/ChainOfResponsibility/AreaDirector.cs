using DesignPattern_ChainOfResponsibility_1.DAL.Context;
using DesignPattern_ChainOfResponsibility_1.DAL.Entities;
using DesignPattern_ChainOfResponsibility_1.Models;

namespace DesignPattern_ChainOfResponsibility_1.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerPorccessViewModel req)
        {
            ChainOfRespContext context = new ChainOfRespContext();
            if (req.Amount <= 400000)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount;
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Bölge Müdürü - Özlem Karakoç";
                customerProccess.Description = "Müşterinin talep ettiği tutar tarafımca onaylanmıştır.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
            else
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount;
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Bölge Müdürü - Özlem Karakoç";
                customerProccess.Description = "Müşterinin talep ettiği tutar bankanın günlük ödeme limitlerini aştığı için işlem gerçekleştirilemedi";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
        }
    }
}
