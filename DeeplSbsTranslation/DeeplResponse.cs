using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeeplSbsTranslation
{
    internal class DeeplResponse
    {
        public List<DeeplResponseTranslation>? Translations { get; set; }
    }

    internal class DeeplResponseTranslation
    {
        public string? DetectedSourceLanguage { get; set; }

        public string? Text { get; set; }
    }
}
