using System;
using Howsgame.Dominio;

namespace Howsgame.Repositorio
{
	public class GameRepositorio:RepositorioBase
	{
		public GameRepositorio ()
		{

		}
		/*public void Adicionar(Game game)
			{

				Executar<int> ("Insert Game(Nome,Release,categoriaID,plataformaID,avaliadorID) values(@Nome,@Release,@categoriaID,@plataformaID,@avaliadorID)", 
					new{game.Nome,game.Release,game.Categoria.Id,game.Plataforma.Id,game.Avaliador.Id});

			}
			public void Atualizar(Game game)
			{
				Executar<int> ("Update Game set Nome = @Nome,Release = @release ,categoriaID= @categoriaID,plataformaID = @plataformaID,avaliadorID = @avaliadorID",
					new{game.Nome,game.Release,game.Categoria.Id,game.Plataforma.Id,game.Avaliador.Id});
			}*/
	}
}

