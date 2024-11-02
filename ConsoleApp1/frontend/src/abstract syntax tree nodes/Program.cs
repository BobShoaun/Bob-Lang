using LLVMSharp;

namespace BobLang;

public class Program : AbstractSyntaxTreeNode
{

    // variable map goes here, or maybe we should inherit from Scope? or make an interface

    private readonly Dictionary<string, LLVMValueRef> symbolTable = new Dictionary<string, LLVMValueRef>();

    public Program()
    {
        
    }

    public override void Accept(IAbstractSyntaxTreeVisitor visitor)
        => visitor.VisitProgram(this);


}