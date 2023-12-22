using DesignPattern_ChainOfResponsibility_1.DAL.Context;
using DesignPattern_ChainOfResponsibility_1.DAL.Entities;
using DesignPattern_ChainOfResponsibility_1.Models;

namespace DesignPattern_ChainOfResponsibility_1.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerPorccessViewModel req)
        {
            ChainOfRespContext context = new ChainOfRespContext();
            if (req.Amount <= 280000)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount;
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Şube Müdürü - İpek Çelik";
                customerProccess.Description = "Müşterinin talep ettiği tutar tarafımca onaylanmıştır.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProccess customerProccess = new CustomerProccess();
                customerProccess.Amount = req.Amount;
                customerProccess.Name = req.Name;
                customerProccess.EmployeeName = "Şube Müdürü - İpek Çelik";
                customerProccess.Description = "Müşterinin talep ettiği tutar tarfımca ödenemediği için işlem Bölge Müdürüne aktarılmıştır.";
                context.CustomerProccesses.Add(customerProccess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
