using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.CommandsNext;

namespace DiscordBot.utils
{
    static class Events
    {
        public static async Task GetReaction(CommandContext ctx, DiscordMessage msg)
        {
            var reaction = await Program.bot.interactivity.WaitForReactionAsync((MessageReactionAddEventArgs r) => r.Message.Id == msg.Id && !r.User.IsBot && r.User.Id == ctx.Member.Id);
            var user = reaction.Result.User as DiscordMember;

            var rolesDic = Messages.Cargos(); //lista

            ulong Id;
            bool hasRole = rolesDic.TryGetValue(reaction.Result.Emoji.GetDiscordName(), out Id);
            if (hasRole == true)
            {
                var role = ctx.Guild.GetRole(Id);
                await user.GrantRoleAsync(role);
            }
        }

        public static async Task CreateReaction(CommandContext ctx, DiscordMessage msg1, DiscordMessage msg2, DiscordMessage msg3)
        {
            await msg1.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Unicesumar:"));

            await msg2.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":C:"));
            await msg2.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":C#:"));
            await msg2.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Python:"));
            await msg2.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Ruby:"));
            await msg2.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Javascript:"));
            await msg2.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Java:"));

            await msg3.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Pro:"));
            await msg3.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Matematica:"));
            await msg3.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Analise:"));
            await msg3.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Frontend:"));
            await msg3.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Backend:"));
            await msg3.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":Embarcado:"));
            await msg3.CreateReactionAsync(DiscordEmoji.FromName(ctx.Client, ":DaraScience:"));
        }
    }
}