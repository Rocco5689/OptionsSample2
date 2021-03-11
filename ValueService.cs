using System;

namespace ServiceOptionsSample
{
public class ValueService
{
    private readonly Guid _val = Guid.NewGuid();

    // Return a fixed Guid for the lifetime of the service
    public Guid GetValue() => _val; 
}
}