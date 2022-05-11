using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SadSapphicGames.MathLibrary;

public class BernsteinTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void BernsteinBasisTest() { //? just testing degree 3 for now since we need those for bezier curves
        var basis = BernsteinPolynomial.GetSpaceBasis(3);
        Assert.AreEqual(
            expected: new float[4] {
                1, -3, 3, -1
            },
            actual: basis[0].Coefficients
        );
        Assert.AreEqual(
            expected: new float[4] {
                0, 3, -6, 3
            },
            actual: basis[1].Coefficients
        );    
            Assert.AreEqual(
            expected: new float[4] {
                0, 0, 3, -3
            },
            actual: basis[2].Coefficients
        );        
        Assert.AreEqual(
            expected: new float[4] {
                0, 0, 0, 1
            },
            actual: basis[3].Coefficients
        );
    }
}
