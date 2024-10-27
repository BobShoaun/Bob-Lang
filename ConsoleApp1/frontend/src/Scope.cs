class Scope : Statement
{

    // variable map goes here

    public List<Statement> Statements => Children.Cast<Statement>().ToList(); 
    public Scope()
    {
    }
}