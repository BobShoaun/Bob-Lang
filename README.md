# Bob-Lang
My own programming language????


java -jar antlr-4.13.2-complete.jar -Dlanguage=CSharp BobLang.g4 
-listener -visitor


Generate parser and lexer c# code
```
cd ConsoleApp1/frontend/
antlr4 -Dlanguage=CSharp grammar/BobLangParser.g4 grammar/BobLangLexer.g4 -o grammar/output -Xexact-output-dir -visitor -no-listener
```

Display Parse tree GUI
```
cd frontend
antlr4-parse grammar/BobLangParser.g4 grammar/BobLangLexer.g4 program -gui ../sample/sample.bl
```


Run AST builder
```
cd ConsoleApp1/
dotnet run
```



Setup
```


sudo apt-get install llvm
sudo apt-get install clang


// somehow we have to make it version 5 for it to work?, sample code also uses v5
dotnet add package LLVMSharp --version 5.0.0

dotnet add package Antlr4.Runtime.Standard --version 4.13.1
```