# Animated Attachment /L Unleashed :: Known Issues

* There's a very serious situation that makes the use of this thing dangerous!
	+ The use of `part.UpdateOrgPosAndRot` outside the Editor is suicidal, as it permanently mangles the position and orientation of the part. On timewarp or similar situations when the physics engine is overloaded or taking shortcuts, this will move the parts to undesired atitudes, turning the current inphysics deformations permanent - exactly as it happens with the Robotics!
	+ See this [post](https://forum.kerbalspaceprogram.com/index.php?/topic/175881-1100-animatedattachment-215-2020-07-15/&do=findComment&comment=4024014) for details.
* [#3](https://github.com/KSPKatten/AnimatedAttachment/issues/3) There is a caveat for physics-less parts - while they and any other physics-less sub-parts to them will move with the animation, any physics-enabled sub-parts will not. For example, a cubic strut connected to a hinge will move with it, but a tank connected to the cubic strut will not.

- - -

* RiP : Research in Progress
* WiP : Work in Progress
