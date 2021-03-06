﻿using csharp9.PrimaryConstructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace csharp9.Tests.Unit.PrimaryConstructors
{
    public class PrimaryConstructorsTests
    {
        [Fact]
        public void SimplePrimaryConstructor()
        {
            var p = new Person("Miguel", "Bernard");
            Assert.Equal("Miguel", p.firstName);
            Assert.Equal("Bernard", p.lastName);
        }

        [Fact]
        public void PrimaryConstructorWithAutoConstructor()
        {
            var p = new Person("Miguel", "Bernard") { lastName = "test" };

            Assert.Equal("Miguel", p.firstName);
            Assert.Equal("test", p.lastName);
        }

        [Fact]
        public void PrimaryConstructorWithDefaultValue()
        {
            var p = new PersonWithDefaultValue("Miguel");
            Assert.Equal("Miguel", p.firstName);
            Assert.Equal("lastName", p.lastName);
        }

        //[Fact]
        //public void PrimaryConstructorWithAutoConstructorInstead()
        //{
        //    // This is not valid
        //    var p = new Person("Miguel") { lastName = "test" };

        //    Assert.Equal("Miguel", p.firstName);
        //    Assert.Equal("test", p.lastName);
        //}
    }
}
