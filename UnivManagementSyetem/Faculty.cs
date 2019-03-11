using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivManagementSyetem
{
    class Faculty : Person
    {
        private int pay;
        private string position;

        public int Pay
        {
            get
            {
                return pay;
            }
            set
            {
                if (value >= 0)
                    pay = value;
                else
                    ErrorMsg.WrongValueError("0 이상");
            }
        }

        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    position = value;
                else
                    ErrorMsg.WrongValueError(value);
            }
        }
    }
}
