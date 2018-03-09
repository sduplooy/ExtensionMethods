[![Build Status](https://travis-ci.org/sduplooy/ParameterExtensions.svg?branch=master)](https://travis-ci.org/sduplooy/ParameterExtensions)
[![NuGet Badge](https://buildstats.info/nuget/ParameterExtensions)](https://www.nuget.org/packages/ParameterExtensions/)

# ParameterExtensions
A small collection of parameter extension methods that check whether a parameter is null. In the case of strings, it will check that the parameter is not null and not empty.

# NuGet
To install the package from NuGet, run the following command: `Install-Package ParameterExtensions`

# Examples
```C#
using ParameterExtensions;
    
public class MyClass
{
    public void MyMethod(object obj)
    {
        obj.ThrowIfNull(nameof(obj));
        ...
    }
    
    public void MyMethod(string str)
    {
       str.ThrowIfNullOrEmpty(nameof(str));
       ...
    }
}
```
