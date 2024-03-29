using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

namespace SadSapphicGames.MathLibrary{
    public class MathUtilities {
        public static BigInteger BinomialCoefficient(BigInteger N, BigInteger K) { //? BigInt might be overkill
            BigInteger result = 1;
            if( K > N) return 0;
            if (K > N - K) { K = N - K; } //? function is symmetric so using the smaller k is faster
            for (BigInteger d = 1; d <= K; d++) {
                result *= N--;
                result /= d;
            }
            return result;
        }
    }
}
