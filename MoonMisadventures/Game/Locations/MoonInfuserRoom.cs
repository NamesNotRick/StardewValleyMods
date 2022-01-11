using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using MoonMisadventures.VirtualProperties;
using StardewModdingAPI;
using StardewValley;

namespace MoonMisadventures.Game.Locations
{
    [XmlType( "Mods_spacechase0_MoonMisadventures_MoonInfuserRoom" )]
    public class MoonInfuserRoom : LunarLocation
    {
        public MoonInfuserRoom() { }
        public MoonInfuserRoom( IContentHelper content )
        :   base( content, "MoonInfuserRoom", "MoonInfuserRoom")
        {
        }

        protected override void resetLocalState()
        {
            base.resetLocalState();
            Game1.background = null;
        }

        public override bool performAction( string action, Farmer who, xTile.Dimensions.Location tileLocation )
        {
            if ( action == "InfuserSign1" )
                Game1.drawObjectDialogue( Mod.instance.Helper.Translation.Get( "message.infuser.1" ) );
            else if ( action == "InfuserSign2" )
                Game1.drawObjectDialogue( Mod.instance.Helper.Translation.Get( "message.infuser.2" ) );
            else if ( action == "InfuserSign3" )
                Game1.drawObjectDialogue( Mod.instance.Helper.Translation.Get( "message.infuser.3" ) );
            else if ( action == "CelestialInfuser" )
            {
                Game1.activeClickableMenu = new InfuserMenu();
            }
            return base.performAction( action, who, tileLocation );
        }
    }
}
