using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.DiIoC
{
    public class Employee
    {
        private IDAL _iDAL;

        // Here we are breaking the SRP
        // Lets comment the first class constructor

        //public Employee(int dbType)
        //{
        //    if (dbType == 1)
        //        _IDAL = new SqlDAL();
        //    else if (dbType == 2)
        //        _IDAL = new OracleDAL();
        //}

        //By injecting (DI) the interface we are delegating the control (IOC) to classes that will instantiate this class
        public Employee(IDAL iDAL)
        {
            _iDAL = iDAL;
        }

        // Here we don´t know what DAL to call, because it is defined in property _IDAL setted on the constructor
        public void Add()
        {
            _iDAL.Add();
        }
    }
}
