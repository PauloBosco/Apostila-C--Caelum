class ContaPoupanca : Conta{

    public ContaPoupanca (int numero){
        this.Numero = numero;
    }

    public override bool Saca(double valor)
    {
        base.Saca(valor + 0.10);
        return true;
    }

}