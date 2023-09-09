// See https://aka.ms/new-console-template for more information
using BoatsToASavePpl;

Console.WriteLine("minimum Boats required to carry no.of people. Boat having a carrying capacity and sitting capacity.");

BoatsToSavePpl boats = new BoatsToSavePpl();
int count = boats.MinBoatsWithCapacity(new int[] { 3,2,2,1}, 3);

Console.WriteLine($"No. Of boats required: {count}");
Console.ReadKey();
