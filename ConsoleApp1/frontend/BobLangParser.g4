parser grammar BobLangParser;

options {
    tokenVocab = BobLangLexer;
}

program
    : statement*
    ;

statement
    : declaration end
    | expression end
    | ifStatement
    | iterationStatement
    | scope
    ;

declaration
    : Modifier? Type Identifier ('=' expression)?
    ;

ifStatement
    : 'if' '(' expression ')' statement ('else' statement)?
    ;

iterationStatement
    : 'while' '(' expression ')' statement
    | 'do' statement 'while' '(' expression ')' end
    | 'for' '(' (declaration)? ';' expression? ';' expression? ')' statement
    ;

expression
    : function                                    
    | expression '++'                                   // PostIncrement
    | expression '--'                                   // PostDecrement
    | '++' expression                                   // PreIncrement
    | '--' expression                                   // PreDecrement
    | '+' expression                                    // UnaryPlus
    | '-' expression                                    // UnaryMinus
    | '!' expression                                    // Not
    | expression ('*' | '/' | '%') expression           // Multiplicative
    | expression ('+' | '-') expression                 // Additive
    | expression ('<' | '>' | '<=' | '>=') expression   // Relational
    | expression ('==' | '!=') expression               // Equality
    | expression '&&' expression                        // LogicalAND
    | expression '||' expression                        // LogicalOR
    | expression '?' expression ':' expression          // Ternary
    | expression '=' expression                         // Assignment
    | Identifier                                        
    | literal                                           
    | '(' expression ')'                                
    ;

literal
    : Integer
    | Character
    | Boolean
    | Null
    ;

function
    : parameters '=>' body
    ;

parameters
    : '(' parameter (',' parameter)* ')'
    ;

parameter
    : Type Identifier
    ;

body
    : scope
    | expression
    ;

scope
    : '{' statement* '}'
    ;

end
    : SemiColon
    | EOF
    | {this.lineTerminatorAhead()}?
    | {this.closeBrace()}?
    ;

