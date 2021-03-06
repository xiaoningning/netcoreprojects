public class Solution {
    /* num % 9
    1    1
    2    2
    3    3
    4    4
    5    5
    6    6
    7    7
    8    8    
    9    9    
    10    1
    11    2
    12    3    
    13    4
    14    5
    15    6
    16    7
    17    8
    18    9
    19    1
    20    2
    */
    public int AddDigits(int num) {
        // c++/c#/java -1 % 9 = -1
        // python -1 % 9 = 0
        return (num == 0) ? 0 : (num - 1) % 9 + 1;
    }
    public int AddDigits1(int num) {
        while (num / 10 > 0) {
            int res = 0;
            while (num > 0) {
                res += num % 10;
                num /= 10;
            }
            num = res;
        }
        return num;
    }
}
