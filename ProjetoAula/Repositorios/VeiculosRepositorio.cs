using Dapper;
using ProjetoAula.Conexao;
using ProjetoAula.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoAula.Repositorios
{
    public class VeiculosRepositorio
    {
        public IEnumerable<CarroViewModel> GetVeiculos()
        {
            using (var conn = new SqlConnection(StringConexao.SqlConnectionString))
            {
                conn.Open();

                //USANDO DAPPER
                return conn.Query<CarroViewModel>("select * from Veiculos");
            }
        }

        public void InsertVeiculo(CarroViewModel model)
        {
            using (var conn = new SqlConnection(StringConexao.SqlConnectionString))
            {
                conn.Open();

                //USANDO DAPPER
                conn.Execute("insert into Veiculos(Modelo,Cor,AnoFabricacao,AnoModelo,DataCriacao) values(@Modelo,@Cor,@AnoModelo,@AnoFabricacao,sysdatetime())", model);
            }
        }

    }
}
