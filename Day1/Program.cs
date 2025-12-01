// https://adventofcode.com/2025/day/1
// Directions can be > 100


var input = File.ReadAllLines("input.txt");

int Part1()
{
    int dial = 50;
    var counts = 0;

    foreach (var rotation in input)
    {
        var direction = rotation[0];
        var distance = int.Parse(rotation[1..]) % 100;

        if (direction == 'L')
        {
            dial -= distance;

            if (dial < 0)
            {
                dial += 100;
            }
        }
        else
        {
            dial += distance;

            if (dial > 99)
            {
                dial -= 100;
            }
        }

        if (dial == 0)
        {
            counts++;
        }
    }

    return counts;
}


int Part2()
{
    int dial = 50;
    var counts = 0;

    foreach (var rotation in input)
    {
        var direction = rotation[0];
        var distance = int.Parse(rotation[1..]);

        while (distance > 100)
        {
            distance -= 100;
            counts++;
        }

        if (direction == 'L')
        {
            dial -= distance;

            if (dial < 0)
            {
                dial += 100;
                counts++;
            }
        }
        else
        {
            dial += distance;

            if (dial > 99)
            {
                dial -= 100;
                counts++;
            }
        }
        
    }

    return counts;
}


Console.WriteLine(Part1());
Console.WriteLine(Part2());