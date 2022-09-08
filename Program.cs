Console.Title = "Calculadora de Salário";

double salario, salarioMinimo, qntSalario;

string[] frase = new string[22];
frase[0] = "C";
frase[1] = "a";
frase[2] = "l";
frase[3] = "c";
frase[4] = "u";
frase[5] = "l";
frase[6] = "a";
frase[7] = "d";
frase[8] = "o";
frase[9] = "r";
frase[10] = "a";
frase[11] = " ";
frase[12] = "d";
frase[13] = "e";
frase[14] = " ";
frase[15] = "S";
frase[16] = "a";
frase[17] = "l";
frase[18] = "á";
frase[19] = "r";
frase[20] = "i";
frase[21] = "o";

Console.SetCursorPosition(5, 2);
Console.WriteLine("╔");
Console.SetCursorPosition(37, 2);
Console.WriteLine("╗");
Console.SetCursorPosition(5, 3);
Console.WriteLine("║                               ║");
Console.SetCursorPosition(5, 4);
Console.Write("╠");
Console.SetCursorPosition(37, 4);
Console.Write("╣");
Console.SetCursorPosition(5, 12);
Console.WriteLine("╚");
Console.SetCursorPosition(37, 12);
Console.WriteLine("╝");
for(int i = 0; i <= 30; i++){
    Console.SetCursorPosition(i+7,3);
    Console.SetCursorPosition(i+6,4);
    Console.Write("═");
    Console.SetCursorPosition(i+6,2);
    Console.Write("═");        
    Console.SetCursorPosition(i+6,12);
    Console.Write("═");
    Thread.Sleep(100);
}

for(int i = 0; i <= 6; i++){
    Console.SetCursorPosition(5, i+5);
    Console.WriteLine("║                               ║");
    Thread.Sleep(100);
}

for (int i = 0; i <= 21; i++){
    
    Console.SetCursorPosition(i+9,3);
    Console.Write(frase[i]);
    Thread.Sleep(100);
}

Console.SetCursorPosition(6, 5);
Console.WriteLine("Digite salário mínimo vigente:");
Console.SetCursorPosition(6, 6);
salarioMinimo = Convert.ToDouble(Console.ReadLine());
Console.SetCursorPosition(6, 7);
Console.WriteLine("Digite seu salário atual:");
Console.SetCursorPosition(6, 8);
salario = Convert.ToDouble(Console.ReadLine());

qntSalario = salario/salarioMinimo;

Console.SetCursorPosition(6, 9);
Console.WriteLine($"Você ganha {qntSalario:N2} salario(s).");

Console.SetCursorPosition(6, 10);
Console.WriteLine("Pressione uma tecla p/ sair...");
Console.SetCursorPosition(0, 13);
Console.ReadKey();
Console.SetCursorPosition(6, 11);
Console.WriteLine("Obrigado! FATEC 2022/2");