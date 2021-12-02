// See https://aka.ms/new-console-template for more information

using AdventOfCode;

//Day 1 Part2
int[] msrmnts = Data.DepthMesurements;
List<int> chunkSums = new();

int index = 0;
int chunkRemains = msrmnts.Length % 3;

while (true)
{
    if(index < msrmnts.Length - chunkRemains)
    {
        int sum = 0;

        for (int i = index; i < index + 3; i++)
        {
            sum += msrmnts[i++];
        }

        chunkSums.Add(sum);
        index++;
    }
    else
    {
        break;
    }
    
}

int countIn = 0;
int countDe = 0;
int countNc = 0;

chunkSums.Select((mSum, index) => new { mSum, index }).Skip(1).ToList()
       .ForEach(x => { if (x.mSum > chunkSums[x.index - 1]) { countIn++; } });

chunkSums.Select((mSum, index) => new { mSum, index }).Skip(1).ToList()
.ForEach(x => { if (x.mSum < chunkSums[x.index - 1]) { countDe++; } });

chunkSums.Select((mSum, index) => new { mSum, index }).Skip(1).ToList()
       .ForEach(x => { if (x.mSum == chunkSums[x.index - 1]) { countNc++; } });

Console.WriteLine(countIn);



//not 528
//not 1416

