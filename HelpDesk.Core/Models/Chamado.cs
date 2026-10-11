namespace HelpDesk.Core.Models;

public class Chamado // Classe que define todas as informações do chamado.
{
    public int Id { get; set; }
    public DateTime DataAbertura { get; set; }
    public DateTime? DataFechado { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Prioridade Prioridade { get; set; }
    public Status Status { get; set; }
    public string Solicitante { get; set; } = string.Empty;
    public string? TecnicoResponsavel { get; set; }


    public void AtribuirTecnico(string nomeDoTecnico)
    {
        if (Status == Status.Finalizado)
        {
            throw new InvalidOperationException("Não é possivel atribuir um tecnico a um chamado fechado.");
        }

        if (string.IsNullOrWhiteSpace (nomeDoTecnico))
        {
            throw new ArgumentException("Necessario atribuir tecnico");
        }

        TecnicoResponsavel = nomeDoTecnico;
        Status = Status.EmAndamento;


    }


    public void FecharChamado()
    {
        if (Status == Status.Finalizado)
        { 
            throw new InvalidOperationException("O chamado já está finalizado");
        }

        DataFechado = DateTime.Now;
        Status = Status.Finalizado;
    }

}