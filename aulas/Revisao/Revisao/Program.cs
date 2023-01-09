// See https://aka.ms/new-console-template for more information

//Valores de entrada 
int anoNascimento = 1985;

//Tratamento dos dados 

List<int> VerificaIdade(List<int> anoNascimento)
{
    var result = new List<int>();
	foreach (var item in anoNascimento.ToList())
	{
        if (item != 0)
            result.Add(DateTime.Now.Year - item);
    }

    return result;
}

//Armazenamento dos dados 




Console.WriteLine("Hello, World!");

Console.ReadLine();
