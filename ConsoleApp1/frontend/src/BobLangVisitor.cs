using System.Runtime.InteropServices;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using static BobLangParser;

using ASTNode = AbstractSyntaxTreeNode;

class BobLangVisitor : BobLangParserBaseVisitor<ASTNode>
{

    public override ASTNode VisitProgram(ProgramContext context)
    {
        Console.WriteLine("Visiting program");
        var program = new BobLang.Program();

        foreach (var statementContext in context.statement())
        {
            var statement = Visit(statementContext);
            program.AddChild(statement);
        }

        return program;
    }

    public override ASTNode VisitStatement(StatementContext context)
    {
        return Visit(context.children[0]);
    }

    public override ASTNode VisitDeclaration(DeclarationContext context)
    {
        var modifier = context.Modifier()?.GetText();
        var type = TypeHelper.GetType(context.Type_().GetText());

        var identifier = new Identifier(context.Identifier().GetText());
        var declaration = new Declaration(type, identifier, modifier);

        if (context.expression() != null)
        {
            var expression = Visit(context.expression());
            declaration.AddChild(expression);
        }

        return declaration;
    }

    // public override ASTNode VisitUnaryExpression([NotNull] UnaryExpressionContext context)
    // {
    //     var operand = (Expression)Visit(context.expression());
    //     var @operator = context.GetChild(0).GetText();
    // }

    public override ASTNode VisitPostIncrementExpression(PostIncrementExpressionContext context)
    {
        var operand = (Expression)Visit(context.expression());
        var @operator = context.op.Text;
        return new UnaryExpression(operand, @operator, false);
    }

    public override ASTNode VisitBinaryExpression(BinaryExpressionContext context)
    {
        var left = (Expression)Visit(context.expression(0));
        var right = (Expression)Visit(context.expression(1));
        var operator_ = context.GetChild(1).GetText();

        // print orperator
        Console.WriteLine($"Operator: {operator_}");

        var binaryExpression = new BinaryExpression(left, right, operator_);

        return binaryExpression;
    }

    public override ASTNode VisitIfStatement(IfStatementContext context)
    {
        var condition = (Expression)Visit(context.expression());
        var then = (Statement)Visit(context.statement(0));

        var ifStatement = new IfStatement(condition, then);

        if (context.statement().Length > 1)
        {
            var else_ = (Statement)Visit(context.statement(1));
            ifStatement.setElse(else_);
        }

        return ifStatement;
    }

    public override ASTNode VisitForStatement([NotNull] ForStatementContext context)
    {
        var forStatement = new ForStatement();
        if (context.pre != null)
            forStatement.Pre = Visit(context.pre);
        if (context.condition != null)
            forStatement.Condition = (Expression)Visit(context.condition);
        if (context.post != null)
            forStatement.Post = (Expression)Visit(context.post);
        if (context.statement() != null)
            forStatement.Body = (Statement)Visit(context.statement());

        return forStatement;
    }

    public override ASTNode VisitFunctionExpression(FunctionExpressionContext context)
    {
        return Visit(context.children[0]);
    }

    public override ASTNode VisitFunction(FunctionContext context)
    {
        var returnType = TypeHelper.GetType(context.Type_().GetText());
        var function = new Function(returnType);

        var parameters = Visit(context.parameters());
        foreach (var parameter in parameters.Children)
            function.AddChild(parameter);

        var body = Visit(context.body());
        function.AddChild(body);

        return function;
    }

    public override ASTNode VisitParameters(ParametersContext context)
    {
        var parameters = new ASTNode();
        foreach (var parameterContext in context.parameter())
        {
            var parameter = Visit(parameterContext);
            parameters.AddChild(parameter);
        }
        return parameters;
    }

    public override ASTNode VisitParameter(ParameterContext context)
    {
        var type = TypeHelper.GetType(context.Type_().GetText());

        var parameter = new Parameter(type);
        var identifier = new Identifier(context.Identifier().GetText());
        parameter.AddChild(identifier);

        return parameter;
    }

    public override ASTNode VisitBody(BodyContext context)
    {
        return Visit(context.children[0]);
    }



    public override ASTNode VisitScope(ScopeContext context)
    {
        var scope = new Scope();
        foreach (var statementContext in context.statement())
        {
            var statement = Visit(statementContext);
            scope.AddChild(statement);
        }
        return scope;
    }

    public override ASTNode VisitIdentifierExpression(IdentifierExpressionContext context)
    {
        return new Identifier(context.GetText());
    }

    public override ASTNode VisitLiteral(LiteralContext context)
    {
        var value = context.GetText();
        return value switch
        {
            "true" or "false" 
                => new Literal<bool>(bool.Parse(value), Type.Boolean),
            _ when value.Length == 3 && value[0] == '\'' && value[2] == '\'' 
                => new Literal<char>(value[1], Type.Character),
            _ when value.Length >= 2 && value[0] == '"' && value[^1] == '"' 
                => new Literal<string>(value[1..^1], Type.String),
            _ when value.Contains(".") && float.TryParse(value, out float floatValue) 
                => new Literal<float>(float.Parse(value), Type.Float32),
            _ when int.TryParse(value, out int intValue) 
                => new Literal<int>(intValue, Type.Integer32),
            _ => new Literal<string>(value, Type.String)
        };
    }

    public override ASTNode VisitCallExpression(CallExpressionContext context)
    {
        var callExpression = new CallExpression();
        var callee = Visit(context.expression());
        callExpression.AddChild(callee);

        var arguments = Visit(context.arguments());
        foreach (var argument in arguments.Children)
            callExpression.AddChild(argument);

        return callExpression;
    }

    public override ASTNode VisitArguments(ArgumentsContext context)
    {
        var arguments = new ASTNode();
        foreach (var expressionContext in context.expression())
        {
            var expression = Visit(expressionContext);
            arguments.AddChild(expression);
        }
        return arguments;
    }

    public override ASTNode VisitParenthesizedExpression(ParenthesizedExpressionContext context)
    {
        return Visit(context.expression());
    }

    public override ASTNode VisitReturn(ReturnContext context)
    {
        var expression = context.expression();
        if (expression != null)
        {
            var expressionASTNode = (Expression)Visit(expression);
            return new Return(expressionASTNode);
        }
        return new Return();
    }

}