using Markdig;

namespace MarkdigExtensions.RtfRenderer.Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MarkDown_TextChanged(MarkDown, new());
        }

        private void MarkDown_TextChanged(object sender, EventArgs e)
        {
            var src = sender as TextBox; 

            if (src == null)
            {
                return;
            }

            Task.Run(() =>
            {
                var rtf = MarkdownToRtf(src.Text);

                Invoke(() =>
                {
                    RichText.Rtf = rtf;
                });
            });
        }

        public static string MarkdownToRtf(string markdown)
        {
            var writer = new StringWriter();
            var renderer = new RtfRenderer(writer);
            var pipeline = new MarkdownPipelineBuilder().Build();

            // Print the document's start marker
            renderer.StartDocument();

            Markdown.Convert(markdown, renderer, pipeline);

            // Print the document's end marker
            renderer.CloseDocument();

            return writer.ToString();
        }
    }
}
