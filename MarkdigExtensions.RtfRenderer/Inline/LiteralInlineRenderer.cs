using Markdig.Renderers;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace MarkdigExtensions.RtfRenderer.Inline
{
    public class LiteralInlineRenderer : MarkdownObjectRenderer<RtfRenderer, LiteralInline>
    {
        protected override void Write(RtfRenderer renderer, LiteralInline obj)
        {
            renderer.WriteEscape(obj.Content.ToString());
        }
    }
}
