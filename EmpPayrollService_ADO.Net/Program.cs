namespace EmpPayrollService_ADO.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee payroll service using ADO.Net");
            EmployeePayroll employeePayroll = new EmployeePayroll();
            EmpPayrollModel empPayrollModel = new EmpPayrollModel()
            {
                EmployeeName = "Geet",
                BasicPay = 1000000,
                Startdate = ("27-03-2020"),
                Gender = 'F',
                AddressOfEmp = "Satara",
                PhoneNumber = 7584263023,
                Department = "Accountant",
                Deduction = 0,
                TaxablePay = 0,
                IncomeTax = 0,
                NetPay = 0
            };
           
            Console.WriteLine("Enter an option");
            Console.WriteLine("1:Create new employee data");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    employeePayroll.AddNewDataIntoDataBase(empPayrollModel);
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            } 
        }
    }
}