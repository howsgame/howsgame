using System;
using System.Collections.Generic;

namespace Howsgame.Dominio
{
	public interface IGameRepositorio
	{
		void Adicionar (Game game);

		void Atualizar (Game game);

		void Apagar (Game game);

		List<Game> Listar ();

		Game Obter (Game game);
	}
}

