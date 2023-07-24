bool a = true;
bool b = false;

static bool DoStuff() {
    WriteLine("I am doing stuff");
    return true;
}

WriteLine();
WriteLine($"a & DoStuff = {a & DoStuff()}");
WriteLine($"b & DoStuff = {b & DoStuff()}");

WriteLine();
WriteLine($"a && DoStuff() = {a && DoStuff()}");
WriteLine($"b && DoStuff() = {b && DoStuff()}");