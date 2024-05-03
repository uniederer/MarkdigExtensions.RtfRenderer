using Markdig.Renderers;
using Markdig.Syntax;

namespace MarkdigExtensions.RtfRenderer.Block
{
    public class HeadingRenderer : MarkdownObjectRenderer<RtfRenderer, HeadingBlock>
    {
        protected override void Write(RtfRenderer renderer, HeadingBlock obj)
        {
            RtfMarkup markup = GetMarkupForLevel(renderer, obj.Level);
            renderer.WriteStartTag(markup.Start);
            renderer.WriteLeafInline(obj);
            renderer.WriteEndTag(markup.End);
        }

        private static RtfMarkup GetMarkupForLevel(RtfRenderer renderer, int level)
        {
            var markupIndex = level - 1;

            if (markupIndex >= renderer.HeadingMarkup.Length)
            {
                markupIndex = renderer.HeadingMarkup.Length - 1;
            }

            return renderer.HeadingMarkup[markupIndex];
        }
    }
}