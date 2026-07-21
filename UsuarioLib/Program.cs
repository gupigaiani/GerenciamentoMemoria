using System.Diagnostics;
using UsuarioLib;

// Usuario usuario = 
//     new Usuario(
//         "Daniel", 
//         "daniel@email.com",
//         new List<string>() {"12345678"});

// //12345678
// usuario.ExibeTelefones();

// //efetuar a padronização
// usuario.PadronizaTelefones();

// //912345678
// usuario.ExibeTelefones();

// Stopwatch sw = new Stopwatch();

// sw.Start();

// for (int i = 0; i < 1000000000; i++)
// {
//     Coordenada coordenada = new Coordenada(123.456, -123.456);
//     var latitude = coordenada.Latitude;
//     var longitude = coordenada.Longitude;
// }

// sw.Stop();

// Console.WriteLine($"Tempo total em ms: {sw.Elapsed.TotalMilliseconds}");

FormularioDto dto = new FormularioDto("Gustavo", "12345678900", "Desenvolvedor") { Idade = 99 };
dto.Idade = 100;

Console.WriteLine($"Valor do nome: {dto.Nome}");

// FormularioDto dto2 = new FormularioDto();
// dto2.Nome = "Gustavo";
// dto2.Idade = 20;
// dto2.Cargo = "Desenvolvedor";
// dto2.Cpf = "12345678900";

// Console.WriteLine(dto == dto2);