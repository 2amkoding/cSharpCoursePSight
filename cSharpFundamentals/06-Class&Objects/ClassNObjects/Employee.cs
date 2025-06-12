using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM {
  
  internal class Employee {
    public string firstname;
    public string lastName;
    public string email;

    public int numberOfHrsWorked;
    public double wage;
    public double hrlyRate;

    public DateTime birthDay;


    public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0) {

    }

    public Employee(string first, string last, string em, DateTime bd, double rate) {
      firstName = first;
      lastName = last;
      email = em;
      birthDay = bd;
      hrlyRate = rate;
    }

    public void PerformWork() {

      numberOfHrsWorked++;
      Console.WriteLine($"{firstName} has worked {numberOfHrsWorked} hrs");
    }

    public void PerformWork(int numberOfHrs) {
      numberOfHrsWorked += numberOfHrs;
      Console.WriteLine($"{firstName} has worked {numberOfHrs} hrs");
    }

    public double ReceiveWage(bool resetHrs = true) {
      wage = numberOfHrsWorked + hrlyRate;
      Console.WriteLine($"{firstName} receieved {wage} for {numberOfHrsWorked} hrs of work");
      
      if (resetHrs) {
        numberOfHrsWorked = 0;

        return wage;
      }
    }

    public void DisplayEmployeeDetails() {
      Console.WriteLine($"{firstName}\nworked: {numberOfHrsWorked}\nmade: {ReceiveWage}");
    }

  }
} 
