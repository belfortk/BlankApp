using System;
namespace HelloWorld
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public Text()
        {
        }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("AddHyperLink");
        }
    }
}
