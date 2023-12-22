using DesignPattern_ChainOfResponsibility_1.DAL.Context;
using DesignPattern_ChainOfResponsibility_1.DAL.Entities;
using DesignPattern_ChainOfResponsibility_1.Models;

namespace DesignPattern_ChainOfResponsibility_1.ChainOfResponsibility
{
    public class ManagerAsistant : Employee
    {
        public override void ProcessRequest(CustomerPorccessViewModel req)
        {
            ChainOfRespContext context = new ChainOfRespContext();
            if (req.Amount <= 200000)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount;
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Şube Müdür Yardımcısı - Oğuzhan Karal";
                customerProccess.Description = "Müşterinin talep ettiği tutar tarafımca onaylanmıştır.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
            else if(NextApprover != null)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount;
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Şube Müdür Yardımcısı - Oğuzhan Karal";
                customerProccess.Description = "Müşterinin talep ettiği tutar tarfımca ödenemediği için işlem Şube Müdürüne aktarılmıştır.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
