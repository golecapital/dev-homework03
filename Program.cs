using System;

namespace dev_homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program prg=new Program();
            prg.Ejercicio1();
            prg.Ejercicio2();

        }

        private void Ejercicio1(){
            var valores = new int[]{1,3,4,5,6};
            int res=0;

            Console.WriteLine(valores.Length);
            for(int i=0;i<valores.Length;i++){
                res=res+valores[i];
            }

            Console.WriteLine(res);
        }

        private void Ejercicio2(){
            var valores = new int[]{1,5,0,0,0,-1,-5};
            int cero=0, pos=0, neg = 0;
            double poss=0D;
            double negs=0D;
            double ceros=0D;

            for(int i=0;i<valores.Length;i++){
                if (valores[i]==0)
                {
                    cero=cero+1;
                }else if(valores[i]<0){
                    neg=neg+1;
                }else{
                    pos=pos+1;
                }
            }

            ceros=(Double)cero/valores.Length;
            poss=(Double)pos/valores.Length;
            negs=(Double)neg/valores.Length;
            Console.WriteLine($"Positivos= {pos} ratio: {poss}");
            Console.WriteLine($"Negativos= {neg} ratio: {negs}");
            Console.WriteLine($"Cero= {cero} ratio: {ceros}");
        }

    }
}
