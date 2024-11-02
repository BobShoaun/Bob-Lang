public class CallExpression : Expression
{
    public Expression Callee => (Expression)Children[0];
    public List<Expression> Arguments => Children.Skip(1).Cast<Expression>().ToList();
}