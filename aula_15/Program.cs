class Program
{
    static void Main()
    {
        // Exercício 1
        Animal animal = new Animal("AnimalGenérico", 3);
        animal.EmitirSom();

        Cachorro cachorro = new Cachorro("Fido", 2);
        cachorro.EmitirSom();

        Gato gato = new Gato("Whiskers", 4);
        gato.EmitirSom();

        // Exercício 2
        CachorroComPatas cachorroComPatas = new CachorroComPatas("Rex", 3, 4);
        cachorroComPatas.EmitirSom();

        GatoComPatas gatoComPatas = new GatoComPatas("Mittens", 5, 4);
        gatoComPatas.EmitirSom();

        // Exercício 3
        AnimalComPatas animalComPatas = new AnimalComPatas("AnimalComPatasGenérico", 2, 4);
        animalComPatas.EmitirSom();

        // Exercício 4
        List<Animal> listaAnimais = new List<Animal>
        {
            new Cachorro("Dog1", 2),
            new Gato("Cat1", 3),
            new Cachorro("Dog2", 1),
            new Gato("Cat2", 4)
        };

        foreach (var a in listaAnimais)
        {
            a.EmitirSom();
        }
    }
}
