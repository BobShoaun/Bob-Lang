using Antlr4.Runtime;
// using LLVMSharp;

var inputStream = new AntlrFileStream("sample/sample.bl");
var lexer = new BobLangLexer(inputStream);
var tokenStream = new CommonTokenStream(lexer);
var parser = new BobLangParser(tokenStream);

var program = parser.program();
// Console.WriteLine(program.ToInfoString());
var visitor = new BobLangVisitor();
var programASTNode = visitor.Visit(program);


Console.WriteLine("Abstract Syntax Tree:");

Console.WriteLine(programASTNode.ToStringTree());
// Console.WriteLine(tree);


// LLVM code generation

var irBuilder = new IntermediateRepresentationBuilder();
irBuilder.Build(programASTNode);
// programASTNode.Accept(irBuilder);
// irBuilder.VisitProgram((BobLang.Program)programASTNode);

// programASTNode.GenerateIR();

// var module = LLVM.ModuleCreateWithName("boblang");
// var builder = LLVM.CreateBuilder();

// // Create a function and a basic block to ensure the module has content
// LLVMTypeRef[] paramTypes = { LLVM.Int32Type(), LLVM.Int32Type() };
// LLVMTypeRef retType = LLVM.FunctionType(LLVM.Int32Type(), paramTypes, false);
// LLVMValueRef func = LLVM.AddFunction(module, "add", retType);
// LLVMBasicBlockRef entry = LLVM.AppendBasicBlock(func, "entry");
// LLVM.PositionBuilderAtEnd(builder, entry);

// // Add some instructions to the basic block
// LLVMValueRef a = LLVM.GetParam(func, 0);
// LLVMValueRef b = LLVM.GetParam(func, 1);
// LLVMValueRef sum = LLVM.BuildAdd(builder, a, b, "sum");
// LLVM.BuildRet(builder, sum);

// // Initialize JIT and target
// LLVM.LinkInMCJIT();
// LLVM.InitializeX86TargetInfo();
// LLVM.InitializeX86Target();
// LLVM.InitializeX86TargetMC();

// Dump the module
// LLVM.DumpModule(irBuilder.Module);

