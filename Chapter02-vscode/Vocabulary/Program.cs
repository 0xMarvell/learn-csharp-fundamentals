double heightInMeters = 3.88;

Console.WriteLine($"The variable {nameof(heightInMeters)} has a value of {heightInMeters} meters.");

char letter = 'X';
string name = "Marvell";
string eeee = new('e', count:20);

Console.WriteLine($"{letter}\n{name}\n{eeee}");

var person = new { FirstName = "Alice", Age = 56 };
string json = $$"""
                    {
                        "first_name": "{{person.FirstName}}",
                        "age": {{person.Age}},
                        "calculation", "{{{1 + 2}}}"
                    }
                """;
Console.WriteLine(json);