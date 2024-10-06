// See https://aka.ms/new-console-template for more information
using Antlr4.Runtime;

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