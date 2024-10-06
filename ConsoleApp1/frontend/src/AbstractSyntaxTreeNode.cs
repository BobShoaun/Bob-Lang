class AbstractSyntaxTreeNode
{
    public int lineNumber { get; set; }
    public List<AbstractSyntaxTreeNode> Children { get; set; }

    public AbstractSyntaxTreeNode()
    {
        Children = new List<AbstractSyntaxTreeNode>();
    }

    public void AddChild(AbstractSyntaxTreeNode child)
    {
        Children.Add(child);
    }

    public override string ToString() => GetType().Name;

    public string ToStringTree(int indent = 0)
    {
        var display = ToString();
        var indentation = new string(' ', indent);

        foreach(var child in Children)
            display += $"\n{indentation}|| {child?.ToStringTree(indent + 3)}";
        return display;
    }

}