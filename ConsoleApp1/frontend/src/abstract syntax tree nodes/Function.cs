using LLVMSharp;

public class Function : Expression
{
    // public Identifier Identifier { get; }
    // public Identifier[] Parameters { get; }
    // public BlockStatement Body { get; }

    public static int index = -1;

    public Type ReturnType { get; private set; }

    public string Identifier => $"function{index}";

    public List<Parameter> Parameters => Children.Take(Children.Count - 1).Cast<Parameter>().ToList();

    public Statement Body => (Statement)Children.Last();
    
    public Function(Type returnType)
    {
        index ++;
        ReturnType = returnType;
    }

    public override string ToString() => $"{base.ToString()} [{Identifier}]";

    public override void GenerateIR()
    {
        Console.WriteLine("Generating IR for Function");

        Body.GenerateIR();

        // LLVMTypeRef[] paramTypes = { LLVM.Int32Type(), LLVM.Int32Type() };
        // LLVMTypeRef retType = LLVM.FunctionType(LLVM.Int32Type(), paramTypes, false);
        // LLVMValueRef func = LLVM.AddFunction(Module, "add", retType);
        // LLVMBasicBlockRef entry = LLVM.AppendBasicBlock(func, "entry");
        // LLVM.PositionBuilderAtEnd(builder, entry);
    }

    public override void Accept(IAbstractSyntaxTreeVisitor visitor)
        => visitor.VisitFunction(this);
}