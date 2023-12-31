﻿int a = 10;
int b = 6;

WriteLine($"a & b = {a & b}");
WriteLine($"a | b = {a | b}");
WriteLine($"a ^ b = {a ^ b}");
WriteLine();

// 01010000 left-shift a by three bit columns
WriteLine($"a << 3 = {a << 3}");
// multiply a by 8
WriteLine($"a * 8 = {a * 8}");
// 00000011 right-shift b by one bit column
WriteLine($"b >> 1 = {b >> 1}");

WriteLine();

WriteLine("Outputting integers as binary:");
WriteLine($"a =     {ToBinaryString(a)}");
WriteLine($"b =     {ToBinaryString(b)}");
WriteLine($"a & b = {ToBinaryString(a & b)}");
WriteLine($"a | b = {ToBinaryString(a | b)}");
WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");

static string ToBinaryString(int value) {
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}