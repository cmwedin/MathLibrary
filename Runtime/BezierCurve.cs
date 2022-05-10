using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SadSapphicGames.MathLibrary {
    public class BezierCurve {
        private int degree = 3; //? in case i want to extend beyond the cubic in the future
        private Vector3[] definingPoints;
        private Func<float,float>[] BernsteinBasis;
        // * Constructors
        public BezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) {
            definingPoints = new Vector3[degree+1];
            BernsteinBasis = new Func<float, float>[degree+1];
            definingPoints[0] = p0;
            BernsteinBasis[0] = GetBernsteinBasisPolynomial(degree,0);
            definingPoints[1] = p1;
            BernsteinBasis[1] = GetBernsteinBasisPolynomial(degree,1);
            definingPoints[2] = p2;
            BernsteinBasis[2] = GetBernsteinBasisPolynomial(degree,2);
            definingPoints[3] = p3;
            BernsteinBasis[3] = GetBernsteinBasisPolynomial(degree,3);
        }
        // * public Functions
        public Vector3 GetValue(float t) {
            Vector3 output = Vector3.zero;
            for (int i = 0; i <= degree; i++) {
                output += definingPoints[i]*BernsteinBasis[i](t);
            }
            return output;
        }

        // * Private Functions
        // ? Bezier Curves can be expressed as vectors in the space of polynomials defined by the following basis
        private Func<float, float> GetBernsteinBasisPolynomial(int n,int v) { //? n is the degree of the bezier curve, v is an element of [0,n]
            if(v > n || v < 0) throw new Exception("illegal argument");
            Func<float, float> output = t => (float)((double)Functions.BinomialCoefficient(n,v)*Math.Pow(t,v)*Math.Pow(1-t,n-v));
            return output;
        }
    }
}
