﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _364700TwitterClone.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AngularEntities : DbContext
    {
        public AngularEntities()
            : base("name=AngularEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PERSON> People { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<TWEET> TWEETs { get; set; }
        public virtual DbSet<Works_on> Works_on { get; set; }
        public virtual DbSet<VW_DEPARTMENT_d1> VW_DEPARTMENT_d1 { get; set; }
        public virtual DbSet<VW_EMPLOYEE_DETAIL_CONDITION> VW_EMPLOYEE_DETAIL_CONDITION { get; set; }
        public virtual DbSet<VW_EMPLOYEE_PROJECT_DETAILS_SMITH> VW_EMPLOYEE_PROJECT_DETAILS_SMITH { get; set; }
        public virtual DbSet<VW_PROJECT_WithoutBudget> VW_PROJECT_WithoutBudget { get; set; }
        public virtual DbSet<VW_WORKS_ON_CONDITION> VW_WORKS_ON_CONDITION { get; set; }
        public virtual DbSet<VW_WORKS_ON_NOCONDITION> VW_WORKS_ON_NOCONDITION { get; set; }
    
        public virtual int AddRecordstoTable(string customerid, string customerName, string customerAddress, Nullable<System.DateTime> dOB, Nullable<decimal> salary)
        {
            var customeridParameter = customerid != null ?
                new ObjectParameter("Customerid", customerid) :
                new ObjectParameter("Customerid", typeof(string));
    
            var customerNameParameter = customerName != null ?
                new ObjectParameter("CustomerName", customerName) :
                new ObjectParameter("CustomerName", typeof(string));
    
            var customerAddressParameter = customerAddress != null ?
                new ObjectParameter("CustomerAddress", customerAddress) :
                new ObjectParameter("CustomerAddress", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddRecordstoTable", customeridParameter, customerNameParameter, customerAddressParameter, dOBParameter, salaryParameter);
        }
    
        public virtual int AddStudent(string name, Nullable<System.DateTime> dateofBirth)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var dateofBirthParameter = dateofBirth.HasValue ?
                new ObjectParameter("DateofBirth", dateofBirth) :
                new ObjectParameter("DateofBirth", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddStudent", nameParameter, dateofBirthParameter);
        }
    
        public virtual int CreateTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateTable");
        }
    
        public virtual int DeleteCustomers(string customerid)
        {
            var customeridParameter = customerid != null ?
                new ObjectParameter("Customerid", customerid) :
                new ObjectParameter("Customerid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCustomers", customeridParameter);
        }
    
        public virtual ObjectResult<GetCustomersForDOB_Result> GetCustomersForDOB(Nullable<System.DateTime> dOB)
        {
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCustomersForDOB_Result>("GetCustomersForDOB", dOBParameter);
        }
    
        public virtual ObjectResult<retriveAllRecords_Result> retriveAllRecords(string customerid)
        {
            var customeridParameter = customerid != null ?
                new ObjectParameter("Customerid", customerid) :
                new ObjectParameter("Customerid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<retriveAllRecords_Result>("retriveAllRecords", customeridParameter);
        }
    
        public virtual int uploadXmlFile(string strin)
        {
            var strinParameter = strin != null ?
                new ObjectParameter("strin", strin) :
                new ObjectParameter("strin", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uploadXmlFile", strinParameter);
        }
    }
}
