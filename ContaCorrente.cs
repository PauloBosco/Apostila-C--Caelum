class ContaCorrente : Conta{

    public ContaCorrente(int numero){
        this.Numero = numero;
    }
    public override bool Saca(double valor)
    {
        base.Saca(valor);
        return true;
    }

}