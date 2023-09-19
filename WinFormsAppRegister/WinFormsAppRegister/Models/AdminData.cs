using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppRegister.Models
{
    public class AdminData : PersonData
    {
        public int AccessId { get; set; }
        public string RoleName { get; set; }
    }
}