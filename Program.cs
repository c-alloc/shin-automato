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
            bot.Run("ODMyMDQwMzI4NjgzODQ3Njgx.Gh97yf.hdY75UK8BSYKK3Ft-G0_hL5F9TFdaO8T_OusSE").GetAwaiter().GetResult();
        }
    }
}
