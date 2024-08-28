//Testar APIs
// - Rest Client -  Extensão do VS Code
// - Postman
// - Insomnia
//Minimal APIs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades
//Configurar a URL e o método/verbo
app.MapGet("/", () => "Hello World em C#");

app.MapGet("/segundafuncionalidade", () => "Função 2 da API");

app.MapGet("/retornarendereco", () => 
{
    dynamic endereco = new {
        rua = "Parigot de Souza",
        numero = 5300,
        cep = "81290-350"
    };
    return endereco;
});

app.Run();
