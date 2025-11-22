using LLVMSharp;

public class Function : Expression
{
    // public Identifier Identifier { get; }
    // public Identifier[] Parameters { get; }
    // public BlockStatement Body { get; }

    public static int index = 0;

    public Type ReturnType { get; private set; }

    public string Identifier { get; }

    public List<Parameter> Parameters => Children.Take(Children.Count - 1).Cast<Parameter>().ToList();

    public Statement Body => (Statement)Children.Last();
    
    public Function(Type returnType)
    {
        Identifier = $"function{index++}";
        ReturnType = returnType;
    }

    public override string ToString() => $"{base.ToString()} [{ReturnType} {Identifier}]";

    public override void Accept(IAbstractSyntaxTreeVisitor visitor)
        => visitor.VisitFunction(this);
}