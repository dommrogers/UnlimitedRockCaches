using MelonLoader;
using System.Reflection;

//This is a C# comment. Comments have no impact on compilation.

//ModName, ModVersion, ModAuthor, and ModNamespace.ModClassInheritingFromMelonMod all need changed.

[assembly: AssemblyTitle("UnlimitedRockCaches")]
[assembly: AssemblyCopyright("Created by STBlade")]

//Version numbers in C# are a set of 1 to 4 positive integers separated by periods.
//Mods typically use 3 numbers. For example: 1.2.1
//The mod version need specified in three places.
[assembly: AssemblyVersion("0.0.2")]
[assembly: AssemblyFileVersion("0.0.2")]
[assembly: MelonInfo(typeof(UnlimitedRockCaches.Implementation), "UnlimitedRockCaches", "0.0.2", "STBlade")]

//This tells MelonLoader that the mod is only for The Long Dark.
[assembly: MelonGame("Hinterland", "TheLongDark")]