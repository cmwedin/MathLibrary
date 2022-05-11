
using System;
using System.Collections.Generic;
using UnityEngine;


namespace SadSapphicGames.MathLibrary {
    public class BernsteinPolynomial : Polynomial {
        //* Constructor
        public BernsteinPolynomial(
            int n, // ? degree of the polynomial 
            float[] bernsteinVector // ? Vector rep of the polynomial in the space of all Bernstein Polynomials
        ) : base(n, new float[n+1] ) {
            if (bernsteinVector.Length != n+1) throw new Exception("invalid Vector length, must be n+1");
            for (int i = 0; i <= n; i++) { // ? for all powers zero to n
                for (int j = 0; j <= n; j++) { // ? for all n+1 basis bernstein polynomials
                    Coefficients[i] += bernsteinVector[j] * BasisPolynomialCoeffs(n,j)[i];  
            } } 
        }
        // * Basis Polynomial functions
        private float[] BasisPolynomialCoeffs( //? gets the coefficients of the basis polynomial 
            int n, //? degree of the polynomial space
            int v  //? which basis of that space (element of [0,n])
        ) {
            if(v > n || v < 0) throw new Exception($"illegal argument to BasisPolynomial, v={v},n={n}");
            float[] output = new float[n+1];
            Array.Fill<float>(output,0);
            for (int i = v; i <= n; i++) { // ? https://en.wikipedia.org/wiki/Bernstein_polynomial#Properties (see transformation to monomials)
                output[i] = 
                    (float)Functions.BinomialCoefficient(n,i)*(float)Functions.BinomialCoefficient(i,v)*Mathf.Pow(-1,i-v);
            }
            return output;
        }

        public static Dictionary<int, BernsteinPolynomial> GetSpaceBasis(int n) { // ? gets all n+1 basis vectors for the space of bernstein polynomials of degree n
            Dictionary<int, BernsteinPolynomial> output = new Dictionary<int, BernsteinPolynomial>();
            float[] vector = new float[n+1];
            for (int v = 0; v <= n; v++) {
                vector[v] = 1;
                output.Add(v, new BernsteinPolynomial(n,vector));
                vector[v] = 0;
            }
            return output;
        }
    }
}