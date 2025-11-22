public class Scope : Statement
{

    // symbol table map goes here

    public List<Statement> Statements => Children.Cast<Statement>().ToList(); 
    public Scope()
    {
    }

    public override void Accept(IAbstractSyntaxTreeVisitor visitor)
        => visitor.VisitScope(this);
}