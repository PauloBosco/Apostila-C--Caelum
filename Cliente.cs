class Cliente{
    private string? _nome;
    private string? _cpf;
    private string? _rg;
    private string? _endereco;

    public Cliente (string nome){
        this.Nome = nome;
    }

    public Cliente(){
        
    }
    
    public string? Nome{
        get{return this._nome;}
        set{this._nome = value;}
    }

    public string? CPF{
        get{return this._cpf;}
        set{this._cpf = value;}
    }

    public string? RG{
        get{return this._rg;}
        set{this._rg = value;}
    }

    public string? Endereco{
        get{return this._endereco;}
        set{this._endereco = value;}
    }
}