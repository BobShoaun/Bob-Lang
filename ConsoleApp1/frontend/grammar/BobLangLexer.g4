lexer grammar BobLangLexer;


Type_
    : 'short'
    | 'int16'
    | 'integer16'
    | 'int'
    | 'integer'
    | 'int32'
    | 'integer32'
    | 'long'
    | 'int64'
    | 'integer64'
    | 'half'
    | 'float16'
    | 'single'
    | 'float'
    | 'float32'
    | 'double'
    | 'float64'
    | 'decimal'
    | 'float128'
    | 'char' 
    | 'character'
    | 'str'
    | 'string'
    | 'bool' 
    | 'boolean'
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

Float
    : [0-9]*'.'[0-9]+
    ;

Character
    : '\''.'\'' 
    | '\'''\\'.'\''
    ;

String
    : '"' (~["\r\n])* '"'
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