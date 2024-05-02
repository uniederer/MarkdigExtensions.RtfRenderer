using Markdig.Renderers;
using Markdig.RtfRenderer.Block;
using Markdig.RtfRenderer.Inline;
using System.IO;

namespace Markdig.RtfRenderer
{
    public class RtfRenderer : TextRendererBase<RtfRenderer>
    {
        public RtfRenderer(TextWriter writer) : base(writer)
        {
            // Add all supported renderers
            ObjectRenderers.Add(new HeadingRenderer());
            ObjectRenderers.Add(new ParagraphRenderer());
            ObjectRenderers.Add(new EmphasisInlineRenderer());

            ObjectRenderers.Add(new LiteralInlineRenderer());
        }

        public void StartDocument()
        {
            Writer.WriteLine(@"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1031{\fonttbl{\f0\fnil\fcharset0 Calibri;}}");
            Writer.WriteLine(@"{\colortbl ;\red0\green0\blue0;}");
            Writer.WriteLine(@"\viewkind4\uc1\pard\sa200\sl276\slmult1\f0\fs22\lang7");
        }

        public void CloseDocument()
        {
            Writer.Write("}");
        }

        public void WriteEscape(string text)
        {
            Write(Writer, text);
        }

        protected void Write(TextWriter writer, string text)
        {
            writer.Write(EscapeToRtf(text));
        }

        private string EscapeToRtf(string text)
        {
            return text.Replace("\\", "\\\\").Replace("{", "\\{").Replace("}", "\\}");
        }

        public void WriteStartTag(string tag)
        {
            Writer.Write(tag);
        }

        public void WriteEndTag(string tag)
        {
            Writer.Write(tag);
        }
    }
}