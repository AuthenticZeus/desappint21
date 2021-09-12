using System;

namespace p15_controlbancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta Bancaria cta1=new CuentaBancaria();
            Cuenta Bancaria cta2=new CuentaBancaria();
            Cuenta Bancaria cta3;
            cta3= new CuentaBancaria();
            
            cta1.saldo=10;
            cta2.saldo=20;
            cta3.saldo=30;
        }
    }
}
