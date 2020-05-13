using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleRazor.Pages
{
    public class EmpinfoModel: PageModel 
    {
        EmployeesDirectory empInfo = new EmployeesDirectory();

        public EmployeesDirectory EmpPage { get; set; } 

        public ActionResult OnGet(int id)
        {
            EmpPage = empInfo.EmployeesInformation().Find(x => x.EmpId==id);

            return Page();
        }


    }
}
