class Pessoa
{
    private string _Nome;
    private int _Idade;
    private string _Email;
    private int _CPF;
    
    public string getNome()
    {
        return _Nome;
    }

    public void setNome(string nome)
    {
        this._Nome = nome;
    }

        public int getIdade()
    {
        return _Idade;
    }

    public void setIdade(int idade)
    {
        this._Idade = idade;
    }

    public string getEmail()
    {
        return _Email;
    }

    public void setEmail(string email)
    {
        this._Email = email;
    }

    public int getCPF()
    {
        return _CPF;
    }

    public void setCPF(int cpf)
    {
        this._CPF = cpf;
    }
}