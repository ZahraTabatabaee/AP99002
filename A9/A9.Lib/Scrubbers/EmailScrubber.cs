using System.Text.RegularExpressions;

namespace Logger
{
    public class EmailScrubber : AbstractScrubber
    {
        private EmailScrubber() { }

        private static EmailScrubber _Instance;

        public static EmailScrubber Instance => _Instance ?? (_Instance = new EmailScrubber());

        /// <summary>
        /// Regular expression for Email:
        /// ali@en.yahoo.com
        /// xxx@xx.xxxxx.xxx
        /// </summary>
        protected override Regex PIIRegEx => new Regex(@"[A-Za-z_]+@([a-z]+\.)+[a-z]+");

        public override string Scrub(string content) => this.MaskPII(content, this.MaskLetters);
    }
}