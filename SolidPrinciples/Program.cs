using SolidPrinciples.DiIoC;
using System;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here we are controlling which DAL we should use
            // The Employee class uses dependence inversion (DI) 
            // to delegate the control (IOC) to this or another class that need to use it.

            Employee objOracle = new Employee(new OracleDAL());
            objOracle.Add();

            Employee objSQL = new Employee(new SqlDAL());
            objSQL.Add();

        }
    }
}
