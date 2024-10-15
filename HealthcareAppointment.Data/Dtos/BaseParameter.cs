using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareAppointment.Data.Dtos
{
	public class BaseParameter
	{
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }
        public int MyProperty { get; set; }
    }
}
