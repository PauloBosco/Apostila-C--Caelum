abstract class Conta {
    private int _numero;
    private double _saldo;
    private Cliente? _titular;

    public int Numero{
        get{return this._numero;}
        set{this._numero = value;}
    }

    public Cliente? Titular{
        get{return this._titular;}
        set{this._titular =value;}
    }

    public double Saldo{
        get {return this._saldo;}
        set {this._saldo = value;}
    }

    public virtual bool Saca(double valor)
    {
        if(this.Saldo >= valor)
        {
            this.Saldo -=valor;
            return true;
        }
        Console.WriteLine("SALDO INSUFICIENTE");
        return false;

    }

    public void Deposita(double valor)
    {
        this.Saldo += valor;
    }

    public void Transfere(double valor, Conta destino)
    {
        if(this.Saca(valor))
        {
            destino.Deposita(valor);
        }
    }
}
