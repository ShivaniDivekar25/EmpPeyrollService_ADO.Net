using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollService_ADO.Net
{
    public class EmpPayrollModel
    {
        public string EmployeeName { get; set; }
        public int BasicPay { get; set; }
        public string Startdate { get; set; }
        public char Gender { get; set; }
        public string AddressOfEmp { get; set; }
        public long PhoneNumber { get; set; }
        public string Department { get; set; }
        public int Deduction { get; set; }
        public int TaxablePay { get; set; }
        public int IncomeTax { get; set; }
        public int NetPay { get; set; }
    }
}
