using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivManagementSyetem
{
    class Staff : Faculty
    {
        private string type;

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    type = value;
                else
                    ErrorMsg.WrongValueError(value);
            }
        }
    }
}
