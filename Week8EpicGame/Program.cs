using System.ComponentModel.Design;

string folderPath = @"C:\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = { "Harry Potter", "Luke SkyWalker", "Lara Croft", "Scooby-Doo" };
//string[] villains = { "Spider man", "Batman", "Sauron" };
string[] weapon = { "magin wand", "plastic fox", "banana" };




string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
int heroHP = GetCharacterHP(hero);
Console.WriteLine($"Today {hero} ({heroHP} HP) with {heroWeapon} saves the day!");



if (heroHP > 0)
{
    Console.WriteLine($"{hero} saves the day!");
}
else if (villainHP)> 0)
{
    Console.WriteLine($"Dark side wind!");
}
else
{
    Console.WriteLine("Draw!");
}

string villain = GetRandomValueFromArray(villains); 
string villainWeapon = GetRandomValueFromArray(weapon);
int villainHP = GetCharacterHP(villain);
Console.WriteLine($"Today {villain} {villainHP} HP) with {villainWeapon} tries to take over the world";

while(heroHP > 0 && villainHP > 0)
{
    heroHP = heroHP - Hit(villain, villainHP);
    villainHP = villainHP - Hit(hero, heroHP);
}

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();   
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];  
    return randomStringFromArray;   
}


static int GetCharacterHP(string characterName)
{
    if(characterName.Length < 10)
    {
        return 10;
    }
    else
    {
        return characterName.Length;
    }

}

static int Hit(int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if (strike == 0)
    {
        Console.WriteLine($"{CharacterName} made a hit!");


    }
    else if (strike == characterHP - 1)
    {
        Console.WriteLine($"{charactename}e a critical hit!");
        else
        {
            Console.WriteLine($"{characterName} hit {strike}!");
        }

        return strike;