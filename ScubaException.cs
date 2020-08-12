using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Xsl;

namespace BasicExceptionHandle
{
    class ScubaException : Exception
    {
        private int _studentNumber;
        public ScubaException(String message, int studentNumber) : base(message) {
            _studentNumber = studentNumber;
        }

        
    }
}
