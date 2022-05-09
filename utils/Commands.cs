
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using System.Linq;

namespace DiscordBot.utils
{
    public class Commands : BaseCommandModule
    {
        [Command("init")]
        public async Task Init(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            DiscordMessage uni = await ctx.Channel.SendMessageAsync(Messages.Uni());
            DiscordMessage fe = await ctx.Channel.SendMessageAsync(Messages.Ferramentas());
            DiscordMessage pro = await ctx.Channel.SendMessageAsync(Messages.Proficiencias());


            // NOTA MENTAL: arrumar esse codigo repetido.

            await Events.CreateReaction(ctx, uni, fe, pro);
            while (true)
            {
                await Events.GetReaction(ctx, uni);
                await Events.GetReaction(ctx, fe);
                await Events.GetReaction(ctx, pro);
            }
        }
    }
}
