using System;

abstract class Reptil
{
    public string Nome { get; set; }
}

interface Terrestre
{
    void Andar();
}

interface Aquatico
{
    void Nadar();
}

class Jacare : Reptil, Terrestre, Aquatico
{
    public void Andar()
    {
        throw new NotImplementedException();
    }

    public void Nadar()
    {
        throw new NotImplementedException();
    }
}

class Cobra : Reptil, Terrestre
{
    public void Andar()
    {
        throw new NotImplementedException();
    }
}

class Tarturaga : Reptil, Aquatico
{
    public void Nadar()
    {
        throw new NotImplementedException();
    }
}