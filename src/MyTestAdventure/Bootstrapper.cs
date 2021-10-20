using System;
using System.Collections.Generic;
using System.Text;
using AdventureCore.AdventureEngine;
using Microsoft.Extensions.DependencyInjection;

namespace MyTestAdventure
{
    public class Bootstrapper
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()

            .AddScoped<ILocationFactory, MyLocationFactory>()
            .AddScoped<ILocationDisplay, MyLocationDisplay>()
            .AddScoped<IUserInput, MyUserInput>()
            .AddScoped<ICommandParser, MyCommandParser>()
            .AddScoped<ILocationCommandHistory, LocationCommandHistory>()
            .AddSingleton(typeof(MyGame))
            .BuildServiceProvider();

            MyGame game = serviceProvider.GetService(typeof(MyGame)) as MyGame;

            game.Start();
        
        }
    }
}
