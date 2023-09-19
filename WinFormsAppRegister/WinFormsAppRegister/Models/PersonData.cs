using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppRegister.Enums;

namespace WinFormsAppRegister.Models
{
    public class PersonData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string NationalCode { get; set; }
        public DateTime CreationDate { get; set; }
        [Browsable(false)]
        public Gender Gendar { get; set; }
        public string GendarTitle { get { return Gendar.GetDescription(); } }
    }
}
