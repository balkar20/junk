namespace RefStruct;

public struct StringHolder
{
    public string Value { get; set; }

    public override string ToString()
    {
        return Value;
    }
}