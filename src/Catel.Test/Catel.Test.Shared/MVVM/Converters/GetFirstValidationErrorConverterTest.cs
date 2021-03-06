﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetFirstValidationErrorConverterTest.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if NET || SL5

namespace Catel.Test.MVVM.Converters
{
    using Catel.MVVM.Converters;

#if NETFX_CORE
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#else
    using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

    [TestClass]
    public class GetFirstValidationErrorConverterTest
    {
        #region Methods
        [TestMethod]
        public void Convert_Null()
        {
            var converter = new GetFirstValidationErrorConverter();
            Assert.AreEqual(string.Empty, converter.Convert(null, typeof (string), null, null));
        }

        //[TestMethod]
        //public void Convert_ObjectWithError()
        //{
        //    List<ValidationError> errors = new List<ValidationError>();
        //    errors.Add(new ValidationError(new ValidationRule(ValidationStep.CommittedValue, false), null));

        //    var converter = new GetFirstValidationErrorConverter();
        //    Assert.AreEqual(string.Empty, converter.Convert(null, typeof(object), null, null));
        //}

        //[TestMethod]
        //public void Convert_ObjectWithoutErrors()
        //{
        //    Assert.Fail("Need to write unit test");
        //}

        [TestMethod]
        public void ConvertBack()
        {
            var converter = new GetFirstValidationErrorConverter();
            Assert.AreEqual(ConverterHelper.UnsetValue, converter.ConvertBack(null, typeof (object), null, null));
        }
        #endregion
    }
}

#endif