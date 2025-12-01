// https://adventofcode.com/2025/day/1
// Directions can be > 100


var input = File.ReadAllLines("input.txt");
const int MAX_DISTANCE = 100;

// 1132
int Part1()
{
    int dial = 50;
    var counts = 0;

    foreach (var rotation in input)
    {
        var direction = rotation[0] == 'L' ? -1 : 1;
        var distance = int.Parse(rotation[1..]);

        dial += distance * direction;
        dial %= MAX_DISTANCE;

        if (dial < 0) dial += MAX_DISTANCE;
        if (dial == 0) counts++;
    }

    return counts;
}

// 6623
int Part2()
{
    int dial = 50;
    var counts = 0;

    foreach (var rotation in input)
    {
        var direction = rotation[0] == 'L' ? -1 : 1;
        var clicks = int.Parse(rotation[1..]);
        var toZero = direction == 1 ? MAX_DISTANCE - dial : dial;

        if (toZero > 0 && clicks >= toZero) counts++;

        counts += (clicks - toZero) / MAX_DISTANCE;

        dial += direction * clicks;
        dial %= MAX_DISTANCE;
        if (dial < 0) dial += MAX_DISTANCE;
    }

    return counts;
}


Console.WriteLine(Part1());
Console.WriteLine(Part2());