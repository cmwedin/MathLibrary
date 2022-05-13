using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SadSapphicGames.MathLibrary {
    public class BezierCurve {
        private int degree = 3; //? in case i want to extend beyond the cubic in the future
        private Vector3[] definingPoints;
        private Dictionary<int, BernsteinPolynomial> BernsteinBasis {get => BernsteinPolynomial.GetSpaceBasis(degree);}
        // * Constructors
        public BezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) {
            definingPoints = new Vector3[degree+1];
            definingPoints[0] = p0;
            definingPoints[1] = p1;
            definingPoints[2] = p2;
            definingPoints[3] = p3;
        }
        // * public Functions
        public Vector3 GetValue(float t) {
            Vector3 output = Vector3.zero;
            for (int i = 0; i <= degree; i++) {
                output += definingPoints[i]*BernsteinBasis[i].Evaluate(t);
            }
            return output;
        }

        // * Private Functions

    }
}
