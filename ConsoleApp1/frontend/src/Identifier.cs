class Identifier : Expression
{
    public string Value { get; }

    public Identifier(string value) => Value = value;

    public override string ToString() => $"{base.ToString()} [{Value}]";
}