// teh. ülesanne:
// Ülikool võtab juunior programmi õpilased vastu vastavalt tulemustele erinevates ainetes
// Programm küsib kasutajalt tema tulemusi
// nõutud: math >=90 ja chemistry >=90 või biology >=90;
// Programm teavitab kasutajat kas kriteeriumid on täidetud

int math1, biology1, chemistry1;

Console.WriteLine("Enter your math results");
math1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology results");
biology1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry results");
chemistry1 = Int32.Parse(Console.ReadLine());

if ((math1 >= 90 && chemistry1 >= 90) || (math1  >= 90 && biology1 >= 90) || (chemistry1 >= 90 && biology1 >= 90))
{
    Console.WriteLine("Congratulations, you are eligible for enrollment in the junior program!");
}
else
{
    Console.WriteLine("We are sorry to inform you that you are not eligible for enrollment in the junior program");
}