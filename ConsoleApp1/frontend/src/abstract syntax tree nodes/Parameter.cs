public class Parameter : AbstractSyntaxTreeNode
{
    public Type Type { get; private set; }
    public Identifier Name => (Identifier)Children[0];

    public Parameter(Type type)
    {
        Type = type;
    }

    public override string ToString() => $"{base.ToString()} [{Type}]";

    public override void Accept(IAbstractSyntaxTreeVisitor visitor)
        => visitor.VisitParameter(this);
}