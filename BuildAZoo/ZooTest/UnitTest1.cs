using System;
using Xunit;
using BuildAZoo.Classes;
using BuildAZoo;

namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateLionObject()
        {
            Lion leon = new Lion();

            Assert.NotNull(leon);
        }

        [Fact]
        public void CheckIfTheLionReturnsTrue()
        {
            Lion leon = new Lion();

            Assert.True(leon.Roars());
        }

        [Fact]
        public void WhatASleepingLionSoundLike()
        {
            Lion leon = new Lion();

            string result = leon.Sleep();

            Assert.Contains("ZZZZ slight growl ZZZZ", result);
        }

        [Fact]
        public void CanGetLionFurColor()
        {
            Lion leon = new Lion();

            Assert.Contains("yellow", leon.FurColor);
        }

        [Fact]
        public void CanCreateEagle()
        {
            Eagle eagle = new Eagle();

            Assert.NotNull(eagle);
        }

        [Fact]
        public void CanGetEagleNumberOfLegs()
        {
            Eagle eagle = new Eagle();

            Assert.Equal(2, eagle.NumberOfLegs);
        }

        [Fact]
        public void RhinoHasHornsEqualsTrue()
        {
            Rhino ross = new Rhino();

            Assert.True(ross.HasHorns);
        }
    }
}
