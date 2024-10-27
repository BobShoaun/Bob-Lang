class Function : Expression
{
    // public Identifier Identifier { get; }
    // public Identifier[] Parameters { get; }
    // public BlockStatement Body { get; }

    public static int index = -1;

    public string Identifier => $"function{index}";
    
    public Function()
    {
        index ++;
        // Identifier = identifier;
        // Parameters = parameters;
        // Body = body;
    }

    public override string ToString() => $"{base.ToString()} [{Identifier}]";
}