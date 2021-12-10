using System;
using System.ComponentModel.DataAnnotations;

namespace Weekly_Salary_Calculator.Models
/***************************************************************
* Name        : Weekly_Salary_Calculator
* Author      : Kade Campbell
* Created     : 012/10/2021
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : MacOS Big Surf
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Problem     : The problem is the need to calculate the student's weekly salary.
* Description : This program calculates the weekly salary for a student worker. 
* The employee can only work 1-15 hours and can be payed starting at 7.25 and the highest is 14.75.
*  Student name,  Student ID number, Hours worked, and Hourly wage. 
*  Output: Student's weekly income. 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

{
    public class StudentWorkerModel
    {
        private string _name;
        private string _studentId;
        private double _hrlyPay;
        private double _hrsWorked;
        private double _weeklyPay;

        public StudentWorkerModel()
        {
        }

        public string Name { get { return _name; } set { _name = value; } }
        [Required(ErrorMessage = "Please enter your hourly wage.")] //This error message isn't working correctly. 
        [Range(7.25, 14.75, ErrorMessage = "Hourly pay must be inbetween $7.25 - $14.75")]
        public double HourlyPay
        { get { return _hrlyPay; } set { _hrlyPay = value; } }
        public string StudentId { get { return _studentId; } set { _studentId = value; } }
        [Required(ErrorMessage = "Please enter how many hours you have worked.")] //Also not working right. 
        [Range(1.0, 15.0, ErrorMessage = "You can only work up to 15 hours max.")]
        public double HrsWorked
        { get { return _hrsWorked; } set { _hrsWorked = value; } }

        public double WeeklyPay { get { return _weeklyPay; } set { _weeklyPay = value; } }



        public void WeeklySalary()
        {
            // Calculates the weekly salary. 

            WeeklyPay = HrsWorked * HourlyPay;

        }
        public bool ValidInput(double hoursWorked, double hourlyPay)
        {
            if (HrsWorked < 1 || HrsWorked > 15) // Method to use in the valid test. 
            {
                if (HourlyPay < 7.25 || HourlyPay > 14.75)
                {
                    return false;
                }
            }
            return true;
        }

    }

}
