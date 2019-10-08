using System;
using System.Collections.Generic;
using System.Text;

public abstract class SalesMan
{
    private const string format = "{0} {1}";

    private string _firstName { get; set; }
    private string _lastName { get; set; }

    public string FullName
    {
     get{
            return string.Format(format, _firstName + _lastName);
        }
    }

}

