public class AbstractSyntaxTreeNode
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

    public string ToStringTree(string prefix = "")
    {
        var display = ToString();

        for (int i = 0; i < Children.Count; i++)
        {
            var child = Children[i];
            var isLast = i == Children.Count - 1;
            var prefixGuide = prefix + (isLast ? "╚═ " : "╠═ ");
            var childGuide = prefix + (isLast ? "   " : "║  ");

            display += $"\n{prefixGuide}{child?.ToStringTree(childGuide)}";
        }

        return display;
    }

    public virtual void GenerateIR() {
        foreach (var child in Children)
            child.GenerateIR();
    }

    public virtual void Accept(IAbstractSyntaxTreeVisitor visitor) {}

}