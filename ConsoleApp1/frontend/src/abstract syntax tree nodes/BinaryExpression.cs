public class BinaryExpression : Expression
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

    public override void GenerateIR()
    {
        Console.WriteLine("Generating IR for BinaryExpression");

        Left.GenerateIR();
        Right.GenerateIR();

    }

    public override void Accept(IAbstractSyntaxTreeVisitor visitor)
        => visitor.VisitBinaryExpression(this);

}