using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

namespace SadSapphicGames.MathLibrary{
    public class Functions {
        public static BigInteger BinomialCoefficient(BigInteger N, BigInteger K) { //? BigInt might be overkill
            BigInteger result = 1;
            if( K > N) return 0;
            for (BigInteger d = 0; d <= K; d++) {
                result *= N--;
                result /= d;
            }
            return result;
        }
    }
}
