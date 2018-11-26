using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLayer.ViewModel
{
    public class Login
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter User Name")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Password")]
        public string PassWord { get; set; }
    }
}

