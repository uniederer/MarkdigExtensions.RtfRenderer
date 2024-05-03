using System;
using System.Collections.Generic;
using System.Text;

namespace MarkdigExtensions.RtfRenderer
{
    public record RtfMarkup
    {
        public string Start { get; private set; }
        public string End { get; private set; }

        public RtfMarkup(string start, string end)
        {
            Start = start;
            End = end;
        }
    }
}
