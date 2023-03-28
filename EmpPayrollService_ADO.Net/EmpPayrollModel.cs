using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollService_ADO.Net
{
    public class EmpPayrollModel
    {
        public string EmployeeName { get; set; }
        public double BasicPay { get; set; }
        public DateTime Startdate { get; set; }
        public char Gender { get; set; }
        public string AddressOfEmp { get; set; }
        public Int64 PhoneNumber { get; set; }
        public string Department { get; set; }
        public Int64 Deduction { get; set; }
        public Int64 TaxablePay { get; set; }
        public Int64 IncomeTax { get; set; }
        public Int64 NetPay { get; set; }
    }
}
