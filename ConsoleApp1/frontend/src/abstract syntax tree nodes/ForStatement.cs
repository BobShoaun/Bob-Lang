using System.Diagnostics;
using ASTNode = AbstractSyntaxTreeNode;

public class ForStatement : Statement
{
    private int preIndex = -1;
    private int conditionIndex = -1;
    private int postIndex = -1;
    private int bodyIndex = -1;

    public ASTNode Pre
    {
        get => Children[preIndex];
        set
        {
            Debug.Assert(preIndex == -1);
            AddChild(value);
            preIndex = Children.Count - 1;
        }
    }
    public Expression Condition
    {
        get => (Expression)Children[conditionIndex];
        set
        {
            Debug.Assert(conditionIndex == -1);
            AddChild(value);
            conditionIndex = Children.Count - 1;
        }
    }
    public Expression Post
    {
        get => (Expression)Children[postIndex];
        set
        {
            Debug.Assert(postIndex == -1);
            AddChild(value);
            postIndex = Children.Count - 1;
        }
    }
    public Statement Body
    {
        get => (Expression)Children[bodyIndex];
        set
        {
            Debug.Assert(bodyIndex == -1);
            AddChild(value);
            bodyIndex = Children.Count - 1;
        }
    }

    public ForStatement()
    {
        // Constructor body can be empty or contain initialization logic
    }

}

