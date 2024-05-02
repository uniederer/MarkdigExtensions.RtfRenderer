using Markdig.Syntax;
using Markdig.Renderers;

namespace Markdig.RtfRenderer.Block
{
    public class ParagraphRenderer : MarkdownObjectRenderer<RtfRenderer, ParagraphBlock>
    {
        protected override void Write(RtfRenderer renderer, ParagraphBlock obj)
        {
            renderer.Write("{\\pard ");
            renderer.WriteLeafInline(obj);
            renderer.WriteLine("\\par}");
        }
    }
}