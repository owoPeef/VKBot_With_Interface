using HtmlAgilityPack;

namespace Web
{
    class VK
    {
        public static HtmlDocument GetVKStatus()
        {
            string url = "https://vk.com/dev/health";
            var web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
            return doc;
        }
    }
}
