Double nota1, nota2, nota3, media;
Console.WriteLine("Media Aritmetica de 3 numeros\n");

Console.WriteLine("Digite o primeiro número..:");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo número..:" );
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o terceiro número..:");
nota3 = Convert.ToDouble(Console.ReadLine()); 

media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine ($"\nMedia: {media:N1}");
