using System.Diagnostics;
using System.Reflection;

class Declaration : Statement
{
    public string Modifier { get; }
    public string Type { get; }
    public Identifier Identifier => (Identifier)Children[0];
    public Expression InitialExpression => (Expression)Children[1];


    public Declaration(string type, Identifier identifier, string modifier) 
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

}