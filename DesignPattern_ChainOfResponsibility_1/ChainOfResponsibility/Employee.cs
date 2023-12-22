using DesignPattern_ChainOfResponsibility_1.Models;

namespace DesignPattern_ChainOfResponsibility_1.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee supervisor)
        {
            this.NextApprover = supervisor;
        }
        public abstract void ProcessRequest(CustomerPorccessViewModel req);
    }
}
