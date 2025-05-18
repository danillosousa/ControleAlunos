using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAlunos.Data
{
    public class Servico
    {
        private readonly SQLiteAsyncConnection _db = DataBase.Instance.Conn;

        public async Task<int> AdicionarAsync(ModeloAluno a)
        {
            a.DataCadastro = DateTime.Today; // carimbo automático
            return await _db.InsertAsync(a);
        }

        public Task<List<ModeloAluno>> ListarAsync() =>
            _db.Table<ModeloAluno>().OrderBy(x => x.Nome).ToListAsync();

        public Task<ModeloAluno?> BuscarPorIdAsync(int id) =>
            _db.FindAsync<ModeloAluno>(id);

        public Task<ModeloAluno?> BuscarPorCpfAsync(string cpf) =>
            _db.Table<ModeloAluno>().FirstOrDefaultAsync(x => x.Cpf == cpf);

        // Novo método para buscar por nome (contendo o texto pesquisado)
        public Task<List<ModeloAluno>> BuscarPorNomeAsync(string nome) =>
            _db.Table<ModeloAluno>()
               .Where(x => x.Nome.ToLower().Contains(nome.ToLower()))
               .OrderBy(x => x.Nome)
               .ToListAsync();

        public Task<int> AtualizarAsync(ModeloAluno a) => _db.UpdateAsync(a);

        public Task<int> ExcluirAsync(ModeloAluno a) => _db.DeleteAsync(a);
    }
}
