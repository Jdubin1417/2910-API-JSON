using API_and_JSON;
using System.Text.Json;



string jsonString = "";

var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();

var file = root + "/grocery.json";

using(StreamReader sw = new StreamReader(file))
{
    jsonString = sw.ReadToEnd();
}

var g = JsonSerializer.Deserialize<Grocery>(jsonString);
Console.WriteLine(g);


///////////////////////////////////////////////////////////////////////////////////////
///GOOGLE BOOKS API
///////////////////////////////////////////////////////////////////////////////////////

var requestPath = "https://www.googleapis.com/books/v1/volumes/xeIoDwAAQBAJ";
var client = new HttpClient();
var request = client.GetAsync(requestPath).Result;

string bookJsonString = await request.Content.ReadAsStringAsync();

//Console.WriteLine(bookJsonString);

var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var book = JsonSerializer.Deserialize<Book>(bookJsonString, options);
Console.WriteLine(book.VolumeInfo);