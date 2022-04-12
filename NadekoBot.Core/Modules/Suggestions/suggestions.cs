using Discord;
using Discord.Commands;
using Discord.WebSocket;
using NadekoBot.Common;
using NadekoBot.Common.Attributes;
using NadekoBot.Core.Common.Attributes;
using NadekoBot.Core.Services;
using NadekoBot.Core.Services.Impl;
using NadekoBot.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NadekoBot.Core.Common;



namespace NadekoBot.Modules.Suggestions
{
    public partial class Suggestions : NadekoTopLevelModule

{







     //   [NadekoCommand, Usage, Description, Aliases]
       // [RequireContext(ContextType.Guild)]
       // [UserPerm(GuildPerm.ManageMessages)]
       // [Priority(1)]
       // public async Task Suggest(ITextChannel channel, [Leftover] string message)
       // {
       //     if (string.IsNullOrWhiteSpace(message))
        //        return;

           // var rep = new ReplacementBuilder()
                        //.WithDefault(ctx.User, channel, (SocketGuild)ctx.Guild, (DiscordSocketClient)ctx.Client)
                        //.Build();
           

         //   if (CREmbed.TryParse(message, out var embedData))
          //  {
          //      rep.Replace(embedData);
          //      try
          //      {
           //         await channel.EmbedAsync(embedData.ToEmbed(), embedData.PlainText?.SanitizeMentions() ?? "").ConfigureAwait(false);
            //    }
            //    catch (Exception ex)
              //  {
              //      _log.Warn(ex);
             //   }
           // }
           // else
          //  {
           //     var msg = rep.Replace(message);
           //     if (!string.IsNullOrWhiteSpace(msg))
            //    {
            //        await channel.SendConfirmAsync(msg).ConfigureAwait(false);
           //    }
          //  }
      // }



















        [NadekoCommand, Usage, Description, Aliases]
        [RequireContext(ContextType.Guild)]
        [Priority(0)]
        public async Task Suggest([Remainder] string suggestions)
        {
            
            await ctx.Channel.EmbedAsync(
                new EmbedBuilder().WithOkColor()
                    .WithAuthor(eab => eab.WithName($"Spookbot")
                                          .WithUrl("https://spookybots.ml")
                                          .WithIconUrl("https://beta.spookybots.ml/boticon.png"))
                                          
                    .AddField(efb => efb.WithName(GetText($"New Suggestion")).WithValue(suggestions).WithIsInline(true)));
 


        }
 
        
        
        
        
        
        
        //[Priority(0)]
        //public Task Suggest([Leftover] string message) =>
            //Suggest((ITextChannel)ctx.Channel, message);
       // public async Task Suggest([Leftover] string suggestions, IMessageChannel chh = "suggestions")
        //{
         //await Context.Message.DeleteAsync();
        // await chh.SendMessageAsync(suggestions);
        
        
        
        }}
