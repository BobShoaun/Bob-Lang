using System.Runtime.InteropServices;
using Antlr4.Runtime.Misc;
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
        var type = context.Type_().GetText();

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

    public override ASTNode VisitPostIncrementExpression (PostIncrementExpressionContext context)
    {
        var operand = (Expression)Visit(context.expression());
        var @operator = context.op.Text;
        return new UnaryExpression(operand, @operator, false);
    }

    public override ASTNode VisitBinaryExpression (BinaryExpressionContext context)
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
        Visit(context.children[0]);
        // Visit(context.children[2]);
        
        return new Function();
    }

    public override ASTNode VisitParameters(ParametersContext context)
    {
        return base.VisitParameters(context);
    }

    public override ASTNode VisitScope([NotNull] ScopeContext context)
    {
        var scope = new Scope();
        foreach(var statementContext in context.statement())
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
        var literal = new Literal(value);
        return literal;
    }

}