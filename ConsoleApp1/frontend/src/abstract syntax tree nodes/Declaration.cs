using System.Diagnostics;

public class Declaration : Statement
{
    public string Modifier { get; }
    public Type Type { get; }
    public Identifier Identifier => (Identifier)Children[0];
    public Expression InitialExpression => (Expression)Children[1];


    public Declaration(Type type, Identifier identifier, string modifier)
    {
        Modifier = modifier ?? "constant";
        Type = type;
        AddChild(identifier);
    }

    public bool hasInitialExpression() => Children.Count == 2;

    public void SetInitialExpression(Expression expression)
    {
        Debug.Assert(!hasInitialExpression());
        AddChild(expression);
    }

    public override string ToString() => $"{base.ToString()} [{Modifier} {Type}]";

    public override void Accept(IAbstractSyntaxTreeVisitor visitor)
        => visitor.VisitDeclaration(this);

}