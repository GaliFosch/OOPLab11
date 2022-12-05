using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        public double Real{get; private set;}
        public double Imaginary{get; private set;}

        public double Modulus{get => Math.Sqrt(Real*Real+Imaginary*Imaginary);}
        public double Phase{
            get
            {
                if(Real!=0 && Imaginary!=0)
                {
                    return 2*Math.Atan(Imaginary/(Modulus+Real));
                }else if(Real == 0 && Imaginary == 0)
                {
                    return 0;
                }else if(Real==0)
                {
                    return (Imaginary > 0) ? Math.PI/2 : (3 * Math.PI)/2;
                }else
                {
                    return (Real > 0) ? 0 : Math.PI;
                }
            }
        }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public Complex Complement() => new Complex(-Real,-Imaginary);

        public Complex Plus(Complex c) => new Complex(Real + c.Real, Imaginary + c.Imaginary);

        public Complex Minus(Complex c) => new Complex(Real - c.Real, Imaginary - c.Imaginary);

        public bool Equals(Complex c) => (Real == c.Real && Imaginary == c.Imaginary);

        public new string ToString() => Real.ToString() + (Imaginary>=0 ? "+" : "" ) + Imaginary.ToString() + "i";

    }
}