class Scope : Statement
{

    // symbol table map goes here

    public List<Statement> Statements => Children.Cast<Statement>().ToList(); 
    public Scope()
    {
    }
}