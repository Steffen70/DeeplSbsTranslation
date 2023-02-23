using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Linq;

namespace DeeplSbsTranslation
{
    public partial class MainForm : Form
    {
        private static readonly string ApiKey = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void rtbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return) return;

            var totalLines = rtbInput.Lines.Length;
            var lastLine = rtbInput.Lines[totalLines - 1];

            var response = RequestDeeplTranslation(lastLine);

            response.Wait();

            if (!response.Result.Item2) return;

            lbOutput.Items.Add(response.Result.Item1);
        }

        private async Task<(string, bool)> RequestDeeplTranslation(string sentence)
        {
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Add("User-Agent", "C# program");
            var response = await client.GetAsync($"https://api-free.deepl.com/v2/translate?auth_key={ApiKey}&text={sentence}&target_lang=DE").ConfigureAwait(false);

            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            var deeplResponse = JsonConvert.DeserializeObject<DeeplResponse>(responseBody);

            return (deeplResponse?.Translations?.FirstOrDefault()?.Text ?? string.Empty, response.IsSuccessStatusCode);
        }
    }
}