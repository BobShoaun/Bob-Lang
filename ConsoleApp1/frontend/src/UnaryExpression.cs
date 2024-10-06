class UnaryExpression : Expression
{
    public Expression Operand => (Expression)Children[0];
    public string Operator { get; }
    public bool IsPre { get; }

    public UnaryExpression(Expression operand, string @operator, bool isPre)
    {
        AddChild(operand);
        Operator = @operator;
        IsPre = isPre;
    }

    public override string ToString() => $"{base.ToString()} [{Operator}]";

}