public class Literal<T> : Expression
{
    public T Value { get; }
    public Type Type { get; }
    public Literal(T value, Type type) { 
        Value = value;
        Type = type;
    }
    
    public override string ToString() => $"{base.ToString()} [{Type} {Value}]";

    public override void Accept(IAbstractSyntaxTreeVisitor visitor) 
        => visitor.VisitLiteral(this);

}