
using UnityEngine;

namespace SadSapphicGames.MathLibrary {
    public class BernsteinPolynomial : IPolynomial {
        public int Degree { get; set; }
        public float[] Coefficients { get; set; }

        //* private fields
        private int v;
        private int V {get{return v;} set {if(0 <= v && v <=Degree) v = value;}}

        //* Constructor
        public BernsteinPolynomial(int _v, int n){
            Degree = n;
            V = _v;
            for (int i = _v; i <= n; i++) {
                Coefficients[i] = 
                    (float)Functions.BinomialCoefficient(n,i)*(float)Functions.BinomialCoefficient(i,_v)*Mathf.Pow(-1,i-_v);
            }
        }
        public BernsteinPolynomial(int _v, float[] _coefficients) {
            Degree = _coefficients.Length;
            Coefficients = _coefficients;
        }

        //* public methods
        public BernsteinPolynomial GetDerivative() {
            BernsteinPolynomial b1 = new BernsteinPolynomial(V-1,Degree-1);
            BernsteinPolynomial b2 = new BernsteinPolynomial(V,Degree-1);
            float[] derivCoeff = new float[Degree - 1];
            for (int i = 0; i < Degree; i++) {
                //TODO set coefficients
            }
            return new BernsteinPolynomial(V-1,derivCoeff);
        }
    }
}