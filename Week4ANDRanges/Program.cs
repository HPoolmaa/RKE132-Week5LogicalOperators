// Kasutaja sisestab õhutemperatuuri
// Programm tuvastab väärtuse ning vastab kasutajale vastavalt temperatuurile, et kas temp on külm, jahe, soe, kuum, või lõõmav;
// väärtused:
// temp <= 0 - Freezing cold
// temp >0 AND temp <= 10 - cold
// temp >10 AND temp <= 15 - chilly
// temp >15 AND temp <= 20 - warm
// temp >20 AND temp <= 30 - hot
// temp <= 30 - boliling hot

Console.WriteLine("Enter the temperature (C'):");
int temp = Int32.Parse(Console.ReadLine());
if (temp >= 30)
{
    Console.WriteLine("It's boiling hot outside, remember to drink lots of water and keep to the shadows!");
}
else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("It's hot outside, enjoy the day and remember to take some breaks in the shadow!");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("It's pretty warm outside, but remember to bring a jacket!");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("It's chilly outside, take something warm with you!");
}
else if (temp < 10 && temp >= 0)
{
    Console.WriteLine("It's cold outside, put something warm on!");
}
else if (temp <= 0)
{
    Console.WriteLine("It's freezing outside, go inside to warm up once in a while.");
}