using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class FormProperties
    {
        public static string OperatorName { get; set; }
        public static int GroupCount { get; set; }
        public static int GroupID { get; set; }
        public static string[] InitialDomain { get; set; }
        public static string[] InitialUsers { get; set; }
        public static string DomainLabelOperation { get; set; }
        public static string DomainStringLabel { get; set; }
        public static string OrigDomainToEdit {get; set;}
    }
}
