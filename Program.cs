using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=============================================");
        Console.WriteLine("==Employee Monthly Salary Processing System==");
        Console.WriteLine("=============================================");

        const double dependentsAllowance = 1000.00;
        const double sssDeduction = .05;
        const double philhealthDeduction = .03;
        const double pagibigDeduction = .04;
        double grandNetSalary = 0;
        
        Console.Write("Enter Employee Count:");
        int employeeCount;
        
        while(!int.TryParse(Console.ReadLine(), out employeeCount)){
        Console.Write("Enter Employee Count:");
        }

        for(int i = 1;i <= employeeCount; i++){


            /* ============================================= */
            Console.Write("Enter full name:");
            string empName = Console.ReadLine();
            
            while(string.IsNullOrWhiteSpace(empName) || int.TryParse(empName ,out _)){
                Console.Write("Invalid! full name:");
                empName = Console.ReadLine();
            }
            /* ============================================= */
            

            /* ============================================= */
            Console.Write("Enter emp ID:");
            // other way to convert int
            int empID = int.Parse(Console.ReadLine());
            /* ============================================= */


            /* ============================================= */
            Console.Write("Enter emp Salary:");
            double basicSalary;
            while(!double.TryParse(Console.ReadLine(), out basicSalary) || basicSalary <= 0){
            Console.Write("emp Salary Invalid!:");
            }
            /* ============================================= */


            /* ============================================= */
            const int maxDependents = 5;
            int empDependents;
            while(true){ // working na
                Console.Write("Number of Dependents:");
                empDependents = Convert.ToInt32(Console.ReadLine());

                if(empDependents <= maxDependents && empDependents > -1){
                    break;
                }
                else{
                    Console.WriteLine($"!Max of {maxDependents} only.");
                }
            }
            /* ============================================= */


            // all output
            Console.WriteLine("==================Summary====================");
            Console.WriteLine($"Employee name: {empName}:");
            Console.WriteLine($"Employee id: {empID}:");
            Console.WriteLine($"Employee salary: {basicSalary}:");
            Console.WriteLine($"Employee dependents: {empDependents}:");
            // Console.WriteLine("=============================================");

            double allowanceTotal = dependentsAllowance * empDependents;
            double grossSalary = basicSalary + allowanceTotal;
            double sss = basicSalary * sssDeduction;
            double philhealth = basicSalary * philhealthDeduction;
            double pagibig = basicSalary * pagibigDeduction;
            double totalDeduction = sss + philhealth + pagibig;
            double netSalary = grossSalary - totalDeduction;
            grandNetSalary += netSalary;

            // Console.WriteLine("=============================================");
            Console.WriteLine($"total allowance: {allowanceTotal}:");
            Console.WriteLine($"gross salary: {grossSalary}:");
            Console.WriteLine($"sss deduction: {sss}:");
            Console.WriteLine($"philhealth deduction: {philhealth}:");
            Console.WriteLine($"pagibig deduction: {pagibig}:");
            Console.WriteLine($"deduction total: {totalDeduction}:");
            Console.WriteLine($"net salary: {netSalary}:");
            Console.WriteLine("=============================================");        
        }
        Console.WriteLine($"Total Net Salary of All Employee: {grandNetSalary}");
    }
}

// kill task command:
// taskkill /PID 5544 /F