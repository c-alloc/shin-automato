using System;
using DSharpPlus;

namespace DiscordBot
{
    static class Program
    {
        public static Bot bot;

        static void Main(string[] args)
        {

            bot = new Bot();
            bot.Run("TOKEN").GetAwaiter().GetResult();
        }
    }
}
