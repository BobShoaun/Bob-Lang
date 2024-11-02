using LLVMSharp;
// using BobLang;

class IntermediateRepresentationBuilder: IAbstractSyntaxTreeVisitor
{

    private readonly LLVMModuleRef module;

    private readonly LLVMBuilderRef builder;

    private readonly Dictionary<string, LLVMValueRef> namedValues = new Dictionary<string, LLVMValueRef>();

    private readonly Stack<LLVMValueRef> valueStack = new Stack<LLVMValueRef>();

    public IntermediateRepresentationBuilder()
    {
        module = LLVM.ModuleCreateWithName("boblang");
        builder = LLVM.CreateBuilder();

        // Initialize JIT and target
        LLVM.LinkInMCJIT();
        LLVM.InitializeX86TargetInfo();
        LLVM.InitializeX86Target();
        LLVM.InitializeX86TargetMC();
    }

    ~IntermediateRepresentationBuilder()
    {
        LLVM.DisposeBuilder(builder);
        LLVM.DisposeModule(module);
    }

    public void Build(AbstractSyntaxTreeNode program)
    {
        // Create a function and a basic block to ensure the module has content
        LLVMTypeRef[] paramTypes = { LLVM.Int32Type(), LLVM.Int32Type() };
        LLVMTypeRef retType = LLVM.FunctionType(LLVM.Int32Type(), paramTypes, false);
        LLVMValueRef func = LLVM.AddFunction(module, "add", retType);
        LLVMBasicBlockRef entry = LLVM.AppendBasicBlock(func, "entry");
        LLVM.PositionBuilderAtEnd(builder, entry);

        // Add some instructions to the basic block
        LLVMValueRef a = LLVM.GetParam(func, 0);
        LLVMValueRef b = LLVM.GetParam(func, 1);
        LLVMValueRef sum = LLVM.BuildAdd(builder, a, b, "sum");
        LLVM.BuildRet(builder, sum);

        program.Accept(this);

        LLVM.DumpModule(module);
    }

    public void VisitProgram(BobLang.Program program)
    {
        Console.WriteLine("Visiting program");

        foreach (var child in program.Children)
            child.Accept(this);
    }

    public void VisitScope(Scope scope)
    {
        throw new NotImplementedException();
    }

    public void VisitDeclaration(Declaration declaration)
    {
        Console.WriteLine("Visiting declaration");

        var value = LLVM.BuildAlloca(builder, TypeHelper.GetLLVMType(declaration.Type), declaration.Identifier.Value);

        namedValues.Add(declaration.Identifier.Value, value);
    }

    public void VisitLiteral<T>(Literal<T> literal)
    {
        Console.WriteLine("Visiting literal: " + literal.Value);
        // throw new NotImplementedException();
        var value = LLVM.ConstReal(TypeHelper.GetLLVMType(Type.Integer32), 69);

        valueStack.Push(value);
    }

    public void VisitIdentifier(Identifier identifier)
    {
        Console.WriteLine("Visiting identifier: " + identifier.Value);
    }

    public void VisitIfStatement(IfStatement ifStatement)
    {
        throw new NotImplementedException();
    }

    public void VisitForStatement(ForStatement forStatement)
    {
        throw new NotImplementedException();
    }

    public void VisitFunction(Function function)
    {
        Console.WriteLine("Visiting function");

        var returnType = TypeHelper.GetLLVMType(function.ReturnType);

        // function.Parameters.ForEach(p => p.Accept(this));

        var parameterTypes = function.Parameters.Select(parameter => TypeHelper.GetLLVMType(parameter.Type)).ToArray();
        var prototype = LLVM.FunctionType(returnType, parameterTypes, false);
        var function_ = LLVM.AddFunction(module, function.Identifier, prototype);
        var entry = LLVM.AppendBasicBlock(function_, "entry");

        LLVM.PositionBuilderAtEnd(builder, entry);

        for (int i = 0; i < function.Parameters.Count; i++)
        {
            var parameter = function.Parameters[i];
            var type = TypeHelper.GetLLVMType(parameter.Type);
            var name = parameter.Name.Value;

            var alloca = LLVM.BuildAlloca(builder, type, name);
            var llvmParameter = LLVM.GetParam(function_, (uint)i);
            LLVM.BuildStore(builder, llvmParameter, alloca);
        }


        valueStack.Push(function_); // push first to enable recursive calls
        function.Body.Accept(this);
    }

    public void VisitUnaryExpression(UnaryExpression unaryExpression)
    {
        throw new NotImplementedException();
    }

    public void VisitBinaryExpression(BinaryExpression binaryExpression)
    {
        Console.WriteLine("Visiting binary expression fdf");

        return;

        binaryExpression.Left.Accept(this);
        var leftValue = valueStack.Pop();

        binaryExpression.Right.Accept(this);
        var rightValue = valueStack.Pop();

        LLVMValueRef result;

        switch (binaryExpression.Operator)
        {
            case "+":
                result = LLVM.BuildAdd(builder, leftValue, rightValue, "addtmp");
                break;
            case "-":
                result = LLVM.BuildSub(builder, leftValue, rightValue, "subtmp");
                break;
            case "*":
                result = LLVM.BuildMul(builder, leftValue, rightValue, "multmp");
                break;
            case "/":
                result = LLVM.BuildSDiv(builder, leftValue, rightValue, "divtmp");
                break;
            default:
                // throw new Exception("invalid binary operator");
                throw new NotImplementedException();
        }

        valueStack.Push(result);
    }

    public void VisitCallExpression(CallExpression callExpression)
    {
        callExpression.Callee.Accept(this);
        // string functionName = (callExpression.Callee as Identifier).Value;
        // Console.WriteLine("Visiting call expression: " + functionName);
    }

    public void VisitParameter(Parameter parameter)
    {
        throw new NotImplementedException();
    }

    public void VisitReturnStatement(Return returnStatement)
    {

        if (returnStatement.HasExpression) {
            returnStatement.Expression.Accept(this);
            // LLVMValueRef value;
            // LLVM.BuildRet(builder, value);
        }
        else
            LLVM.BuildRetVoid(builder);
    }
}