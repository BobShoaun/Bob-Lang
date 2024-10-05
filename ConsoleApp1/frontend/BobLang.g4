grammar BobLang;

prog: (expr NEWLINE)* ;
expr: INT
    | expr ('*' | '/') expr
    | expr ('+'|'-') expr
    | '(' expr ')'
    ;


NEWLINE: [\r\n]+ ;
// INT: [0-9]+ ;

BOOL
    : 'true' 
    | 'false'
    ;
ID 
    : [a-zA-Z][a-zA-Z0-9_]* 
    ;
INT 
    : [0] 
    | ([1-9][0-9]*)
    ;
CHAR
    : '\''.'\'' 
    | '\'''\\'.'\''
    ;
WS  
    : [ \t\r\n]+ 
    -> skip
    ;
COMMENT
    : '//' (~[\r\n])* 
    -> skip
    ;