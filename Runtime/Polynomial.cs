using UnityEngine;

namespace SadSapphicGames.MathLibrary {
    public class Polynomial : IPolynomial
    {
        private float[] _coefficients;

        public Polynomial(int degree, float[] coefficients) {
            Degree = degree;
            Coefficients = coefficients;
        }

        public int Degree { get; set; }
        public float[] Coefficients { 
            get => _coefficients; 
            set { 
                if (value.Length != Degree + 1) Debug.LogWarning($"A polynomial of degree {Degree} must have {Degree + 1} coefficients, entered {value.Length}");
                else _coefficients = value;
            } }

        public Polynomial Derivative { get { // ? if this code confuses you see https://en.wikipedia.org/wiki/Polynomial#Calculus
            float[] derivCoefficients = new float[Degree];
            for (int i = 1; i <= Degree; i++) {
                derivCoefficients[i-1] = i * Coefficients[i];
            }
            return new Polynomial(Degree - 1,derivCoefficients);
        } }

        public float Evaluate(float t) {
            float result = 0;
            for (int i = 0; i <= Degree; i++) {
                result += Coefficients[0] * Mathf.Pow(t,i);
            }
            return result;
        }
    }
}