// See https://aka.ms/new-console-template for more information

HttpClient client = new HttpClient();

string responseBody = await client.GetStringAsync("http://localhost:8080/Incr?param1=5");
Console.WriteLine(responseBody);
