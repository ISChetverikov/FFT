using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTplot
{
    class Complex
    {
        public double MAG { get; set; }
        public double Phase { get; set; }

        public Complex() { MAG = 0; Phase = 0; }
        public Complex(double _MAG) 
        {
            if (_MAG < 0)
            {
                MAG = -_MAG;
                Phase = Math.PI;
            }
            else
            {
                MAG = _MAG;
                Phase = 0;
            } 
        }
        public Complex(double _MAG, double _phase) 
        {
            if(MAG < 0) throw new Exception("Неверный модуль!");
            MAG = _MAG; 
            Phase = _phase % (2 * Math.PI);
            if (Phase < 0) Phase += 2 * Math.PI;
        }

        public override string ToString()
        {
            return String.Format("{0:0.#####} * exp(i * {1:0.#####})", MAG, Phase);
        }

        public string ToAlgebraicFormString()
        {
            var Re = MAG * Math.Cos(Phase);
            var Im = MAG * Math.Sin(Phase);
            return String.Format("{0:0.#####} + i * {1:0.#####}", Re, Im);
        }

        public Complex Rotation(double angle)
        {
            var newPhase = Phase + angle;

            newPhase = newPhase % (2 * Math.PI);
            if (newPhase < 0) newPhase += 2 * Math.PI;

            return new Complex(this.MAG, newPhase);
        }

        public static Complex operator * (Complex a, Complex b)
        {
            return new Complex(a.MAG * b.MAG, a.Phase + b.Phase);
        }

        public static Complex operator * (Complex a, double c)
        {
            return new Complex(a.MAG * c, a.Phase);
        }

        public static Complex operator *(double c, Complex a)
        {
            return new Complex(a.MAG * c, a.Phase);
        }

        public static Complex operator +(Complex a, Complex b)
        {
            var Re = a.MAG * Math.Cos(a.Phase) + b.MAG * Math.Cos(b.Phase);
            var Im = a.MAG * Math.Sin(a.Phase) + b.MAG * Math.Sin(b.Phase);

            return new Complex(Math.Sqrt(Re * Re + Im * Im), Math.Atan2(Im, Re));
        }

        public static Complex operator +(Complex a, double c)
        {
            
            return a + new Complex(c);
        }

        public static Complex operator +(double c, Complex a)
        {
            return new Complex(c) + a;
        }

        
    }
}
