using Markdig.Renderers;
using Markdig.Syntax;

namespace Markdig.RtfRenderer.Block
{
    public class HeadingRenderer : MarkdownObjectRenderer<RtfRenderer, HeadingBlock>
    {
        protected override void Write(RtfRenderer renderer, HeadingBlock obj)
        {
            var sizeTag = obj.Level == 1 ? "{\\fs36 " : "{\\fs24 "; // Einfaches Beispiel für zwei Größen
            renderer.WriteStartTag(sizeTag);
            renderer.WriteLeafInline(obj);
            renderer.WriteEndTag("\\par}");
        }
    }
}