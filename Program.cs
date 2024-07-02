//*****************************************************************************
//** 231. Power of Two leetcode                                              **
//*****************************************************************************


bool isPowerOfTwo(int n) {
    if (n <= 0) return false;
    return (n & (n - 1)) == 0;
/*
//**************************************************************
//** This was my first attempt, it ran slower                 **
//** The above code runs faster  -Dan                         **
//**************************************************************

    if(n <= 0) return false;
    if(n % 2 == 1 && n > 1) return false;
    double t = 2;
    for(int i = 0; i < n+1; i++)
    {
        double out = pow(t, i);
//        printf("Out = %f\n",out);
        if(out == n) return true;
        if(i > n) return false;
    }
    return false;
*/
}