
---

# Activity 1: Employee Monthly Salary Processing System

## Scenario

Each employee receives a basic monthly salary, dependent allowances, and is subject to government-mandated deductions.

## Rules & Calculations

### 1. Dependent Allowance

* **Rate:** 1,000 PHP per dependent.
* **Limit:** Maximum of 5 dependents.
* *Example:* 3 dependents = 3,000 PHP allowance.

### 2. Government Deductions

All deductions are calculated based on the **basic salary**:

**SSS**
**PhilHealth**
**Pag-ibig**

---

## Requirements

### 1. Employee Processing

* Prompt the user to enter the total number of employees.
* Use a loop to process each employee record based on that count.

### 2. Input Requirements

Capture the following data for every employee:

* Employee Name
* Employee ID
* Basic Monthly Salary
* Number of Dependents

### 3. Input Validation (with Re-entry)

Use loops to ensure data integrity:

* **Basic Salary:** Must be greater than 0.
* **Dependents:** Must be between 0 and 5.
* *Requirement:* If input is invalid, display an error message and prompt the user to try again.

### 4. Salary Computation

Calculate the following for each employee:

* **Dependent Allowance:** `Number of Dependents * 1,000`
* **Gross Salary:** `Basic Salary + Dependent Allowance`
* **Total Deductions:** `SSS + PhilHealth + Pag-ibig`
* **Net Salary:** `Gross Salary - Total Deductions`

### 5. Final Output

* Display a formatted payslip for each employee.
* Calculate and display the **Grand Total Net Salary** of all processed employees.

---
