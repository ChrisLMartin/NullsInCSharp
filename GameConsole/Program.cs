using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Sarah"
            };

            PlayerCharacter amrit = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Amrit"
            };

            PlayerCharacter gentry = new PlayerCharacter(new NullDefence())
            {
                Name = "Gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

        
                
            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter {Name = "Sarah"},
            //    new PlayerCharacter(), // Name = null
            //    null // PlayerCharacter = null
            //};

            //PlayerCharacter[] players = null;

            //string p1 = players?[0]?.Name;
            //string p2 = players?[1]?.Name;
            //string p3 = players?[2]?.Name;

            //PlayerCharacter player = null;

            //var player = new PlayerCharacter();
            //player.Name = "";
            //player.DaysSinceLastLogin = 42;

            //PlayerDisplayer.Write(player);

            //Null-conditional Operator

            //Either give value of DaysSinceLastLogin if player is not null
            // or evaluate to null
            //int days = player?.DaysSinceLastLogin ?? -1;

            //int days;

            //if (player != null)
            //{
            //    days = player.DaysSinceLastLogin ?? -1;
            //}
            //else
            //{
            //    days = -1;
            //}

            //int days = player.DaysSinceLastLogin ?? -1;

            //int days = player.DaysSinceLastLogin.Value;

            //Console.WriteLine(days);

        }
    }
}
