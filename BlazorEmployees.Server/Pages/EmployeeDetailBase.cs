using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorEmployees.Domain.Enums;
using BlazorEmployees.Domain.Model;

namespace BlazorEmployees.Server.Pages
{
    public class EmployeeDetailBase : ComponentBase
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();
        protected override Task OnInitializedAsync()
        {
            InitializeJobCategories();
            InitializeCountries();
            InitializeEmployees();

            Employee = Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));

            return base.OnInitializedAsync();
        }

        public IEnumerable<Employee> Employees { get; set; }
        private List<Country> Countries { get; set; }
        private List<JobCategory> JobCategories { get; set; }
        private void InitializeJobCategories()
        {
            JobCategories = new List<JobCategory>()
            {
                new JobCategory{JobCategoryId=1, JobCategoryName="Developer"},
                new JobCategory{JobCategoryId=2, JobCategoryName="Sales"},
                new JobCategory{JobCategoryId=3, JobCategoryName="Management"},
                new JobCategory{JobCategoryId=4, JobCategoryName="HR"},
                new JobCategory{JobCategoryId=5, JobCategoryName="Accounting"}
            };
        }
        private void InitializeCountries()
        {
            Countries = new List<Country>()
            {
                new Country{CountryId=1,Name="Greece"},
                new Country{CountryId=2,Name="USA"},
                new Country{CountryId=3,Name="UK"},
            };
        }
        private void InitializeEmployees()
        {
            var emp1 = new Employee()
            {
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1980, 2, 11),
                City = "Athens",
                Email = "zach@gmail.com",
                EmployeeId = 1,
                FirstName = "Zach",
                LastName = "Ioannou",
                Gender = Gender.Male,
                PhoneNumber = "69789767567",
                Smoker = true,
                Street = "Androutsou",
                Zip = "12323",
                JobCategoryId = 1,
                Comment = "Looking good",
                ExitDate = null,
                JoinedDate = new DateTime(2020, 4, 2)
            };

            var emp2 = new Employee()
            {
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1977, 4, 1),
                City = "Athens",
                Email = "Mixalis@gmail.com",
                EmployeeId = 2,
                FirstName = "Mixalis",
                LastName = "Antoniou",
                Gender = Gender.Male,
                PhoneNumber = "69789234324",
                Smoker = true,
                Street = "Trifonos",
                Zip = "34233",
                JobCategoryId = 1,
                Comment = "Cool guy",
                ExitDate = null,
                JoinedDate = new DateTime(2010, 1, 1)
            };

            var emp3 = new Employee()
            {
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1999, 4, 1),
                City = "Athens",
                Email = "Aris@gmail.com",
                EmployeeId = 3,
                FirstName = "Aris",
                LastName = "Artzoglou",
                Gender = Gender.Male,
                PhoneNumber = "21093123123",
                Smoker = true,
                Street = "Dekelias",
                Zip = "41424",
                JobCategoryId = 1,
                Comment = "Cool guy",
                ExitDate = null,
                JoinedDate = new DateTime(2008, 1, 1)
            };
            var emp4 = new Employee()
            {
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1999, 4, 1),
                City = "Athens",
                Email = "marios@gmail.com",
                EmployeeId = 4,
                FirstName = "Marios",
                LastName = "Martinos",
                Gender = Gender.Male,
                PhoneNumber = "21093131233",
                Smoker = true,
                Street = "Sofokleous",
                Zip = "2134",
                JobCategoryId = 1,
                Comment = "Cool guy",
                ExitDate = null,
                JoinedDate = new DateTime(2008, 1, 1)
            };
            Employees = new List<Employee> { emp1, emp2, emp3, emp4 };
        }
    }
}

