using ConstructionManager.CrossCutting.AutoMapper;
using ProjetoAula.Infra.Entidade;
using ProjetoAula.Infra.Repositorios;
using ProjetoAula.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.Services
{
    public class LivroService
    {
        private readonly RepositorioLivro _repo = new RepositorioLivro();
        private readonly Mapper _map = new Mapper();

        public IEnumerable<LivroDto> GetLivros()
        {
            return _map.Map<LivroDto>(_repo.GetLivros());
        }

        public void SalvarLivro(LivroDto model)
        {
            if (model.Id > 0) _repo.UpdateLivro(_map.Map<Livro>(model));

            else _repo.AddLivro(_map.Map<Livro>(model));

        }

        public LivroDto GetById(int id)
        {
            return _map.Map<LivroDto>(_repo.GetById(id));
        }

    }
}
