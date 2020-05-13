using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleRazor.Pages
{
    public class LoginPageModel : PageModel
    {
        public ActionResult OnPostInquiry(string RazorUserName, string RazorPassword)
        {
          string User = "UserViewer";
           string Password = "123456";

            if(User==RazorUserName && Password ==RazorPassword)
            {
                return RedirectToPage("/EmpList");
            }
            else
            {
                ViewData["Error"] = " Please review your credentials or click forgot password, " +
                    " If you need further assistant click in Contact link";
            }
            return Page();
        }
    }
}