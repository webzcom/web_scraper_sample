using HtmlAgilityPack;
using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebScraper {

class Program
{
    static void Main()
    {

        String url = "https://costplusdrugs.com/medications/famotidine-10mg-tablet/";
        var httpClient = new HttpClient();
        var html = httpClient.GetStringAsync(url).Result;
        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(html);

        // The original long string
        //string longString = "Here is a sample string that we will split based on the word 'and'. Something Else";

        // Specify the string delimiter
        //string[] delimiter = new string[] { "props" };
        string[] delimiter = new string[] { @"props" };
        string[] delimiter2 = new string[] { @"</script>" };


        // Split the string based on the delimiter
        // Note: StringSplitOptions.RemoveEmptyEntries option to remove any empty entries from the resulting array
        string[] parts = html.Split(delimiter, StringSplitOptions.None);
        var tempString = parts[1];
        string[] tempStrings = tempString.Split(delimiter2, StringSplitOptions.None);
        Console.WriteLine(tempStrings[0]);

            //Display the results
            //foreach (var part in parts)
            //{
            //    Console.WriteLine(part);
            //}



        }
    } 

}
