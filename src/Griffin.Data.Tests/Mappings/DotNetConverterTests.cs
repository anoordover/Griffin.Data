﻿using System;
using Griffin.Data.Converters;
using Griffin.Data.Mappings;
using Xunit;

namespace Griffin.Data.Tests.Mappings
{
    public class DotNetConverterTests
    {
        [Fact]
        public void ConvertsStringDbNullToNull()
        {
            var converter = new DotNetConverter<string>();

            var actual = converter.Convert(DBNull.Value);

            Assert.Null(actual);
        }

        [Fact]
        public void ConvertsIntDbNullToZero()
        {
            var converter = new DotNetConverter<int>();

            var actual = converter.Convert(DBNull.Value);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void ConvertsStringNullToNull()
        {
            var converter = new DotNetConverter<string>();

            var actual = converter.Convert(null);

            Assert.Null(actual);
        }

        [Fact]
        public void ConvertsIntToString()
        {
            var converter = new DotNetConverter<string>();

            var actual = converter.Convert(1);

            Assert.Equal("1", actual);
        }

        [Fact]
        public void ConvertsNullToInt()
        {
            var converter = new DotNetConverter<int>();

            var actual = converter.Convert(null);

            Assert.Equal(0, actual);
        }
    }
}