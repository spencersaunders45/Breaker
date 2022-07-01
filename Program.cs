using System;
using Breaker.Game.Directing;
using Breaker.Game.Services;

namespace Breaker
{
   public class Program
   {
      static void Main(string[] args)
      {
         Director director = new Director(SceneManager.VideoService);
         director.StartGame();
      }
   }
}