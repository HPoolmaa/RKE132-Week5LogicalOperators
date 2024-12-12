// teh. ülesanne;
// Ülikool võtab õpilased vastu meistri programmi vastavalt tulemustele erinevates ainetes
// Programm küsib kasutajalt tema tulemusi
// nõutud: math >=90; biology >=90; chemistry >=90;
// Programm teavitab kasutajat kas kriteeriumid on täidetud

int math, biology, chemistry;

Console.WriteLine("Enter your math results");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology results");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry results");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations, you are eligible for enrollment in the masters program!");
}
else
{
    Console.WriteLine("We are sorry to inform you that you are not eligible for enrollment in the masters program");
}