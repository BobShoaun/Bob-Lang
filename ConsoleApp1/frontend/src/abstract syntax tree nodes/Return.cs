public class Return : Statement {
    public Expression Expression => (Expression)Children[0];

    public bool HasExpression => Children.Count == 1;

    public Return() {}
    public Return(Expression expression) => AddChild(expression);
    public override void Accept(IAbstractSyntaxTreeVisitor visitor) => visitor.VisitReturnStatement(this);
}