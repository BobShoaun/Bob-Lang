# Bob-Lang
My own programming language????


java -jar antlr-4.13.2-complete.jar -Dlanguage=CSharp BobLang.g4 
-listener -visitor

```
cd frontend
antlr4 -Dlanguage=CSharp grammar/BobLangParser.g4 grammar/BobLangLexer.g4 -o grammar/output -Xexact-output-dir -visitor -no-listener
```

```
cd frontend
antlr4-parse grammar/BobLangParser.g4 grammar/BobLangLexer.g4 program -gui ../sample/sample.bl
```


Run AST builder
```
cd ConsoleApp1/
dotnet run
```
