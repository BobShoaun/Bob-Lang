class Literal : Expression
{
    public string Value { get; }
    public Literal(string value) => Value = value;
    
    public override string ToString() => $"{base.ToString()} [{Value}]";

}