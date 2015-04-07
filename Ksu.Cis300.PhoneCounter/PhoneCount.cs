using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.PhoneCounter
{
    class PhoneCount
    {
        private int _count;
        private string _phoneNumber;

        public PhoneCount(int count, string number) {
            _count = count;
            _phoneNumber = number;
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public string Numer
        {
            get
            {
                return _phoneNumber;
            }
        }
    }
}
