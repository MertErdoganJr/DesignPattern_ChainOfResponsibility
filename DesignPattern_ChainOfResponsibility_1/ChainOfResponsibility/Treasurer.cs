using DesignPattern_ChainOfResponsibility_1.DAL.Context;
using DesignPattern_ChainOfResponsibility_1.DAL.Entities;
using DesignPattern_ChainOfResponsibility_1.Models;

namespace DesignPattern_ChainOfResponsibility_1.ChainOfResponsibility
{
    public class Treasurer : Employee
    {

        public override void ProcessRequest(CustomerPorccessViewModel req)
        {
            ChainOfRespContext context = new ChainOfRespContext();

            if (req.Amount <= 100000)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount;
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Vezneda - Berkan Baytar";
                customerProccess.Description = "Müşterinin talep ettiği kredi tutarı tarafımca ödenmiştir";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount;
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Vezneda - Berkan Baytar";
                customerProccess.Description = "Müşterinin talep ettiği tutar tarfımca ödenemediği için işlem Şube Müdür Yardımcısına aktarılmıştır.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }

        }
    }
}
