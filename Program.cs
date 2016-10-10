using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_EAD1
{
    public abstract class ThreeDShape
    {
        private string shape;

        public string Shape
        {
            get
            {
                return shape;
            }
        }


        public ThreeDShape(string shape)
        {
            this.shape = shape;
        }

        public ThreeDShape() : this("")
        {

        }

        public abstract double CalcVolume(double figure);

        public override string ToString()
        {
            return shape;
        }
    }

    class sphere : ThreeDShape
    {
        private double radius;

        public sphere(double radius)
        {
            this.radius = radius;
        }

        public sphere() : this(0.0)
        {

        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public override double CalcVolume(double figure)
        {
            double pi = Math.PI;

            double answer = pi * figure * figure * figure;

            return answer;
        }

        public override string ToString()
        {
            return "The shape is a sphere with a radius of " + radius.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            Lab1_EAD1.ThreeDShape[] tds = { new Lab1_EAD1.sphere(), new Lab1_EAD1.sphere(11) };
        }
    }
    
}
