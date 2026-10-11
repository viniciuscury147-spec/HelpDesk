using HelpDesk.Core.Models;

var Chamado = new Chamado

{
        Id = 1,
        Titulo = "Bloqueio de senha",
        Descricao = "Errei a senha mais de 3 vezes",
        Prioridade = Prioridade.Baixa,
        DataAbertura = DateTime.Now,
        Solicitante = "Gabriel",
        DataFechado = null,
        Status = Status.Aberto,
        TecnicoResponsavel = null



};

Chamado.AtribuirTecnico("Carlos");
Chamado.FecharChamado();

Console.WriteLine("=============================");
Console.WriteLine(Chamado.Id);
Console.WriteLine(Chamado.Titulo);
Console.WriteLine(Chamado.Descricao);
Console.WriteLine(Chamado.Prioridade);
Console.WriteLine(Chamado.DataAbertura);
Console.WriteLine(Chamado.Solicitante);
Console.WriteLine(Chamado.DataFechado?.ToString() ?? "Sem prazo");
Console.WriteLine(Chamado.TecnicoResponsavel ?? "Sem tecnico");
Console.WriteLine(Chamado.Status);
Console.WriteLine("=============================");
