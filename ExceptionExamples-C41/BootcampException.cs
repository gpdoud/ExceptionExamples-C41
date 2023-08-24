using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExamples_C41;

internal class BootcampException : Exception {

    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public BootcampException() : base() { }

    public BootcampException(string message) : base(message) { }

    public BootcampException(string message,  Exception innerException) 
        : base(message, innerException) { }
}
