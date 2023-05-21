string sensorT, sensorP, sensorR;

Console.WriteLine("-- Luz de Advertência --");

Console.WriteLine("O sensor de temperatura está ativado? Responda com (S)im ou (N)ão ");
sensorT = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (sensorT != "S" && sensorT != "N")
{
    Console.WriteLine("Valor INVÁLIDO para o Sensor de temperatura! ");
    return;
}

Console.WriteLine("O sensor de pressão está ativado? Responda com (S)im ou (N)ão ");
sensorP = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (sensorP != "S" && sensorP != "N")
{
    Console.WriteLine("Valor INVÁLIDO para o sensor de pressão! ");
    return;
}

Console.WriteLine("O sensor de rotação está ativado? Responda com (S)im ou (N)ão ");
sensorR = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (sensorR != "S" && sensorR != "N")
{
    Console.WriteLine("Valor INVÁLIDO para o sensor de rotação ");
    return;
}

if (sensorT == "S" && sensorP == "S")
{
    Console.WriteLine("A Luz de advertência está ativada! ");
    return;
}

if (sensorT == "S" && sensorR == "N")
{
    Console.WriteLine("A luz de advertência está ativada! ");
    return;
}

else
{
    Console.WriteLine("A Luz de advertência está desativada");
    return;
}

// eu não transformei as strings em bool por achar mais fácil trabalhar com elas assim, porém fiz um "If" específico para cada possibilidade de resposta.