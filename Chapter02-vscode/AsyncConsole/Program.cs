// HttpClient client = new();
// HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");

// WriteLine($"Apple's website has {response.Content.Headers.ContentLength} bytes.");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
format: "{0,-10} {1,-7}",
arg0: "Name",
arg1: "Count");

WriteLine(
format: "{0,-10} {1,-7:N0}",
arg0: applesText,
arg1: applesCount);

WriteLine(
format: "{0,-10} {1,-7:N0}",
arg0: bananasText,
arg1: bananasCount);