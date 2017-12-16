using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormGUI
{
    class Contact
    {
        private string firstName;
        private string lastName;
        private string phoneNum;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
            set
            {
                if (value.Length == 10)
                {
                    phoneNum = value;
                }
                else
                {
                    phoneNum = "No Phone Set";
                }
            }
        }

        //default constructor
        public Contact()
        {
            firstName = "";
            lastName = "";
            phoneNum = "";
        }

        //param constructor
        public Contact(string newFirst, string newLast, string newNum)
        {
            this.FirstName = newFirst;
            this.LastName = newLast;
            this.PhoneNum = newNum;
        }

        public override string ToString()
        {
            string output = String.Empty;

            output += String.Format("{0}, {1}, {2}", this.LastName, this.FirstName, this.PhoneNum);
            return output;
        }

    }
}
