# Animated Attachment :: Change Log

* 2021-0413: 2.1.5.2 (LisiasT) for KSP >= 1.4.0
	+ Added KSPe facilities:
		- Logging/Debugging
		- File System Abstraction
	+ Works on every KSP version from 1.4.0 to the latest.
* 2021-0329: 2.1.5.1 (LisiasT) for KSP >= 1.4.0
	+ ***DITCHED*** due wrongly compilation against a beta release of KSPe.
* 2020-0715: 2.1.5 (Katten) for KSP 1.10.0
	+ Updated to indicate compatibility with KSP v1.10
* 2019-0601: 2.1.4 (Katten) for KSP 1.7.0
	+ Added default support for launch clamps
* 2019-0512: 2.1.3 (Katten) for KSP 1.7.0
	+ Compiled for KSP v1.7.0
* 2019-0331: 2.1.2 (Katten) for KSP 1.6.1
	+ Updated to KSP v1.6.1
* 2018-0817: 2.1.1 (Katten) for KSP 1.4.5
	+ Added compatibility with PangolinMechanicsToolkit
* 2018-0719: 2.1.0 (Katten) for KSP 1.4.5
	+ Now compatible with KIS/KAS.
	+ Fine-tuning now works without having to disable the mod
	+ Increased default spring&force
* 2018-0709: 2.0.3 (Katten) for KSP 1.4.5
	+ Implemented a work-around for an issue in stock wheel auto-struts
* 2018-0708: 2.0.2 (Katten) for KSP 1.4.5
	+ Cleaned out some dlls that were mistakenly included in the release
* 2018-0708: 2.0.1 (Katten) for KSP 1.4.5
	+ Improves compatibility with KJR by implementing IJointLockState
	+ Cleanup, since the above fix also works for stock wheel auto-struts
* 2018-0707: 2.0.0 (Katten) for KSP 1.4.5
	+ Now supports animated surface attachments
	+ Now adds support to all moving stock parts
	+ Now makes it possible to surface attach stuff on cargo doors and engine bells, which is not possible in stock
* 2018-0628: 1.2.2 (Katten) for KSP 1.4.5 PRE-RELEASE
	+ Wheels create auto-struts that inhibits robotic mods to move them. All auto-struts are now removed while any animation is running.
* 2018-0626: 1.2.1 (Katten) for KSP 1.4.5
	+ Issue #1: Now applies scaling from models to attach nodes
* 2018-0625: 1.2.0 (Katten) for KSP 1.4.5
	+ Can now disable the animations temporarily in order to move attached parts in the editor for tuning
	+ Now survives time warp
	+ Now survives launch revert
	+ Now survives saving and loading
	+ Increased default springs and dampers
	+ Fixed the download path in the version file
* 2018-0613: 1.1.0 (Katten) for KSP 1.4.5
	+ Now handles roll rotations correctly
* 2018-0610: 1.0.0 (Katten) for KSP 1.4.5
	+ Generic animations can now move connected parts
