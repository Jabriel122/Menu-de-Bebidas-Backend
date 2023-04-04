// Entrada

Console.WriteLine(@$"
-------------------------------------------
|           Menu de bebidas               |
|                                         |
|   1 - Uisque                            |
|   2 - Gin                               |
|   3 - Vodka                             |
|   4 - Danone                            |
|   5 - Dollynho                          |          
|   6 - Guarana-jesus                     |
|                                         |
-------------------------------------------
");

Console.WriteLine($"Escolha a bebida que você quer usando os numeros");

byte bebida = byte.Parse(Console.ReadLine());

switch (bebida)
{
    case 1:
        Console.WriteLine($"Gostaria de por gelo na sua bebida");
        string es1 = Console.ReadLine(). ToLower();
        if ( es1 == "sim")
        {
            Console.WriteLine($"Aqui sua bebida com gelo");
        }
        else
        {
            Console.WriteLine($"Aqui sua bebida sem gelo");
        }
        break;
    case 2:
        Console.WriteLine($"Gostaria de por gelo na sua bebida");
        string es2 = Console.ReadLine(). ToLower();
        if(es2 == "sim")
        {
            Console.WriteLine($"Aqui sua bevida com gelo");
            
            
        }
        else
        {
            Console.WriteLine($"Aqui sua bebida sem gelo");
        }
        break;
    case 3:
        Console.WriteLine($"Gostaria de por gelo na sua bebida");
        string es3 = Console.ReadLine(). ToLower();

        if(es3 == "sim")
        {
           Console.WriteLine($"Aqui sua bebida com gelo");
            
        }
        else
        {
            Console.WriteLine($"Aqui sua bebida sem gelo");
            
            
        }
        break;
    case 4:
        Console.WriteLine($"Gostaria de por gelo no seu DANONE??");
        string es4 = Console.ReadLine(). ToLower();

        if(es4 == "sim")
        {
        Console.WriteLine($"Aqui seu DANONE???? COM GELO????");
        }
        else 
        { 
        Console.WriteLine($"Aqui seu DANONE????");   
        }
        break;
    case 5:
        Console.WriteLine($"Gostaria de por gelo na sua bebida");
        string es5 = Console.ReadLine(). ToLower();

        if(es5 == "sim")
        {
        Console.WriteLine($"Aqui sua bebida com gelo");
        
            
        }
        else
        {
            Console.WriteLine($"Aqui sua bebida sem gelo"); 
        }
        break;
    case 6:
        Console.WriteLine($"Gostaria de por gelo na sua bebida");
        string es6 = Console.ReadLine(). ToLower();

        if(es6 == "sim")
        {
            Console.WriteLine($"Aqui Sua bebida com gelo");
            
        }
        else
        {
            Console.WriteLine($"Aqui sua bebida");
        }
        break;
}