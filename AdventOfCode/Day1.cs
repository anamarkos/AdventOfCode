using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day1
    {
        public Day1()
        {
            int[] msrmnts = Data.DepthMesurements;

            var myResults = msrmnts.Skip(1)
                .Select((ms, index) => new { ms, index })
                .Where(x => x.ms > msrmnts[x.index])
                .Count();

            int count = 0;
            msrmnts.Select((ms, index) => new {ms,index}).Skip(1).ToList()
                   .ForEach(x => { if (x.ms > msrmnts[x.index - 1]) { count++; } });

            Console.WriteLine(count);
        }
    }
}
