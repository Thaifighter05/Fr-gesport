Console.WriteLine("Välkommen till Maxis frågesport vid namn Idioten");
Console.ReadLine();

int point = 0;

Console.WriteLine("Hej tävlare vad är ditt namn?");
string name = Console.ReadLine();
name = name.ToLower();

Console.WriteLine($"{name} tror du att du har vad som krävs för att klara idioten?");
Console.ReadLine();

Console.WriteLine("Vi får väl se här på Idioten");
Console.ReadLine();

Console.WriteLine("Första frågan, Vilken är den bästa single player spelet?");

Console.WriteLine("a. assasin's creed b. Sekiro c. Elden ring d. the witcher");
string answer = Console.ReadLine();



if (answer == "c")
{
    Console.WriteLine("Grattis, det var rätt svar");

    point = point + 1;
    Console.WriteLine($"Du har {point} poäng");
}
else if (answer != "c")
{
    Console.WriteLine("Fel svar, din smak på spel är sämst");
}
Console.ReadLine();

Console.WriteLine("Fråga 2, Vilken är den bästa karaktären i serien the boys?");

Console.WriteLine("a. Billy Butcher b. Homelander c. Hughie Campbell d. A-train");

answer = Console.ReadLine();

if (answer == "b")
{
    Console.WriteLine("Your smarter, Your stronger, You are better, YOU ARE BETTER!!!");

    point = point + 1;
    Console.WriteLine($"Du har {point} poäng");
}
else if (answer != "b")
{
    Console.WriteLine("Your weaker, Your dumber, You are worse, YOU ARE WORSE!!!");
}
Console.ReadLine();

Console.WriteLine("Den sista frågan nu, Vilken är den bästa villain i Marvel universe?");
Console.WriteLine("a. Kang b. Galactus c. dr.doom d.Thanos");

answer=Console.ReadLine();


if (answer == "c")
{

    Console.WriteLine("You are inevitable");
    point = point + 1;
    Console.WriteLine($"Du har {point} poäng");
}

else if (answer != "c")
{
    Console.WriteLine("you got wiped out");
}
    Console.ReadLine();
    Console.WriteLine("Frågesportet är slut");

    Console.WriteLine($"Du fick totalt {point} poäng");
    Console.ReadLine();



