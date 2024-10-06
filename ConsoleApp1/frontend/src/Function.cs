class Function : Expression
{
    // public Identifier Identifier { get; }
    // public Identifier[] Parameters { get; }
    // public BlockStatement Body { get; }
    
    public Function()
    {
        // Identifier = identifier;
        // Parameters = parameters;
        // Body = body;
    }

    public override string ToString() => $"{base.ToString()} []";
}