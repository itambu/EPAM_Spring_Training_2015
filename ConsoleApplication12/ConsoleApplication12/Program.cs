using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    namespace RailTransport 
7 { 
8     public class Train : ITrain 
9     { 
10         public string Number { get; } 
11         private ICollection<IRailwayElement> _train; 
12 
       
 
13         public Train(ICollection<IRailwayElement> source,string number) 
14         { 
15              _train = source;
                Number = number; 
16         } 
17 
           
 
18         public ICollection<IRailwayElement> GetTrainConsist() 
19         { 
20             return _train; 
21         } 
22 
 
23         public void AddRailwayElement(IRailwayElement railwayElement) 
24         { 
25             _train.Add(railwayElement); 
26         } 
27 
 
28         public int GetOverallNumberOfPassengers() 
29         { 
30             int passengerCapacity = 0; 
31 
 
32             foreach (var railwayElement in _train) 
33             { 
34                 if (railwayElement is IHasPassenger) 
35                 { 
36                     passengerCapacity += ((IHasPassenger)railwayElement).PassengerCount; 
37                 } 
38             } 
39             return passengerCapacity; 
40         } 
41 
 
42         public double GetOverallVolumeOfLuggage() 
43         { 
44             double luggageVolume = 0; 
45             foreach (var railwayElement in _train) 
46             { 
47                 if (railwayElement is IHasLuggage) 
48                 { 
49                     luggageVolume += ((IHasLuggage)railwayElement).Filling; 
50                 } 
51             } 
52             return luggageVolume; 
53         } 
54 
 
55         //public void SortWagonsByComfortLevel() 
56         //{ 
57         //    List<PassengerCarriage> trainTemp = new List<PassengerCarriage>(); 
58 
 
59         //    foreach (var railwayElement in _train) 
60         //    { 
61         //        if (railwayElement is PassengerCarriage) 
62         //        { 
63         //            trainTemp.Add((PassengerCarriage)railwayElement); 
64         //        } 
65         //    } 
66 
 
67         //    _train.RemoveAll(railwayElement => railwayElement is PassengerCarriage); 
68              
69         //    trainTemp.Sort( (railwayElement1, railwayElement2) => (railwayElement1.ComfortLevel.CompareTo(railwayElement2.ComfortLevel)) ); 
70 
 
71         //    _train.AddRange(trainTemp); 
72         //} 
73 
 
74         public void SortWagonsByComfortLevel() 
75         { 
76             var railwayElementWitoutPassenger = _train.Where(x => !(x is IHasPassenger)); 
77             var passengerRailwayElement = _train.Where(x => x is IHasPassenger) 
78                                                 .OrderBy(x => ((IHasPassenger)x).ComfortLevel); 
79             var temp = railwayElementWitoutPassenger.Concat(passengerRailwayElement) 
80                                                     .ToList(); 
81             _train = temp; 
82         } 
83 
 
84         public ICollection<IRailwayElement> GetWagonsInRangeNumberOfPassenger(int minNumberPassenger, int maxNumberPassenger) 
85         { 
86             var wagonsInRangeNumberOfPassenger = _train.Where(x => x is IHasPassenger) 
87                                                        .Where(x => ((IHasPassenger)x).PassengerCount >= minNumberPassenger) 
88                                                        .Where(x => ((IHasPassenger)x).PassengerCount <= maxNumberPassenger) 
89                                                        .ToList(); 
90             return wagonsInRangeNumberOfPassenger; 
91         } 
92     } 
93 } 

}
