using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Security.Principal;
using System.Xml.Schema;

public record Novel
{
    //[XmlElement(ElementName = "title")]
    [XmlArray("titles")]
    [XmlArrayItem("title", typeof(string))]
    public string[] Titles { get; set; } 

    [XmlElement(ElementName = "author")]
    public string Author { get; set; } = string.Empty;

    /*
    [XmlElement(ElementName = "published")]
    public int PublishedYear { get; set; } 
    */
}

public class Program
{
    public static  void Main(string[] args)
    {
        var novel = new Novel
        {
            Author = "aaaa",
            Titles = new string[]
            {
                "AAAA","AaAa","aAaA"
            },
            //PublishedYear = 9999,
        };
        using (var writer = XmlWriter.Create("novel.xml")) 
        {
            var serializer = new XmlSerializer(novel.GetType());
            serializer.Serialize(writer, novel);
        }
    }

}