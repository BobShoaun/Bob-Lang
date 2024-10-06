class Scope : Statement
{
    public List<Statement> Statements => Children.Cast<Statement>().ToList(); 
    public Scope()
    {
    }
}