using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace SampleRazor.Pages
{
    public class IndexModel : PageModel
    {
        EmployeesDirectory Emp_List = new EmployeesDirectory();
        //public  EmployeesDirectory emps;

        //public IndexModel(EmployeesDirectory emps)
        //{

        //    this.emps = emps;
        //}

        public IEnumerable<EmployeesDirectory> Emp_ { get; set; }
        public EmployeesDirectory Emp_info { get; set; }

        public ActionResult OnGet()
        {
            Emp_ = Emp_List.EmployeesInformation().ToList();

            return Page();

        }
        public ActionResult OnGetEmp(int id)
        {
            Emp_List.EmployeesInformation().Find(x => x.EmpId == id);
            return RedirectToPage("/EmpInfo");
        }

       
    }
}
