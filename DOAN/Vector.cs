using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{
    public class Vector
    {
        public List<double> components;

        // Constructor
        public Vector(int dimension)
        {
            if (dimension <= 0)
            {
                throw new ArgumentException("Dimension must be positive.");
            }

            components = new List<double>(dimension);
            for (int i = 0; i < dimension; i++)
            {
                components.Add(0.0);
            }
        }
        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= components.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return components[index];
            }
            set
            {
                if (index < 0 || index >= components.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                components[index] = value;
            }
        }
        
        // Property to get the dimension of the vector
        public int Dimension => components.Count;
        public double Eculid(Vector other)
        {
            if(other.Dimension != this.Dimension)
            {
                throw new ArgumentException("Vectors must have the same dimension.");
            }
            else
            {
                double sum = 0.0;
                for (int i = 0; i < Dimension; i++)
                {
                    sum += (this[i] - other[i])*(this[i] - other[i]);
                }
                return Math.Sqrt(sum);
            }
        }
        public double Dot(Vector other)
        {
            if (other.Dimension != this.Dimension)
            {
                throw new ArgumentException("Vectors must have the same dimension.");
            }
            else
            {
                double sum = 0.0;
                for (int i = 0; i < Dimension; i++)
                {
                    sum += (this[i] * other[i]);
                }
                return sum;
            }
        }
        // Method to compute the magnitude (length) of the vector
        public double Magnitude()
        {
            double sumOfSquares = 0.0;
            foreach (double component in components)
            {
                sumOfSquares += component * component;
            }
            return Math.Sqrt(sumOfSquares);
        }

        // Method to add another vector to this vector
        public void Add(Vector other)
        {
            if (other.Dimension != Dimension)
            {
                throw new ArgumentException("Vectors must have the same dimension to be added.");
            }
            for (int i = 0; i < Dimension; i++)
            {
                this[i] += other[i];
            }
        }

        // Method to multiply the vector by a scalar
        public void Multiply(double scalar)
        {
            for (int i = 0; i < Dimension; i++)
            {
                this[i] *= scalar;
            }
        }

        // Method to print the vector
        public void Print()
        {
            Console.Write("(");
            for (int i = 0; i < Dimension; i++)
            {
                Console.Write($"{this[i]}");
                if (i < Dimension - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(")");
        }
    }
}
