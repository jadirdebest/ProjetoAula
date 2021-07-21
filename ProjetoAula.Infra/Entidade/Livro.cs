﻿using ConstructionManager.CrossCutting.AutoMapper.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.Infra.Entidade
{
    public class Livro
    {
        [SourceMember("Id")]
        public int Id { get; set; }

        [SourceMember("Titulo")]
        public string Titulo { get; set; }

        [SourceMember("ISBN")]
        public string ISBN { get; set; }

        [SourceMember("DataPublicacao")]
        public DateTime DataPublicacao { get; set; }

        [SourceMember("Ativo")]
        public bool Ativo { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
