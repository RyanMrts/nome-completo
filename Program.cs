string nome;
Console.WriteLine("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;
Console.WriteLine($"{nome}, Digite seu segundo nome: ");
string sobrenome;
sobrenome = Console.ReadLine()!;
string nomecompleto;
nomecompleto = $"{nome} {sobrenome}";
Console.WriteLine($"Nome completo: {nomecompleto }");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");



