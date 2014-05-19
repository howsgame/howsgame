using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace Howsgame.Repositorio
{

	   
		public abstract class Banco
		{   
			public abstract string ObterStringConexao();

			private IDbConnection ObterConexao()
			{
				IDbConnection conexao;

						conexao = new SqlConnection(ObterStringConexao());
						conexao.Open();

			return conexao;
			}


			public int ExecutarScalar(string consulta, object parametros = null, CommandType tipoComando = CommandType.Text,
				bool comBuffer = true)
			{

				var conexao = ObterConexao();

				try
				{
					return conexao.Execute(consulta, parametros, commandType: tipoComando);
				}
				finally
				{
					conexao.Dispose();
				}
			}

			public IEnumerable<T> Pesquisar<T>(string consulta, object parametros = null, CommandType tipoComando = CommandType.Text, bool comBuffer = true)
			{
				IEnumerable<T> resultado;

				var conexao = ObterConexao();

				try
				{
					resultado = conexao.Query<T>(consulta, parametros, buffered: comBuffer, commandType: tipoComando).ToList();

				}
				finally
				{
											conexao.Dispose();
				}

				return resultado;
			}

			public T Obter<T>(string consulta, object parametros = null, CommandType tipoComando = CommandType.StoredProcedure)
			{
				T resultado;

				var conexao = ObterConexao();

				try
				{
					resultado = conexao.Query<T>(consulta, parametros, buffered: false, commandType: tipoComando).FirstOrDefault();
				}
				finally
				{
					conexao.Dispose();
				}

				return resultado;
			}

			public T Executar<T>(string procedimento, object parametros)
			{
				return Obter<T>(procedimento, parametros);
			}

			public void Executar(string procedimento, object parametros, CommandType tipoComando = CommandType.Text)
			{
				var conexao = ObterConexao();

				try
				{
					conexao.Execute(procedimento, parametros, commandType: tipoComando);
				}
				finally
				{
					
						conexao.Dispose();
				}
			}
		}
}

