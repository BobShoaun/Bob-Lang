// namespace BobLang;

public interface IAbstractSyntaxTreeVisitor
{
    void VisitProgram(BobLang.Program program);

    void VisitScope(Scope scope);

    void VisitDeclaration(Declaration declaration);

    void VisitLiteral(Literal literal);

    void VisitIdentifier(Identifier identifier);

    void VisitIfStatement(IfStatement ifStatement);

    void VisitForStatement(ForStatement forStatement);

    void VisitFunction(Function function);

    void VisitParameter(Parameter parameter);

    void VisitUnaryExpression(UnaryExpression unaryExpression);

    void VisitBinaryExpression(BinaryExpression binaryExpression);

    void VisitCallExpression(CallExpression callExpression);

    void VisitReturnStatement(Return returnStatement);

}