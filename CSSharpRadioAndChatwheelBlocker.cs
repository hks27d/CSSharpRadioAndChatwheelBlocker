using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Commands;

namespace CSSharpRadioAndChatwheelBlocker
{
    public class CSSharpRadioAndChatwheelBlocker : BasePlugin
    {
        public override string ModuleName => "CS# Radio & Chatwheel Blocker";
        public override string ModuleVersion => "1.0.0";
        public override string ModuleAuthor => "HKS 27D";
        public override string ModuleDescription => "";

        private readonly string[] RadioArray = [
            "coverme",
            "takepoint",
            "holdpos",
            "regroup",
            "followme",
            "takingfire",
            "go",
            "fallback",
            "sticktog",
            "getinpos",
            "stormfront",
            "report",
            "roger",
            "enemyspot",
            "needbackup",
            "sectorclear",
            "inposition",
            "reportingin",
            "getout",
            "negative",
            "enemydown",
            "sorry",
            "cheer",
            "compliment",
            "thanks",
            "go_a",
            "go_b",
            "needrop",
            "deathcry"
        ];

        public override void Load(bool hotReload)
        {
            AddCommandListener("playerchatwheel", CommandListener_RadioAndChatwheelBlocker);
            for (int i = 0; i < RadioArray.Length; i++)
            {
                AddCommandListener(RadioArray[i], CommandListener_RadioAndChatwheelBlocker);
            }
        }

        private HookResult CommandListener_RadioAndChatwheelBlocker(CCSPlayerController? player, CommandInfo info)
        {
            return HookResult.Handled;
        }
    }
};
