using Markdig.Syntax.Inlines;
using Markdig.Renderers;

namespace Markdig.RtfRenderer.Inline
{
    public class EmphasisInlineRenderer : MarkdownObjectRenderer<RtfRenderer, EmphasisInline>
    {
        protected override void Write(RtfRenderer renderer, EmphasisInline obj)
        {
            var tag = obj.DelimiterCount == 1 ? "{\\i " : "{\\b ";
            renderer.WriteStartTag(tag);
            renderer.WriteChildren(obj);
            renderer.WriteEndTag("}");
        }
    }
}