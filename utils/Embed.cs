using DSharpPlus.Entities;

namespace DiscordBot.utils
{
    public class Messages
    {
        readonly static DiscordEmbedBuilder uni = new DiscordEmbedBuilder()
        {
            Title = "Cargos",
            Color = DiscordColor.Blue,
            Description = "Para ter o cargo desejado basta reagir abaixo no emoji correspondente!\n\nUNICESUMAR"
        };
        readonly static DiscordEmbedBuilder ferramentas = new DiscordEmbedBuilder()
        {
            Color = DiscordColor.Red,
            Description = "**Ferramentas**\n\nC/C++\nC#\nPython\nRuby\nJavascript\nJAVA",
        };
        readonly static DiscordEmbedBuilder proficiencias = new DiscordEmbedBuilder()
        {
            Color = DiscordColor.Green,
            Description =
                        "**Proficiências**\n\nPro - _É acima da média na arte de fazer dinheiro_\n" +
                        "Matemática - _É acima da média em matemática_\n" +
                        "Análise e Projeto - _É acima da média em análise e desenvolvimento_\n" +
                        "Front-End - _É acima da média em front-end/UI_\n" +
                        "Back-End - _É acima da média em back-end/SS_\n" +
                        "Software Embarcado - _É acima da média em embarcados (microcontroladores e afins)_\n" +
                        "Data Science - _É acima da média em Data Science (Estatística, AI/ML, Pesquisa Operacional)_",
        };

        public static DiscordEmbedBuilder Uni()
        {
            return uni;
        }

        public static DiscordEmbedBuilder Ferramentas()
        {
            return ferramentas;
        }

        public static DiscordEmbedBuilder Proficiencias()
        {
            return proficiencias;
        }

        public static Dictionary<string, ulong> Cargos()
        {
            //Dicionario com os emojis e ID dos cargos
            Dictionary<string, ulong> List = new Dictionary<string, ulong> {
                { ":Unicesumar:", 775871982876885005 },
                { ":C:", 837077748408254494 },
                { ":Csharp", 812096393547612160 },
                { ":Python:", 812096497927061544 },
                { ":Ruby:", 812096665137184779 },
                { ":Javascript:", 812096218679345192 },
                { ":Java:", 846860930813132860 },
                { ":Pro:", 846861149802725377 },
                { ":Matematica:", 846860769228226560 },
                { ":Analise:", 846861469940580382 },
                { ":Frontend:", 846861942378987570 },
                { ":Backend:", 846861995927928872 },
                { ":Embarcado:", 846862087926186054 },
                { ":DataScience:", 846862192729260063 },
            };
            return List;
        }
    }
}