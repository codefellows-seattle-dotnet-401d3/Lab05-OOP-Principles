using System;
using Xunit;
using Lab05;

namespace Lab05tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void ImplimentsIDarkvision()
        {
            Assert.IsAssignableFrom<IDarkvision>(new DisplacerBeast());
        }

        [Fact]
        public void ImplimentsITremorSense()
        {
            Assert.IsAssignableFrom<ITremorSense>(new Dragon());
        }

        [Fact]
        public void DerivedFromAttraction()
        {
            Assert.IsAssignableFrom<Attraction>(new Dragon());
        }

        [Fact]
        public void HasCorrectHP1()
        {
            Monkey animal = new Monkey();
            Assert.Equal(12, animal.HP);
        }

        [Fact]
        public void HasImmunity()
        {
            Dragon animal = new Dragon();
            Assert.Equal("Fire, Poison", animal.Immunity);
        }

        [Fact]
        public void CorrectName()
        {
            ShockerLizzard animal = new ShockerLizzard();
            Assert.Equal("ShockerLizzard", animal.Name);
        }

        [Fact]
        public void CorrectClimate()
        {
            Plesiosaurus animal = new Plesiosaurus();
            Assert.Equal("Aquatic", animal.Climate);
        }

        [Fact]
        public void CheckSubType()
        {
            Dopplganger animal = new Dopplganger();
            Assert.Equal("Humanoid", animal.SubType);
        }

        [Fact]
        public void CheckThreatLevel()
        {
            DisplacerBeast animal = new DisplacerBeast();
            Assert.Equal(5, animal.ThreatLevel(5));
        }
    }
}
