using Antlr4.Runtime;
using LLVMSharp;

var inputStream = new AntlrFileStream("sample/sample.bl");
var lexer = new BobLangLexer(inputStream);
var tokenStream = new CommonTokenStream(lexer);
var parser = new BobLangParser(tokenStream);

var program = parser.program();
// Console.WriteLine(program.ToInfoString());
var visitor = new BobLangVisitor();
var tree = visitor.Visit(program);


Console.WriteLine("Abstract Syntax Tree:");

Console.WriteLine(tree.ToStringTree());
// Console.WriteLine(tree);


var module = LLVM.ModuleCreateWithName("boblang");
var builder = LLVM.CreateBuilder();
// LLVMModuleRef module = LLVM.ModuleCreateWithName("my cool jit");
// LLVMBuilderRef builder = LLVM.CreateBuilder();

LLVMBool Success = new LLVMBool(0);

// LLVMValueRef ff;

// LLVM.GetInsertBlock();


  LLVM.LinkInMCJIT();
//             LLVM.InitializeX86TargetMC();
//             LLVM.InitializeX86Target();
//             LLVM.InitializeX86TargetInfo();
//             LLVM.InitializeX86AsmParser();
//             LLVM.InitializeX86AsmPrinter();