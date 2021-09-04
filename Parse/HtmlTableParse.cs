using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net;


namespace EU4RandomCountryPicker.Parse
{
    class HtmlTableParse : EU4RandomCountryPicker.Interfaces.IParse
    {
        public object Parse(string downloadPage, string tableName)
        {
            string output = string.Empty;

            WebClient web = new WebClient();
            string page = web.DownloadString(downloadPage);

            HtmlDocument documentedPage = new HtmlDocument();
            documentedPage.LoadHtml(page);

            var table = documentedPage.DocumentNode.SelectNodes("//table")
                                                    .Single(x => x.HasClass(tableName));

            foreach (HtmlNode row in table.Descendants()
                    .Where(desc =>
                        desc.Name.Equals("tr", StringComparison.OrdinalIgnoreCase) &&
                        desc.Descendants().Any(child => child.Name.Equals("td",
                            StringComparison.OrdinalIgnoreCase))))
            {
                output += string.Join("|", row.Descendants().Where(desc =>
                    desc.Name.Equals("td", StringComparison.OrdinalIgnoreCase))
                    .Select(desc => desc.InnerText));
            }

            return output;
        }
    }
}
