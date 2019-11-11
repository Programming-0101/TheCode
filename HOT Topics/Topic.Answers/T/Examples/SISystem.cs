/*
 *  ![Conversions between SI Types](01DD9FB31401F708A0F3A40A6E87B3F9.png;;;0.01283,0.01283)
 * The Seven SI Units: This figure displays the fundamental SI units and the combinations that lead to more complex units of measurement.
 * Credits: https://courses.lumenlearning.com/boundless-chemistry/chapter/units-of-measurement/
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.T.Examples
{
    /// <summary>
    /// 
    /// "The SI is founded on seven SI base units for seven base quantities assumed to be mutually independent" - https://physics.nist.gov/cuu/Units/units.html
    /// </summary>
    /// <remarks>
    /// Conversions between types in the SI system can be illustrated in the following image.
    /// ![Conversions between SI Types](01DD9FB31401F708A0F3A40A6E87B3F9.png;;;0.01283,0.01283)
    /// Credits: https://courses.lumenlearning.com/boundless-chemistry/chapter/units-of-measurement/
    /// 
    /// "It should be apparent that the move into modern times has greatly refined the conditions of measurement for each basic unit in the SI system, making the measurement of, for example, the luminous intensity of a light source a standard measurement in every laboratory in the world. A light source made to produce 20 cd will be the same regardless of whether it is made in the United States, in the UK, or anywhere else. The use of the SI system provides all scientists and engineers with a common language of measurement."
    /// </remarks>
    namespace SiSystem
    {
        public interface Measure {
            /// <summary>"The value of a physical quantity is the quantitative expression of a particular physical quantity as the product of a number and a unit, the number being its numerical value. Thus, the numerical value of a particular physical quantity depends on the unit in which it is expressed."</summary>
            /// <remarks>Source: https://physics.nist.gov/cuu/Units/introduction.html</remarks>
            decimal Value {get;}
            string UnitSymbol { get; }
        }
        /// <summary>
        /// A measurement of distance in the SI (International System of Units)
        /// </summary>
        /// <remarks>
        /// The meter (m), or metre, was originally defined as 1/10,000,000 of the distance from the Earth’s equator to the North Pole measured on the circumference through Paris. In modern terms, it is defined as the distance traveled by light in a vacuum over a time interval of 1/299,792,458 of a second.
        /// </remarks>
        public struct Meter : Measure
        {
            public decimal Value { get; private set; }
            public string UnitSymbol => "m";
            public Meter(decimal value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return $"{Value} {UnitSymbol}";
            }
        }
        /// <summary>
        /// A measurement of mass in the SI (International System of Units)
        /// </summary>
        /// <remarks>
        /// The kilogram (kg) was originally defined as the mass of a liter (i.e., of one thousandth of a cubic meter). It is currently defined as the mass of a platinum-iridium kilogram sample maintained by the Bureau International des Poids et Mesures in Sevres, France.
        /// </remarks>
        public struct Kilogram : Measure
        {
            public decimal Value { get; private set; }
            public string UnitSymbol => "kg";
            public Kilogram(decimal value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return $"{Value} {UnitSymbol}";
            }
        }
        /// <summary>
        /// A measurement of time in the SI (International System of Units)
        /// </summary>
        /// <remarks>
        /// The second (s) was originally based on a "standard day" of 24 hours, with each hour divided in 60 minutes and each minute divided in 60 seconds. However, we now know that a complete rotation of the Earth actually takes 23 hours, 56 minutes, and 4.1 seconds. Therefore, a second is now defined as the duration of 9,192,631,770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the cesium-133 atom.
        /// </remarks>
        public struct Second : Measure
        {
            public decimal Value { get; private set; }
            public string UnitSymbol => "s";
            public Second(decimal value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return $"{Value} {UnitSymbol}";
            }
        }
        /// <summary>
        /// A measurement of temperature in the SI (International System of Units)
        /// </summary>
        /// <remarks>
        /// The kelvin (K) is the unit of the thermodynamic temperature scale. This scale starts at 0 K. The incremental size of the kelvin is the same as that of the degree on the Celsius (also called centigrade) scale. The kelvin is the fraction 1/273.16 of the thermodynamic temperature of the triple point of water (exactly 0.01 °C, or 32.018 °F).
        /// </remarks>
        public struct Kelvin : Measure
        {
            public decimal Value { get; private set; }
            public string UnitSymbol => "K";
            public Kelvin(decimal value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return $"{Value} {UnitSymbol}";
            }
        }
        /// <summary>
        /// A measurement of electric current in the SI (International System of Units)
        /// </summary>
        /// <remarks>
        /// The ampere (A) is a measure of the amount of electric charge passing a point in an electric circuit per unit time. 6.241×1018 electrons, or one coulomb, per second constitutes one ampere.
        /// </remarks>
        public struct Ampere : Measure
        {
            public decimal Value { get; private set; }
            public string UnitSymbol => "A";
            public Ampere(decimal value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return $"{Value} {UnitSymbol}";
            }
        }
        /// <summary>
        /// A measurement of the amount of a substance in the SI (International System of Units)
        /// </summary>
        /// <remarks>
        /// The mole (mol) is a number that relates molecular or atomic mass to a constant number of particles. It is defined as the amount of a substance that contains as many elementary entities as there are atoms in 0.012 kg of carbon-12.
        /// </remarks>
        public struct Mole : Measure
        {
            public decimal Value { get; private set; }
            public string UnitSymbol => "mol";
            public Mole(decimal value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return $"{Value} {UnitSymbol}";
            }
        }
        /// <summary>
        /// A measurement of luminous intensity in the SI (International System of Units)
        /// </summary>
        /// <remarks>
        /// The candela (cd) was so named to refer to "candlepower" back in the days when candles were the most common source of illumination (because so many people used candles, their properties were standardized). Now, with the prevalence of incandescent and fluorescent light sources, the candela is defined as the luminous intensity in a given direction of a source that emits monochromatic radiation of frequency 540 x 10^12 Hertz and that has a radiant intensity in that direction of 1/683 watts per steradian.
        /// </remarks>
        public struct Candela : Measure
        {
            public decimal Value { get; private set; }
            public string UnitSymbol => "cd";
            public Candela(decimal value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return $"{Value} {UnitSymbol}";
            }
        }
    }
}
