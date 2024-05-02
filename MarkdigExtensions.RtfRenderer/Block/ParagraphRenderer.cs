using Markdig.Syntax;
using Markdig.Renderers;

namespace MarkdigExtensions.RtfRenderer.Block
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