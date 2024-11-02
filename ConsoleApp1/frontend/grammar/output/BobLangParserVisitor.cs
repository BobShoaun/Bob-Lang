//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from grammar/BobLangParser.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="BobLangParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public interface IBobLangParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] BobLangParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] BobLangParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaration([NotNull] BobLangParser.DeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] BobLangParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>WhileStatment</c>
	/// labeled alternative in <see cref="BobLangParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatment([NotNull] BobLangParser.WhileStatmentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DoWhileStatement</c>
	/// labeled alternative in <see cref="BobLangParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDoWhileStatement([NotNull] BobLangParser.DoWhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="BobLangParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] BobLangParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.iteratorInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIteratorInitializer([NotNull] BobLangParser.IteratorInitializerContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpression([NotNull] BobLangParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TernaryExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTernaryExpression([NotNull] BobLangParser.TernaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PostIncrementExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostIncrementExpression([NotNull] BobLangParser.PostIncrementExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionExpression([NotNull] BobLangParser.FunctionExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PreDecrementExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreDecrementExpression([NotNull] BobLangParser.PreDecrementExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PreIncrementExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreIncrementExpression([NotNull] BobLangParser.PreIncrementExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BinaryExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryExpression([NotNull] BobLangParser.BinaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralExpression([NotNull] BobLangParser.LiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpression([NotNull] BobLangParser.UnaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PostDecrementExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostDecrementExpression([NotNull] BobLangParser.PostDecrementExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CallExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallExpression([NotNull] BobLangParser.CallExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="BobLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpression([NotNull] BobLangParser.IdentifierExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] BobLangParser.LiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArguments([NotNull] BobLangParser.ArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArray([NotNull] BobLangParser.ArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElement([NotNull] BobLangParser.ElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] BobLangParser.FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameters([NotNull] BobLangParser.ParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] BobLangParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBody([NotNull] BobLangParser.BodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.scope"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScope([NotNull] BobLangParser.ScopeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturn([NotNull] BobLangParser.ReturnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.break"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBreak([NotNull] BobLangParser.BreakContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.continue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContinue([NotNull] BobLangParser.ContinueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BobLangParser.end"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnd([NotNull] BobLangParser.EndContext context);
}
