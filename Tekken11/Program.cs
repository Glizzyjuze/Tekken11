string Text(string text, bool shouldClear)
{
    if(shouldClear){
        Console.Clear();
    }
    
    Console.WriteLine(text);
    string userInput = Console.ReadLine();
    return userInput;
}

int hp = 100;
int enemyHp = 250;
int energy = 0;
Random generator = new Random();

Console.WriteLine("What is your name");
string name;
name = Console.ReadLine();

Text($"Welcome to the arena, {name}", true);

Console.WriteLine("what is the enemy's name?");
string enemyName;
enemyName = Console.ReadLine();

Text($"On one side we have {name}, on the other side is {enemyName}", true);

int punch = 18;
int kick = 20;
int grab = 10;
int ultimateMove = 180;
int round = 1;
int roundNumber = 1;

while (hp > 0 || enemyHp > 0)
{
    if (hp < 1)
    {
        Text($"The winner is {enemyName}!", true);
    }

    if (enemyHp < 1)
    {
        Text($"The winner is {name}!", true);
    }

    else
    {
        int result = generator.Next(2);
        
        if (round == 1) 
        {
            Text($"Round {roundNumber}", true);
            
            if (result == 0)
            {
                enemyHp = enemyHp - punch;
                energy = energy + 33;
                Text($"{name} used punch. {enemyName} lost 18 hp", true);
                Text($"{enemyName}'s hp: {enemyHp}", false);
                round = round -1;
                roundNumber = roundNumber +1;
            }
            
            if (result == 1)
            {
                enemyHp = enemyHp - kick;
                energy = energy + 20;
                Text($"{name} used kick. {enemyName} lost 20hp", true);
                Text($"{enemyName}'s hp: {enemyHp}", false);
                round = round -1;
                roundNumber = roundNumber +1;
            }
            
            if (result == 2)
            {
                enemyHp = enemyHp - grab;
                energy = energy + 50;
                Text($"{name} grabbed {enemyName}, {enemyName} lost 10 hp", true);
                Text($"{enemyName}'s hp: {enemyHp}", false);
                round = round -1;
                roundNumber = roundNumber +1;
            }
            
            if (energy > 99)
            {
                enemyHp = enemyHp - ultimateMove;
                energy = 0;
                Text($"{name} became enraged. Lightning started flickering from their skin. {name} lunged forward at lightingspeed and hit {enemyName} with a Thundering Punch!", true);
                Text($"{enemyName} took 180 damage!", false);
                Text($"{enemyName}'s hp: {enemyHp}", false);
            }
        }
        
        if (round < 1)
        {
            int result2 = generator.Next(2);
            
            Text($"Round {roundNumber}", true);
            
            if (result2 == 0)
            {
                hp = hp - (punch + 5);
                Text($"{enemyName} used punch. {name} lost 23 hp", true);
                Text($"{name}'s hp: {hp}", false);
                round = round +1;
                roundNumber = roundNumber +1;
            }
            
            if (result2 == 1)
            {
                hp = hp - (kick + 5);
                Text($"{enemyName} used kick. {name} lost 25 hp", true);
                Text($"{name}'s hp: {hp}", false);
                round = round +1;
                roundNumber = roundNumber +1;
            }
            
            if (result2 == 2)
            {
                hp = hp - (grab + 5);
                Text($"{enemyName} used grab. {name} lost 15 hp", true);
                Text($"{name}'s hp: {hp}", false);
                round = round +1;
                roundNumber = roundNumber +1;
            }
        }
    } 
}

while(1!=2)
{

}