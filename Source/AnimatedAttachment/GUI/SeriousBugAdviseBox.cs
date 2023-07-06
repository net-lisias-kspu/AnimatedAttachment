/*
	This file is part of Animated Attachment /L Unleashed
		© 2021-2023 Lisias T : http://lisias.net <support@lisias.net>
		© 2018-2021 Katten

	Animated Attachment /L Unleashed is licensed as follows:

		* CC-BY-NC-SA 4.0i : https://creativecommons.org/licenses/by-nc-sa/4.0/

	Animated Attachment /L Unleashed is distributed in the hope that
	it will be useful, but WITHOUT ANY WARRANTY; without even the implied
	warranty of	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

*/
using System;
using UnityEngine;
using KSPe.UI;

namespace AnimatedAttachment_NS.GUI
{
	internal class HotFixAdviseBox:CommonBox
	{
		private static readonly string MSG = @"There's a serious bug on this Release that can render your crafts deformed due inphysics stress as it happens with Docking Ports on KSP 1.12.2 and with Robotics since 1.7.3.

So it's <b>unwise</b> to use this on Careers or Role Playing Sandbox savegames.

But it's ok for artistic craft design, shooting movies, etc where the craft persistence on the savegame is not important.

See the KNOWN_ISSUES file on the repository for details.
";

		internal static void show()
		{
			GameObject go = new GameObject("TweakScale.AdviseBox");
			TimedMessageBox dlg = go.AddComponent<TimedMessageBox>();

			GUIStyle win = createWinStyle(Color.white);
			GUIStyle text = createTextStyle();

			if (ModuleManagerListener.shouldShowWarnings)
				dlg.Show(
					"AnimatedAttachment advises",
					MSG,
					30, 0, -1,
					win, text
				);
			Log.force("\"AnimatedAttachment advises\" about the serious bug.");
		}
	}
}