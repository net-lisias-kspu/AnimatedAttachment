/*
	This file is part of Animated Attachment /L Unleashed
		© 2021 Lisias T : http://lisias.net <support@lisias.net>
		© 2018-2021 Katten

	Animated Attachment /L Unleashed is licensed as follows:

		* CC-BY-NC-SA 4.0i : https://creativecommons.org/licenses/by-nc-sa/4.0/

	Animated Attachment /L Unleashed is distributed in the hope that
	it will be useful, but WITHOUT ANY WARRANTY; without even the implied
	warranty of	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

*/
using System.Collections.Generic;
using UnityEngine;

namespace AnimatedAttachment_NS
{
	public static class ModuleManagerSupport
	{
		public static IEnumerable<string> ModuleManagerAddToModList()
		{
			string[] r = {"AnimatedAttachment" }; //{typeof(ModuleManagerSupport).Namespace};
			return r;
		}
	}

	[KSPAddon(KSPAddon.Startup.Instantly, true)]
	internal class ModuleManagerListener:MonoBehaviour
	{
		internal static bool shouldShowWarnings = true;

		public static void ModuleManagerPostLoad()
		{
			shouldShowWarnings = !KSPe.Util.ModuleManagerTools.IsLoadedFromCache;
			Log.detail("ModuleManagerPostLoad handled! shouldShowWarnings is {0}", shouldShowWarnings);
		}
	}
}
