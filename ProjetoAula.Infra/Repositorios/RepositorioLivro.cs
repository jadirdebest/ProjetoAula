using ProjetoAula.Infra.Entidade;
using ProjetoAula.Infra.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.Infra.Repositorios
{
    public class RepositorioLivro
    {
        private DataCore<Livro> _context = new DataCore<Livro>();


        public Livro AddLivro(Livro model)
        {
            var query = @"insert into Livro(Titulo,ISBN,DataPublicacao,Ativo,CreatedOn)
                          values(@Titulo,@ISBN,@DataPublicacao,1,sysdatetime())";

            _context.Execute(query, model);
            
            return model;
        }
        public IEnumerable<Livro> GetLivros()
        {
            var query = "select * from Livro";

            return _context.Query(query);
        }
        public Livro GetById(int id)
        {
            var query = "select * from Livro where Id = @Id";

            return _context.Query(query, new { Id = id }).FirstOrDefault();
        }
        public void UpdateLivro(Livro model)
        {
            var query = @"update Livro 
                        set Titulo = @Titulo, ISBN = @ISBN, DataPublicacao = @DataPublicacao, Ativo = @Ativo, UpdatedOn = sysdatetime()
                        where Id = @Id";

            _context.Execute(query, model);
        }

    }
}
