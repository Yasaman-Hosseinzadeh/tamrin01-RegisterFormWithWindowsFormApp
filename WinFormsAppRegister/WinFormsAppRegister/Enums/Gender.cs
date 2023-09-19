using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppRegister.Enums
{
    public enum Gender
    {
        [Description("مرد")]
        Male,
        [Description("زن")]
        Female ,
        [Description("سایر")]
        Other ,
        [Description("نامشخص")]
        Unknown
    }
}
