# MarkdigExtensions.RtfRenderer

This minimalistic RTF Renderer for Markdig allows to render a given markdown file into a valid RTF document.

> :warning: The current implementation is limited to:
> * one header level (`# Heading 1`)
> * Italic emphasis (`*italic text*`)
> * Bold emphasis (`**bold text**`)

## Usage

The renderer is used just as any other renderer for `markdig`. The  following example illustrates a concrete example:

```cs
public static string MarkdownToRtf(string markdown)
{
	var writer = new StringWriter();
	var renderer = new RtfRenderer.RtfRenderer(writer);
	var pipeline = new MarkdownPipelineBuilder().Build();

  // Print the document's start marker
	renderer.StartDocument();

	Markdown.Convert(markdown, renderer, pipeline);

  // Print the document's end marker
	renderer.CloseDocument();

	return writer.ToString();
}
```
