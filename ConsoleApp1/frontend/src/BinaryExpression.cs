class BinaryExpression : Expression
{
    public Expression Left => (Expression)Children[0];
    public Expression Right => (Expression)Children[1];
    public string Operator { get; }

    public BinaryExpression(Expression left, Expression right, string @operator)
    {
        AddChild(left);
        AddChild(right);
        Operator = @operator;
    }

    public override string ToString() => $"{base.ToString()} [{Operator}]";

}