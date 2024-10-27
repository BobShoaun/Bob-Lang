lexer grammar BobLangLexer;


Type_
    : 'int' | 'integer'
    | 'char' | 'character'
    | 'bool' | 'boolean'
    | 'float' | 'single'
    | 'double'
    | 'string'
    | 'void'
    ;

SemiColon                   : ';';
Comma                       : ',';
Colon                       : ':';
QuestionMark                : '?';

OpenParenthesis             : '(';
CloseParenthesis            : ')';
OpenBracket                 : '[';
CloseBracket                : ']';
OpenBrace                   : '{';
CloseBrace                  : '}';

Ellipsis                    : '...';
Dot                         : '.';

Not                         : '!';
PlusPlus                    : '++';
MinusMinus                  : '--';
Plus: '+';
Minus: '-';
Multiply: '*';
Divide: '/';
Modulo: '%';

Assign: '=';
Arrow: '=>';


LessThan                   : '<';
MoreThan                   : '>';
LessThanEquals             : '<=';
GreaterThanEquals          : '>=';
Equals_                     : '==';
NotEquals                  : '!=';

And                        : '&&';
Or                         : '||';

/// Keywords

Break      : 'break';
Do         : 'do';
Case       : 'case';
Else       : 'else';
New        : 'new';
Catch      : 'catch';
Finally    : 'finally';
Return     : 'return';
Continue   : 'continue';
For        : 'for';
Switch     : 'switch';
While      : 'while';
This       : 'this';
With       : 'with';
Default    : 'default';
If         : 'if';
Throw      : 'throw';
Delete     : 'delete';
In         : 'in';
Try        : 'try';
As         : 'as';
From       : 'from';
Of         : 'of';
Yield      : 'yield';
YieldStar  : 'yield*';

Modifier
    : 'variable' | 'var'
    | 'constant' | 'const'
    ;








Null: 'null';

Boolean
    : 'true' 
    | 'false'
    ;

Integer 
    : [0] 
    | [1-9][0-9]*
    ;

Character
    : '\''.'\'' 
    | '\'''\\'.'\''
    ;

Identifier
    : [a-zA-Z][a-zA-Z0-9_]* 
    ;


Whitespace  
    : [ \t\r\n]+ 
    -> skip
    ;

// Newline
//     : [\r\n]+
//     | [\n]+
//     ;


Comment
    : '//' (~[\r\n])* 
    -> skip
    ;