// Написать программу вычисления функции Аккермана - 5*

// Я вообще не понял, что это и зачем нужно. Код понял, функцию нет


int A(int m, int n){
    if(m == 0){
        return n+1;
    } else{
        if(m > 0 && n == 0){
            return A(m -1, 1);
        } else{
            //if(n > 0 && m > 0){
                return A(m -1, A(m, n-1));
            
        }
    }
}

System.Console.WriteLine(A(0,0));