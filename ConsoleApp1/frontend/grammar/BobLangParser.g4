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
    : Modifier? Type_ Identifier ('=' expression)?
    ;

ifStatement
    : 'if' '(' expression ')' statement ('else' statement)?
    ;

iterationStatement
    : 'while' '(' expression ')' statement                                                  # WhileStatment
    | 'do' statement 'while' '(' expression ')' end                                         # DoWhileStatement
    | 'for' '(' pre=iteratorInitializer? ';' condition=expression? ';' post=expression? ')' statement   # ForStatement
    ;

iteratorInitializer
    : declaration
    | expression
    ;

expression
    : function                                          # FunctionExpression
    | expression '(' arguments ')'                      # CallExpression  
    | expression op='++'                                # PostIncrementExpression // PostIncrement
    | expression op='--'                                # PostDecrementExpression // PostDecrement
    | '++' expression                                   # PreIncrementExpression // PreIncrement
    | '--' expression                                   # PreDecrementExpression // PreDecrement
    | '+' expression                                    # UnaryExpression // UnaryPlus
    | '-' expression                                    # UnaryExpression // UnaryMinus
    | '!' expression                                    # UnaryExpression // Not
    | expression ('*' | '/' | '%') expression           # BinaryExpression // Multiplicative
    | expression ('+' | '-') expression                 # BinaryExpression // Additive
    | expression ('<' | '>' | '<=' | '>=') expression   # BinaryExpression // Relational
    | expression ('==' | '!=') expression               # BinaryExpression // Equality
    | expression '&&' expression                        # BinaryExpression // LogicalAND
    | expression '||' expression                        # BinaryExpression // LogicalOR
    | expression '?' expression ':' expression          # TernaryExpression // Ternary
    | expression '=' expression                         # BinaryExpression // Assignment
    | literal                                           # LiteralExpression
    | Identifier                                        # IdentifierExpression
    | '(' expression ')'                                # ParenthesizedExpression
    ;

literal
    : Integer
    | Character
    | Boolean
    | array
    | Null
    ;

arguments
    : 
    | expression (',' expression)*
    ;

array
    : '[' element (',' element)* ']'
    ;

element
    : '...'? expression
    ;

function
    : parameters '=>' Type_? body
    ;

parameters
    : '(' parameter (',' parameter)* ')'
    ;

parameter
    : Type_ Identifier
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
    |
    // | {this.lineTerminatorAhead()}?
    // | {this.closeBrace()}?
    ;

