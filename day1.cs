using System;
using System.Linq;

int[] list1 = new int[]
{
     27507, 69810, 60448, 92139, 26802, 77131, 11665, 15622, 50472, 31601, 49999, 87160, 58198, 73480, 34374, 56594,
     86225, 41024, 53973, 21336, 68229, 31907, 96121, 91843, 64469, 24945, 38171, 85337, 53614, 33205, 92278, 12348,
     74217, 31880, 40671, 97622, 83858, 54900, 75694, 12808, 22110, 24842, 76019, 29801, 62119, 84085, 97633, 55735,
     37423, 21883, 24725, 94882, 78917, 38963, 58484, 25045, 44549, 96565, 96544, 56476, 93786, 47385, 53003, 34763,

};

int[] list2 = new int[]
{
     18604, 73952, 56269, 61722, 60858, 85480, 30619, 29287, 55227, 15873, 20227, 41386, 25660, 83349, 31670, 81327,
     89142, 80952, 84059, 23710, 32979, 49347, 92108, 55227, 46797, 51234, 20077, 65084, 29287, 92108, 65084, 54841,
     64534, 67672, 61530, 51354, 54841, 29287, 32657, 92108, 45441, 80522, 85395, 55227, 24086, 42315, 50312, 84085,
     24578, 38297, 85063, 96754, 23949, 37984, 54841, 60224, 68472, 28888, 13183, 62216, 36255, 31017, 74502, 90916,

};


Array.Sort(list1);
Array.Sort(list2);


int totalDistance = 0;
for (int i = 0; i < list1.Length; i++);
{
    totalDistance += Math.Abs(list1{i} - list2{i});
}


Console.WriteLine("Die Gesamtstrecke zwischen den Listen ist + totalDistance");