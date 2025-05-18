using SQLite;
using System.IO;
using System.Threading.Tasks;

namespace ControleAlunos.Data
{
    public sealed class DataBase
    {
        private static readonly Lazy<DataBase> lazy =
            new(() => new DataBase());
        public static DataBase Instance => lazy.Value;

        private const string DbFile = "ControleAlunos.db3";

        /// <summary>Caminho completo do arquivo .db3.</summary>
        public string CaminhoBanco { get; }

        /// <summary>Conexão SQLite assíncrona.</summary>
        public SQLiteAsyncConnection Conn { get; private set; }

        private DataBase()
        {
            var pasta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ControleAlunos");

            Directory.CreateDirectory(pasta);
            CaminhoBanco = Path.Combine(pasta, DbFile);

            Conn = new SQLiteAsyncConnection(CaminhoBanco);
        }

        /// <summary>Cria a tabela se não existir.</summary>
        public Task InitAsync() =>
            Conn.CreateTableAsync<ModeloAluno>();

        /// <summary>Fecha a conexão (se aberta), recria o arquivo e a tabela.</summary>
        public async Task RecriarBancoAsync()
        {
            await Conn.CloseAsync();          // garante que ninguém use o arquivo

            if (File.Exists(CaminhoBanco))
                File.Delete(CaminhoBanco);

            // reabre a conexão e recria a tabela
            Conn = new SQLiteAsyncConnection(CaminhoBanco);
            await Conn.CreateTableAsync<ModeloAluno>();
        }
    }
}
