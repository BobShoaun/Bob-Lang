using System.Diagnostics;

class IfStatement : Statement
{
    public Expression Condition => (Expression)Children[0];
    
    public Statement Then => (Statement)Children[1];
    
    public Statement Else => (Statement)Children[2];
    

    public IfStatement(Expression condition, Statement then)
    {
        AddChild(condition);
        AddChild(then);
    }

    public bool hasElse() => Children.Count == 3;

    public void setElse(Statement statement)
    {
        Debug.Assert(!hasElse()); 
        AddChild(statement);
    }
}