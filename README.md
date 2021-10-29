# Animated Attachment /L Unleashed

Allows generic animations to move attached parts

[Unleashed](https://ksp.lisias.net/add-ons-unleashed/) fork by Lisias.


## In a Hurry

* [Latest Release](https://github.com/net-lisias-kspu/AnimatedAttachment/releases)
	+ [Binaries](https://github.com/net-lisias-kspu/AnimatedAttachment/tree/Archive)
* [Source](https://github.com/net-lisias-kspu/AnimatedAttachment)
* Documentation
	+ [Project's README](https://github.com/net-lisias-kspu/AnimatedAttachment/blob/master/README.md)
	+ [Install Instructions](https://github.com/net-lisias-kspu/AnimatedAttachment/blob/master/INSTALL.md)
	+ [Change Log](./CHANGE_LOG.md)
	+ [TODO](./TODO.md) list


## Description

This mod adds a PartModule that enable generic animations to move sub parts! Thus, it is a light-weight option for modders and players to use instead of the more advanced robotics mods out there. Even works for stock parts!

When a part contains components that move (due to animations, gimballing or moving control surfaces), this part module can move any connected part in response. Thus, a part modder may add a moving boom, rotators, hinges etc without learning anything more than they already know from before. 

Parts are moved by using physical forces in the joints. This means that they will obey the laws of physics.

### Limitations & known issues

See [known issues file](./KNOWN_ISSUES.md)

### Basic usage

AnimatedAttachment will be automatically added to all parts containing a ModuleAnimateGeneric, ModuleGimbal or ModuleControlSurface. So there is no need to do anything else to your config.

Players simply use the "Deploy" button or similar to run the animation and any connected sub-part will move with it.

### Advanced usage

A player can adjust this in the VAB by enabling the stock feature "Advanced tweakables" in the settings and then right clicking the animated part, to set maximum force and spring strength.

Part modders may potentially override the default settings in the part module, but this has not been tested much yet.

### Compatibility

This mod has been tested for compatibility with

* KJR
* KIS/KAS


## Installation

Detailed installation instructions are now on its own file (see the [In a Hurry](#in-a-hurry) section) and on the distribution file.


## License:

CC-BY-SA-NC 4.0 International.

Please note the copyrights and trademarks in [NOTICE](./NOTICE).


## UPSTREAM

* [Katten](https://forum.kerbalspaceprogram.com/index.php?/profile/180392-katten/) ROOT
	+ [Forum](https://forum.kerbalspaceprogram.com/index.php?/topic/175881-*)
	+ [Github](https://github.com/KSPKatten/AnimatedAttachment)
