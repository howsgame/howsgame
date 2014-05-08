using System;
using System.Collections.Generic;

namespace Howsgame.Dominio
{
	public class Game
	{
		public int Id {get;set;}
		public string Nome {get;set;}
		public DateTime Release {get;set;}
		public Categoria Categoria {get;set;}
		public Plataforma Plataforma {get;set;}
		public Avaliador Avaliador {get;set;}
		private IGameRepositorio _gamerepositorio;


		public Game (IGameRepositorio gamerepositorio)
		{
			_gamerepositorio = gamerepositorio;
		}

		public void Adicionar()
		{
			_gamerepositorio.Adicionar (this);
		}
		public void Atualizar()
		{
			_gamerepositorio.Atualizar (this);
		}

		public void Apagar()
		{
			_gamerepositorio.Apagar (this);
		}

		public List<Game> Listar()
		{
			return _gamerepositorio.Listar ();
		}

		public Game Obter()
		{
			return _gamerepositorio.Obter (this);
		}

		public bool Lancamento()
		{
			if (Release.Month < DateTime.Now.Month && Release.Year == DateTime.Now.Year)
				return true;
			return false;
		}

	}
}

