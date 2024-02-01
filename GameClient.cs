using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Models;

namespace GameStore
{
    public static class  GameClient
    {
        private static readonly List <Game> games = new ()
    {
            new Game()
            {
                Id = 1, 
                Name = "Street Fighter II",
                Genre = "Fightning",
                Price = 10.90M,
                ReleaseDate = new DateTime (1991, 2, 2)
            },
            new Game()
            {
                Id = 2, 
                Name = "Final Fantasy XIV",
                Genre = "Roleplaying ",
                Price = 10.90M,
                ReleaseDate = new DateTime (1991, 2, 2)
            },
            new Game()
            {
                Id = 3, 
                Name = "FiFA 23",
                Genre = "Sport",
                Price = 15.90M,
                ReleaseDate = new DateTime (1991, 2, 2)
            }

    };
    public static Game[] GetGames ()
    {
        return games.ToArray();
    }
    public static void AddGame(Game game)
    {
        game.Id = games.Max(game=> game.Id)+1;
        games.Add(game);
    }

    public static Game GetGames(int id)
    {
        return games.Find(game => game.Id ==id ) ?? throw new Exception ("Could not find game !");
    }


    public static void UpdateGame(Game updatedGame)
    {
        Game existingGame = GetGames(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGames(id);
        games.Remove(game);
    }


    }
}