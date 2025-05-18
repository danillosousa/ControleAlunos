using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAlunos.Data
{
    public class ModeloAluno
    {
        [PrimaryKey, AutoIncrement] public int IdAluno { get; set; }
        [Indexed, SQLite.NotNull] public string Nome { get; set; } = null!;
        [Unique, SQLite.NotNull] public string Cpf { get; set; } = null!;
        [SQLite.NotNull] public DateTime DataNasc { get; set; }
        [SQLite.NotNull] public string Telefone { get; set; } = null!;
        [SQLite.NotNull] public string Endereco { get; set; } = null!;
        [SQLite.NotNull] public string Numero { get; set; } = null!;
        [SQLite.NotNull] public string Bairro { get; set; } = null!;
        [SQLite.NotNull] public string Cidade { get; set; } = null!;
        [SQLite.NotNull] public string NomeMae { get; set; } = null!;
        [SQLite.NotNull] public string NomePai { get; set; } = null!;
        [SQLite.NotNull] public DateTime DataCadastro { get; set; }
    }
}
