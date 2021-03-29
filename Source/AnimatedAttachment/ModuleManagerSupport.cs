using System.Collections.Generic;

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
}
