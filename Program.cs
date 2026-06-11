Console.Write("Hello, World!");
// cria a variavel variavelQueSalvaUmnumero,
// leia o que o usário digitar 
int variavelQueSalvaUmNumero = int.Parse (Console.ReadLine()!);

// verifica se o valor de variavelQueSalveUmNumero é par 
 if (variavelQueSalvaUmNumero % 2 == 0) 
  {
    Console.WriteLine ($"número {variavelQueSalvaUmNumero} é par ");
  } else {
    Console.WriteLine ($"número {variavelQueSalvaUmNumero} é impar ");
  }
