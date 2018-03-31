using System;

namespace OOP_Examples.Classes.zoo
{
	abstract class Canine : Mammal
	{
        new string Food { get; set; } = "meat";
        public Sleep CanineSleep { get; set; } = Sleep.diurnal;
        public Size CanineSize { get; set; } = Size.medium;
        new int Cute { get; set; } = 4;
        new int Noble { get; set; } = 7;
    }
}
