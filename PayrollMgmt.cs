using System;


namespace SalaryCalculator{

    class Program{

        static void Main(string[] args){
        
            while (true){
                Console.Clear();
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
                
                while(!int.TryParse(Console.ReadLine(), out employeeCount) || employeeCount <= 0){
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
                    int empID;
                    while(!int.TryParse(Console.ReadLine(), out empID)){
                        Console.Write("Enter Valid emp ID:");
                    }
                    /* ============================================= */


                    /* ============================================= */
                    Console.Write("Enter emp Salary:");
                    double basicSalary;
                    while(!double.TryParse(Console.ReadLine(), out basicSalary) || basicSalary <= 0){
                        Console.WriteLine("Salary Must be higher than ₱0");
                        Console.Write("Enter again:");
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
                    Console.WriteLine($"Employee name: {empName}");
                    Console.WriteLine($"Employee id: {empID}");
                    Console.WriteLine($"Employee salary: ₱{basicSalary}");
                    Console.WriteLine($"Employee dependents: {empDependents}");
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
                    Console.WriteLine($"total allowance: ₱{allowanceTotal}");
                    Console.WriteLine($"gross salary: ₱{grossSalary}");
                    Console.WriteLine($"5% sss deduction: ₱{sss}");
                    Console.WriteLine($"3% philhealth deduction: ₱{philhealth}");
                    Console.WriteLine($"4% pagibig deduction: ₱{pagibig}");
                    Console.WriteLine($"deduction total: ₱{totalDeduction}");
                    Console.WriteLine($"net salary: ₱{netSalary}");
                    Console.WriteLine("=============================================");        
                }
                Console.WriteLine($"Total Net Salary of All Employee: ₱{grandNetSalary}");
                Console.WriteLine("============================================="); 

                Console.Write($"Enter [1] to exit: ");
                if (Console.ReadLine() == "1")break;
                // string ex = Console.ReadLine();

                // if(ex == "1"){
                //     break;
                // }

            }
        }
    }
}

// kill task command:
// taskkill /PID 5544 /F
