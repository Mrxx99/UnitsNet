﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions.NumberToForcePerLength
{
    public static class NumberToForcePerLengthExtensions
    {
        #region CentinewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double)"/>
        public static ForcePerLength CentinewtonsPerMeter(this int value) => ForcePerLength.FromCentinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double?)"/>
        public static ForcePerLength? CentinewtonsPerMeter(this int? value) => ForcePerLength.FromCentinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double)"/>
        public static ForcePerLength CentinewtonsPerMeter(this long value) => ForcePerLength.FromCentinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double?)"/>
        public static ForcePerLength? CentinewtonsPerMeter(this long? value) => ForcePerLength.FromCentinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double)"/>
        public static ForcePerLength CentinewtonsPerMeter(this double value) => ForcePerLength.FromCentinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double?)"/>
        public static ForcePerLength? CentinewtonsPerMeter(this double? value) => ForcePerLength.FromCentinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double)"/>
        public static ForcePerLength CentinewtonsPerMeter(this float value) => ForcePerLength.FromCentinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double?)"/>
        public static ForcePerLength? CentinewtonsPerMeter(this float? value) => ForcePerLength.FromCentinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double)"/>
        public static ForcePerLength CentinewtonsPerMeter(this decimal value) => ForcePerLength.FromCentinewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromCentinewtonsPerMeter(double?)"/>
        public static ForcePerLength? CentinewtonsPerMeter(this decimal? value) => ForcePerLength.FromCentinewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecinewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double)"/>
        public static ForcePerLength DecinewtonsPerMeter(this int value) => ForcePerLength.FromDecinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double?)"/>
        public static ForcePerLength? DecinewtonsPerMeter(this int? value) => ForcePerLength.FromDecinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double)"/>
        public static ForcePerLength DecinewtonsPerMeter(this long value) => ForcePerLength.FromDecinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double?)"/>
        public static ForcePerLength? DecinewtonsPerMeter(this long? value) => ForcePerLength.FromDecinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double)"/>
        public static ForcePerLength DecinewtonsPerMeter(this double value) => ForcePerLength.FromDecinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double?)"/>
        public static ForcePerLength? DecinewtonsPerMeter(this double? value) => ForcePerLength.FromDecinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double)"/>
        public static ForcePerLength DecinewtonsPerMeter(this float value) => ForcePerLength.FromDecinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double?)"/>
        public static ForcePerLength? DecinewtonsPerMeter(this float? value) => ForcePerLength.FromDecinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double)"/>
        public static ForcePerLength DecinewtonsPerMeter(this decimal value) => ForcePerLength.FromDecinewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromDecinewtonsPerMeter(double?)"/>
        public static ForcePerLength? DecinewtonsPerMeter(this decimal? value) => ForcePerLength.FromDecinewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerMeter

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double)"/>
        public static ForcePerLength KilogramsForcePerMeter(this int value) => ForcePerLength.FromKilogramsForcePerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double?)"/>
        public static ForcePerLength? KilogramsForcePerMeter(this int? value) => ForcePerLength.FromKilogramsForcePerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double)"/>
        public static ForcePerLength KilogramsForcePerMeter(this long value) => ForcePerLength.FromKilogramsForcePerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double?)"/>
        public static ForcePerLength? KilogramsForcePerMeter(this long? value) => ForcePerLength.FromKilogramsForcePerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double)"/>
        public static ForcePerLength KilogramsForcePerMeter(this double value) => ForcePerLength.FromKilogramsForcePerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double?)"/>
        public static ForcePerLength? KilogramsForcePerMeter(this double? value) => ForcePerLength.FromKilogramsForcePerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double)"/>
        public static ForcePerLength KilogramsForcePerMeter(this float value) => ForcePerLength.FromKilogramsForcePerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double?)"/>
        public static ForcePerLength? KilogramsForcePerMeter(this float? value) => ForcePerLength.FromKilogramsForcePerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double)"/>
        public static ForcePerLength KilogramsForcePerMeter(this decimal value) => ForcePerLength.FromKilogramsForcePerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromKilogramsForcePerMeter(double?)"/>
        public static ForcePerLength? KilogramsForcePerMeter(this decimal? value) => ForcePerLength.FromKilogramsForcePerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double)"/>
        public static ForcePerLength KilonewtonsPerMeter(this int value) => ForcePerLength.FromKilonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double?)"/>
        public static ForcePerLength? KilonewtonsPerMeter(this int? value) => ForcePerLength.FromKilonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double)"/>
        public static ForcePerLength KilonewtonsPerMeter(this long value) => ForcePerLength.FromKilonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double?)"/>
        public static ForcePerLength? KilonewtonsPerMeter(this long? value) => ForcePerLength.FromKilonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double)"/>
        public static ForcePerLength KilonewtonsPerMeter(this double value) => ForcePerLength.FromKilonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double?)"/>
        public static ForcePerLength? KilonewtonsPerMeter(this double? value) => ForcePerLength.FromKilonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double)"/>
        public static ForcePerLength KilonewtonsPerMeter(this float value) => ForcePerLength.FromKilonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double?)"/>
        public static ForcePerLength? KilonewtonsPerMeter(this float? value) => ForcePerLength.FromKilonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double)"/>
        public static ForcePerLength KilonewtonsPerMeter(this decimal value) => ForcePerLength.FromKilonewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromKilonewtonsPerMeter(double?)"/>
        public static ForcePerLength? KilonewtonsPerMeter(this decimal? value) => ForcePerLength.FromKilonewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicronewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double)"/>
        public static ForcePerLength MicronewtonsPerMeter(this int value) => ForcePerLength.FromMicronewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double?)"/>
        public static ForcePerLength? MicronewtonsPerMeter(this int? value) => ForcePerLength.FromMicronewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double)"/>
        public static ForcePerLength MicronewtonsPerMeter(this long value) => ForcePerLength.FromMicronewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double?)"/>
        public static ForcePerLength? MicronewtonsPerMeter(this long? value) => ForcePerLength.FromMicronewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double)"/>
        public static ForcePerLength MicronewtonsPerMeter(this double value) => ForcePerLength.FromMicronewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double?)"/>
        public static ForcePerLength? MicronewtonsPerMeter(this double? value) => ForcePerLength.FromMicronewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double)"/>
        public static ForcePerLength MicronewtonsPerMeter(this float value) => ForcePerLength.FromMicronewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double?)"/>
        public static ForcePerLength? MicronewtonsPerMeter(this float? value) => ForcePerLength.FromMicronewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double)"/>
        public static ForcePerLength MicronewtonsPerMeter(this decimal value) => ForcePerLength.FromMicronewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromMicronewtonsPerMeter(double?)"/>
        public static ForcePerLength? MicronewtonsPerMeter(this decimal? value) => ForcePerLength.FromMicronewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillinewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double)"/>
        public static ForcePerLength MillinewtonsPerMeter(this int value) => ForcePerLength.FromMillinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double?)"/>
        public static ForcePerLength? MillinewtonsPerMeter(this int? value) => ForcePerLength.FromMillinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double)"/>
        public static ForcePerLength MillinewtonsPerMeter(this long value) => ForcePerLength.FromMillinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double?)"/>
        public static ForcePerLength? MillinewtonsPerMeter(this long? value) => ForcePerLength.FromMillinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double)"/>
        public static ForcePerLength MillinewtonsPerMeter(this double value) => ForcePerLength.FromMillinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double?)"/>
        public static ForcePerLength? MillinewtonsPerMeter(this double? value) => ForcePerLength.FromMillinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double)"/>
        public static ForcePerLength MillinewtonsPerMeter(this float value) => ForcePerLength.FromMillinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double?)"/>
        public static ForcePerLength? MillinewtonsPerMeter(this float? value) => ForcePerLength.FromMillinewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double)"/>
        public static ForcePerLength MillinewtonsPerMeter(this decimal value) => ForcePerLength.FromMillinewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromMillinewtonsPerMeter(double?)"/>
        public static ForcePerLength? MillinewtonsPerMeter(this decimal? value) => ForcePerLength.FromMillinewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanonewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double)"/>
        public static ForcePerLength NanonewtonsPerMeter(this int value) => ForcePerLength.FromNanonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double?)"/>
        public static ForcePerLength? NanonewtonsPerMeter(this int? value) => ForcePerLength.FromNanonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double)"/>
        public static ForcePerLength NanonewtonsPerMeter(this long value) => ForcePerLength.FromNanonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double?)"/>
        public static ForcePerLength? NanonewtonsPerMeter(this long? value) => ForcePerLength.FromNanonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double)"/>
        public static ForcePerLength NanonewtonsPerMeter(this double value) => ForcePerLength.FromNanonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double?)"/>
        public static ForcePerLength? NanonewtonsPerMeter(this double? value) => ForcePerLength.FromNanonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double)"/>
        public static ForcePerLength NanonewtonsPerMeter(this float value) => ForcePerLength.FromNanonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double?)"/>
        public static ForcePerLength? NanonewtonsPerMeter(this float? value) => ForcePerLength.FromNanonewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double)"/>
        public static ForcePerLength NanonewtonsPerMeter(this decimal value) => ForcePerLength.FromNanonewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromNanonewtonsPerMeter(double?)"/>
        public static ForcePerLength? NanonewtonsPerMeter(this decimal? value) => ForcePerLength.FromNanonewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerMeter

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double)"/>
        public static ForcePerLength NewtonsPerMeter(this int value) => ForcePerLength.FromNewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double?)"/>
        public static ForcePerLength? NewtonsPerMeter(this int? value) => ForcePerLength.FromNewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double)"/>
        public static ForcePerLength NewtonsPerMeter(this long value) => ForcePerLength.FromNewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double?)"/>
        public static ForcePerLength? NewtonsPerMeter(this long? value) => ForcePerLength.FromNewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double)"/>
        public static ForcePerLength NewtonsPerMeter(this double value) => ForcePerLength.FromNewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double?)"/>
        public static ForcePerLength? NewtonsPerMeter(this double? value) => ForcePerLength.FromNewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double)"/>
        public static ForcePerLength NewtonsPerMeter(this float value) => ForcePerLength.FromNewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double?)"/>
        public static ForcePerLength? NewtonsPerMeter(this float? value) => ForcePerLength.FromNewtonsPerMeter(value);

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double)"/>
        public static ForcePerLength NewtonsPerMeter(this decimal value) => ForcePerLength.FromNewtonsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ForcePerLength.FromNewtonsPerMeter(double?)"/>
        public static ForcePerLength? NewtonsPerMeter(this decimal? value) => ForcePerLength.FromNewtonsPerMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif