
---

# Employee Monthly Salary Processing System

## Scenario

Each employee receives a basic monthly salary, dependent allowances is maximum of 1000

## Rules & Calculations

### Dependent Allowance

* **Rate:** 1,000 PHP per dependent.
* **Limit:** Maximum of 5 dependents.
* *Example:* 3 dependents = 3,000 PHP allowance.

### Government Deductions

All deductions are calculated based on the **basic salary**:

* **SSS** 5%
* **PhilHealth** 3%
* **Pag-ibig** 4%

---

## Requirements

### Input Requirements

Capture the following data for every employee:

* Employee Name
* Employee ID
* Basic Monthly Salary
* Number of Dependents

### Input Validation

Use loops to ensure data integrity:

* **Basic Salary:** Must be greater than 0.
* **Dependents:** Must be between 0 and 5.
* *Requirement:* If input is invalid, display an error message and prompt the user to try again.

### Salary Computation

Calculation guide

* **Dependent Allowance:** `Number of Dependents * 1,000`
* **Gross Salary:** `Basic Salary + Dependent Allowance`
* **Total Deductions:** `SSS + PhilHealth + Pag-ibig`
* **Net Salary:** `Gross Salary - Total Deductions`

### Final Output

* Calculate and display the **Grand Total Net Salary** of all processed employees.

---
