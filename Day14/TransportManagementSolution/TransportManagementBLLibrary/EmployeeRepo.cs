using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportManagementBLLibrary
{
    public class EmployeeRepo : IRepo<Employee>, ILogin<Employee>
    {
        public Dictionary<int, Employee> employees;

        public EmployeeRepo()
        {
            employees = new Dictionary<int, Employee>();
        }
        private int GenerateEmployeeId()
        {
            if (employees.Count == 0)
                return 1;
            List<int> ids = employees.Keys.ToList();
            ids.Sort();
            int id = ids[ids.Count - 1];
            id++;
            return id;
        }
        public void Add(Employee t)
        {
            try
            {
                t.Id = GenerateEmployeeId();
                employees.Add(t.Id, t);
            }
            catch (ArgumentException argumentException)
            {
                throw new UnableToAddEmployeeException();
            }
        }

        public Employee Get(int id)
        {
            Employee employee = null;
            try
            {
                employee = employees[id];
            }
            catch (Exception e)
            {
                employee = null;
            }
            return employee;
        }

        public ICollection<Employee> GetAll()
        {
            if (employees.Count == 0)
                return null;
            return employees.Values.ToList();
        }

        public bool Login(Employee t)
        {
            if(employees.ContainsKey(t.Id))
            {
                if (employees[t.Id].Password == t.Password)
                    return true;
            }
            return false;
        }

        public void Update(int id, Employee t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            employees.Remove(id);
        }
    }
}
