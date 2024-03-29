﻿using GrpcPokemon.Menus.Display;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ParkAir___Assignment;
using System.Net;
using System.Text;

namespace GrpcPokemon
{
  internal class Program
  {
    /// <summary>
    /// Application entry point that calls a new 
    /// Pokemon Manager to control the game.
    /// </summary>
    /// <param name="args">Arguments passed by CLI</param>
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      AnsiConsole.Initialize();

      Bulbasaur bulb = new Bulbasaur();
      BattleUi testBattle = new BattleUi(bulb);
      while (true)
      {
        testBattle.BattleSelect();
      
      }

      try
      {
        Console.ResetColor();
        PokemonManager manager = new PokemonManager();

#warning Need to add IP Address of machine.
        CreateServer(IPAddress.Parse("192.168.1.1"), 5001).Services
    //                  .AddSingleton<BattleService>()
                      .AddSingleton(manager);
        Console.Read();
      }
      catch(Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
      }
    }

    internal static WebApplicationBuilder CreateServer(IPAddress address, int port)
    {
      IPEndPoint myEndpoint = new IPEndPoint(address, port);
      return BuildWebApplication(myEndpoint);
    }

   
    private static WebApplicationBuilder BuildWebApplication(IPEndPoint myEndpoint)
    {
      Action<KestrelServerOptions> WithKestrelConfig = kestrel => kestrel.Listen(myEndpoint);
      WebApplicationBuilder builder = WebApplication.CreateBuilder();

      builder.Host.UseWindowsService();
      builder.Services.AddGrpc();
      builder.WebHost.UseKestrel(WithKestrelConfig);

      return builder;
    }

  }
}
