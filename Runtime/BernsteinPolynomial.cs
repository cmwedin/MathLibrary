
using System;
using UnityEngine;

namespace SadSapphicGames.MathLibrary {
    public class BernsteinPolynomial : Polynomial {
        //* private fields
        private int v;
        private int V {get{return v;} set {if(0 <= v && v <=Degree) v = value;}}

        //* Constructor
        public BernsteinPolynomial(
            int n, // ? degree of the polynomial 
            float[] bernsteinVector // ? Vector rep of the polynomial in the space of all Bernstein Polynomials
        ) : base(n, new float[n+1] ) {
            if (bernsteinVector.Length != n+1) throw new Exception("invalid Vector length, must be n+1");
            for (int i = 0; i <= n; i++) {
                for (int j = 0; j <= n; j++) {
                    Coefficients[j] += bernsteinVector[j] * BasisPolynomial(i,n)[j];  
            } } 
        }
        // * Basis Polynomial functions
        private float[] BasisPolynomial( //? gets the coefficients of the basis polynomial 
            int n, //? degree of the polynomial space
            int v  //? which basis of that space (element of [0,n])
        ) {
            if(v > n || v < 0) throw new Exception("illegal argument");
            float[] output = new float[n];
            Array.Fill<float>(output,0);
            for (int i = v; i <= n; i++) { // ? https://en.wikipedia.org/wiki/Bernstein_polynomial#Properties (see transformation to monomials)
                output[i] = 
                    (float)Functions.BinomialCoefficient(n,i)*(float)Functions.BinomialCoefficient(i,v)*Mathf.Pow(-1,i-v);
            }
            return output;
        }
    }
}