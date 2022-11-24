Console.WriteLine("ESCOLHA");
Console.WriteLine("1 para pedra");
Console.WriteLine("2 para papel");
Console.WriteLine("3 para tesoura");

string valueEscolha = "";
string valueMaquina = "";
string resultado = "Início do jogo";
int pontos = 0;

var dictionary = new Dictionary<int, string>
{
   {1, "pedra"},
   {2,"papel"},
   {3,"tesoura"}
};

while (resultado != "Você perdeu!")
{
    string entrada = Console.ReadLine();
    
    if (entrada =="1" || entrada =="2" || entrada =="3"){

    var escolha = int.Parse(entrada);
    var random = new Random();
    var valorMaquina = random.Next(1, 3);
    valueEscolha = dictionary[escolha];

    Console.WriteLine("Você escolheu " + valueEscolha + " e a máquina escolheu " + valueMaquina + ".");

    if (escolha == valorMaquina)
    {
        pontos+=1;
        Console.WriteLine("Empate!");
    }
    else if ((escolha == 1 && valorMaquina == 3) || (escolha == 2 && valorMaquina == 1) || (escolha == 3 && valorMaquina == 2))
    {
        pontos+=3;
        Console.WriteLine("Você ganhou!");
    }
    else
    {
        resultado= "Você perdeu!";
        Console.WriteLine(resultado);
    }
    }
    else {
        Console.WriteLine ("Ops! Que valor é esse?");
    }
}

Console.WriteLine ("GAME OVER");
Console.WriteLine($"Pontos: {pontos}");
    


